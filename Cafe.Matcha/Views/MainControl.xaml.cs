﻿// Copyright (c) FFCafe. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.

namespace Cafe.Matcha.Views
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Linq;
    using System.Net.Http;
    using System.Windows;
    using System.Windows.Controls;
    using Advanced_Combat_Tracker;
    using Cafe.Matcha.Constant;
    using Cafe.Matcha.DTO;
    using Cafe.Matcha.Network;
    using Cafe.Matcha.Utils;
    using Microsoft.Win32;
    using Newtonsoft.Json.Linq;
    using RateLimiting;

    /// <summary>
    /// MainControl.xaml 的交互逻辑.
    /// </summary>
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            Config.Load();
            InitializeComponent();
            Init();
            lbCurrentVer.Content = Data.Version;
            lbLatestVer.Content = "从未检查";
            if (Config.Instance.Logger.CheckUpdate)
            {
                GetVersion();
            }
        }

        private bool isInitialCheck = true;

        private ViewModels.MainViewModel viewModel = null;
        private ViewModels.MainViewModel ViewModel
        {
            get
            {
                if (viewModel == null)
                {
                    viewModel = (ViewModels.MainViewModel)DataContext;
                }

                return viewModel;
            }
        }

        private IActPluginV1 ffxivPlugin = null;

        public void DeInit()
        {
            if (ParsePlugin.Instance != null)
            {
                ParsePlugin.Instance.Stop();
            }

            Utils.Log.Handler -= Log;
            Data.Instance.PropertyChanged -= Data_PropertyChanged;
        }

        private async void Init()
        {
            ViewModel.PropertyChanged += (_, e) =>
            {
                if (e.PropertyName == "Fates")
                {
                    var fateNodes = ViewModel.Fates.SelectMany(fateTree => fateTree.Leaves);

                    foreach (var fateNode in fateNodes)
                    {
                        fateNode.IsChecked = Config.Instance.Watch.Fates.Contains(((ViewModels.FateNode)fateNode).Id);
                        fateNode.PropertyChanged += FateNode_PropertyChanged;
                    }
                }
            };
            Data.Instance.PropertyChanged += Data_PropertyChanged;
            Data.Instance.Init();

            State.Instance.PropertyChanged += (_, e) =>
            {
                if (e.PropertyName == "WorldId")
                {
                    NotifyFateWatchList();
                }
            };

            Utils.Log.Handler += Log;
            ffxivPlugin = await Helper.GetFFXIVPlugin();

            Telemetry.Init();
            Helper.CheckLicenseNotice();

            var network = new NetworkMonitor();
            network.OnException += LogException;
            network.OnReceiveEvent += Network_onReceiveEvent;


            ParsePlugin.Init(ffxivPlugin, network);

            if (Config.Instance.Language == null)
            {
                Config.Instance.Language = ParsePlugin.Instance.GetLanguage();
            }

            if (Config.Instance.Region == null)
            {
                Config.Instance.Region = ParsePlugin.Instance.GetRegion();
            }

            ParsePlugin.Instance.Network = network;
            ParsePlugin.Instance.Start();
        }

        private void FateNode_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "IsChecked")
            {
                HandleFateNodeChange((ViewModels.FateNode)sender);
            }
        }

        private void Data_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Fates")
            {
                ViewModel.Fates = ViewModels.FateTreeNodeWithChildren.Create(Data.Instance.Fates);
            }
        }

        private void HandleFateNodeChange(ViewModels.FateNode fateNode)
        {
            var fates = Config.Instance.Watch.Fates;
            var index = fates.IndexOf(fateNode.Id);
            if (fateNode.IsChecked)
            {
                if (index == -1)
                {
                    fates.Add(fateNode.Id);
                    if (notifiedFate.Contains(fateNode.Id))
                    {
                        Output.Send(new FateDTO { Type = "start", Fate = fateNode.Id });
                    }
                }
            }
            else
            {
                if (index != -1)
                {
                    fates.RemoveAt(index);
                }
            }

            NotifyFateWatchList();
        }

        private void NotifyFateWatchList()
        {
            Config.Instance.Watch.Fates.Debounce(500, (fates) =>
            {
                Output.SendLog(new FateWatchListChangedDTO() { World = State.Instance.WorldId, Fates = ((ObservableCollection<int>)fates).ToArray() });
            });
        }

        private void Network_onReceiveEvent(BaseDTO dto)
        {
            var isFateProgress = dto is FateDTO f && f.Type == "progress";

            Output.SendLog(dto, !isFateProgress);
            Output.SendWebhook(dto);

            if (!isFateProgress)
            {
                Utils.Log.Info(LogType.Event, string.Format("[{0}] {1}", dto.EventType, dto.ToJSON()));
            }

            if (!ShouldSendNotice(dto))
            {
                return;
            }

            var output = Formatter.GetEventText(dto);
            Output.Send(output);
        }

        private HashSet<int> notifiedFate = new HashSet<int>();
        private HashSet<int> notifiedDynamicEvent = new HashSet<int>();

        private bool ShouldSendNotice(BaseDTO dto)
        {
            switch (dto.EventType)
            {
                case EventType.MatchAlert:
                    return true;
                case EventType.InitZone:
                    notifiedFate.Clear();
                    return true;
                case EventType.Fate:
                    var fateDto = (FateDTO)dto;
                    switch (fateDto.Type)
                    {
                        case "start":
                        case "progress":
                            if (notifiedFate.Contains(fateDto.Fate) || !Config.Instance.Watch.Fates.Contains(fateDto.Fate))
                            {
                                return false;
                            }

                            notifiedFate.Add(fateDto.Fate);
                            if (Config.Instance.Formatter.Fate.MuteWhileLoading)
                            {
                                return Helper.Now - State.Instance.LastZoneChange > 5000;
                            }

                            return true;
                        case "end":
                            notifiedFate.Remove(fateDto.Fate);
                            return false;
                    }

                    return false;
                case EventType.FishBite:
                    return true;
                case EventType.TreasureResult:
                    return true;
                case EventType.DynamicEvent:
                    var deDto = (DynamicEventDTO)dto;
                    switch (deDto.Stage)
                    {
                        case 1:
                        case 2:
                            if (notifiedDynamicEvent.Contains(deDto.Event))
                            {
                                return false;
                            }

                            notifiedDynamicEvent.Add(deDto.Event);
                            return true;
                        default:
                            notifiedDynamicEvent.Remove(deDto.Event);
                            return false;
                    }

                default:
                    return false;
            }
        }

        private void LogException(Exception e)
        {
            try
            {
                Log(LogType.None, 'E', string.Format("[{0}]{1}\r\n{2}", e.GetType(), e.Message, e.StackTrace));
            }
            catch { }
        }

        private Models.ConfigLogger ConfigLogger => Config.Instance.Logger;
        private void Log(LogType type, char level, string message)
        {
            var vm = ViewModel;
            ++vm.LogAllCount;

            if (
                !ConfigLogger.Enabled
                || vm.LogPause
                || (vm.LogTypeFilter && type != vm.LogTypeFilterValue)
#if DEBUG
                || (level == 'D' && !ConfigLogger.Debug)
#else
                || (level == 'I' && !ConfigLogger.Debug)
#endif
#pragma warning disable SA1009 // Closing parenthesis should be spaced correctly
            )
#pragma warning restore SA1009 // Closing parenthesis should be spaced correctly
            {
                return;
            }

            string typeString = Enum.GetName(typeof(LogType), type);
            vm.Log = string.Format("[{0}][{1}][{2}] {3}\r\n", DateTime.Now, level, typeString, message) + vm.Log;
            ++vm.LogShowCount;
        }

        private void BSettingOutputTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Output.Send("Matcha Test");
            }
            catch (Exception err)
            {
                LogException(err);
            }
        }

        private void BSettingFateTest_Click(object sender, RoutedEventArgs e)
        {
            if (Data.Instance.Instances.Count == 0)
            {
                MessageBox.Show("加载 Fate 数据时失败，无法测试");
                return;
            }

            try
            {
                var fateId = Data.Instance.Fates.Keys.ElementAt(0);
                Output.Send(new FateDTO() { Fate = fateId, Type = "start" });
            }
            catch (Exception err)
            {
                LogException(err);
            }
        }

        private void BSettingZoneTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Output.Send(new InitZoneDTO { Zone = 217, Instance = 15 });
            }
            catch (Exception err)
            {
                LogException(err);
            }
        }

        private void BSettingInstTest_Click(object sender, RoutedEventArgs e)
        {
            if (Data.Instance.Instances.Count == 0)
            {
                MessageBox.Show("加载副本数据时失败，无法测试");
                return;
            }

            try
            {
                var instId = Data.Instance.Instances.Keys.ElementAt(0);
                Output.Send(Formatter.GetEventText(new MatchAlertDTO { Roulette = 0, Instance = instId }));
            }
            catch (Exception err)
            {
                LogException(err);
            }
        }

        private void BSettingSetTemplate_Click(object sender, RoutedEventArgs e)
        {
            var template = ViewModel.SelectedTemplate;
            if (template == null || template.Fates == null)
            {
                return;
            }

            ApplyFateList(template.Fates);
            MessageBox.Show(string.Format("已成功应用模板 [{0}]", template.LocalName), Data.Title);
        }

        private void ApplyFateList(List<int> list)
        {
            bool overrideAll = false;
            foreach (ViewModels.FateNode fateNode in ViewModel.Fates.SelectMany(fateTree => fateTree.Leaves))
            {
                bool targetValue = list != null && list.Contains(fateNode.Id);
                if (fateNode.IsChecked == targetValue)
                {
                    continue;
                }

                bool overrideThis = true;
                if (!overrideAll && fateNode.IsChecked)
                {
                    var confirm = new OverrideConfirm(
                        string.Format("已经选择了 [{0}]，是否要取消选择？", fateNode.LocalName),
                        "模板载入提示 - " + Data.Title);
                    overrideThis = confirm.ShowDialog() ?? false;
                    overrideAll = confirm.All;
                }

                if (overrideThis)
                {
                    fateNode.IsChecked = targetValue;
                }
            }
        }

        private void BSettingLoadTemplate_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "自定义模板(*.json)|*.json";
            if (openFileDialog.ShowDialog() == false)
            {
                return;
            }

            var list = FateManager.Load(openFileDialog.FileName);
            if (list == null)
            {
                MessageBox.Show("文件读取失败，请确认选择的文件由本插件导出", Data.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            ApplyFateList(list);
            MessageBox.Show(string.Format("已成功应用自定义模板 [{0}]", openFileDialog.FileName), Data.Title);
        }

        private void BSettingSaveTemplate_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "自定义模板(*.json)|*.json";
            if (saveFileDialog.ShowDialog() == false)
            {
                return;
            }

            FateManager.Save(saveFileDialog.FileName, Config.Instance.Watch.Fates);
            MessageBox.Show(string.Format("已成功保存自定义模板 [{0}]", saveFileDialog.FileName), Data.Title);
        }

        private void BSettingClearFate_Click(object sender, RoutedEventArgs e)
        {
            ApplyFateList(null);
        }

        private void BSettingDataReport_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new TelemetrySetting();
            dialog.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            dialog.ShowDialog();
        }

        private void BtnViewDetails_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://ffcafe.org/matcha/universalis/"));
        }

        private void BNewWebhook_Click(object sender, RoutedEventArgs e)
        {
            var item = new Models.ConfigWebhook()
            {
                ID = Guid.NewGuid().ToString(),
                Name = "新 Webhook",
                Endpoint = "https://www.example.com/",
                Type = RequestType.JSON
            };

            Config.Instance.Webhook.Add(item);
            ViewModel.SelectedWebhook = item;
        }

        private void BTestWebhook_Click(object sender, RoutedEventArgs e)
        {
            var webhook = ViewModel.SelectedWebhook;
            if (webhook == null)
            {
                return;
            }

            switch (webhook.Event)
            {
                case EventType.Fate:
                    Output.SendWebhook(new FateDTO { }, webhook);
                    break;
                case EventType.FishBite:
                    Output.SendWebhook(new FishBiteDTO { }, webhook);
                    break;
                case EventType.Gearset:
                    Output.SendWebhook(new GearsetDTO { }, webhook);
                    break;
                case EventType.InitZone:
                    Output.SendWebhook(new InitZoneDTO { }, webhook);
                    break;
                case EventType.MarketBoardItemListing:
                    Output.SendWebhook(new MarketBoardItemListingDTO { }, webhook);
                    break;
                case EventType.MarketBoardItemListingCount:
                    Output.SendWebhook(new MarketBoardItemListingCountDTO { }, webhook);
                    break;
                case EventType.MatchAlert:
                    Output.SendWebhook(new MatchAlertDTO { }, webhook);
                    break;
                case EventType.MiniCactpot:
                    Output.SendWebhook(new MiniCactpotDTO { }, webhook);
                    break;
                case EventType.TreasureSpot:
                    Output.SendWebhook(new TreasureSpotDTO { }, webhook);
                    break;
                case EventType.CompanyVoyageStatus:
                    Output.SendWebhook(new CompanyVoyageStatusDTO { }, webhook);
                    break;
                case EventType.None:
                    MessageBox.Show("请选择事件类型", Data.Title);
                    break;
                default:
                    MessageBox.Show(
                        string.Format("暂不支持测试 [{0}] 事件", Enum.GetName(typeof(EventType), webhook.Event)),
                        Data.Title);
                    break;
            }
        }

        private void BRemoveWebhook_Click(object sender, RoutedEventArgs e)
        {
            if (ViewModel.SelectedWebhook == null)
            {
                return;
            }

            var result = MessageBox.Show(
                string.Format("确认要删除 Webhook [{0}] 吗？", ViewModel.SelectedWebhook.Name),
                Data.Title, MessageBoxButton.YesNo);

            if (result == MessageBoxResult.No)
            {
                return;
            }

            Config.Instance.Webhook.Remove(ViewModel.SelectedWebhook);
            ViewModel.SelectedWebhook = null;
        }

        private void Image_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/thewakingsands/matcha"));
            e.Handled = true;
        }

        private void BLogClear_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.Log = "";
        }

        private void BLogPause_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.LogPause = !ViewModel.LogPause;
        }

        private void BtnCheckUpd_Click(object sender, RoutedEventArgs e)
        {
            isInitialCheck = false;
            GetVersion();
        }

        private void BtnOpenUpd_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/lsl1225/matcha/releases/latest"));
            e.Handled = true;
        }

        private async void GetVersion()
        {
            string apiPath = "https://api.github.com/repos/lsl1225/matcha/releases/latest";
            string errMsg = "检查更新失败，请稍后再试！";
            string foundNewVersion = "发现新版本，请在抹茶关于页更新！";
            string isLatestVersion = "当前已是最新版本！";

            lbCurrentVer.Content = Data.Version;
            lbLatestVer.Content = "正在检查更新...";
            btnCheckUpd.IsEnabled = false;

            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
            var response = await httpClient.GetAsync(apiPath);
            if (response.IsSuccessStatusCode)
            {
                try
                {
                    var str = await response.Content.ReadAsStringAsync();
                    JObject jsonObj = JObject.Parse(str.ToString());
                    jsonObj.TryGetValue("tag_name", out JToken token);
                    if (token != null)
                    {
                        string currentVer = Data.Version;
                        string currentLatestVer = token.ToString();
                        lbLatestVer.Content = currentLatestVer;

                        if (currentVer != currentLatestVer)
                        {
                            Output.SendToast(foundNewVersion);
                        }
                        else
                        {
                            if (!isInitialCheck)
                            {
                                Output.SendToast(isLatestVersion);
                            }
                            else
                            {
                                isInitialCheck = false;
                            }
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    lbLatestVer.Content = errMsg;
                    Output.SendToast(errMsg);
                }
            }
            else
            {
                lbLatestVer.Content = errMsg;
                Output.SendToast(errMsg);
            }

            btnCheckUpd.IsEnabled = true;
        }
    }
}
