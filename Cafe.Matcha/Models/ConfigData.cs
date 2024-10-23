﻿// Copyright (c) FFCafe. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.

namespace Cafe.Matcha.Models
{
    using System;
    using System.Collections.ObjectModel;
    using Cafe.Matcha.Constant;
    using Cafe.Matcha.Utils;
    using FFXIV_ACT_Plugin.Common;
    using Newtonsoft.Json;

    public class ConfigData : BindingTarget
    {
        public ConfigData() : this(null, null, null, null, null, null, null, null, null, null)
        {
        }

        [JsonConstructor]
        private ConfigData(
            Region? region,
            Language? language,
            string hash,
            ConfigOutput output,
            ConfigFormatter formatter,
            ConfigLogger logger,
            ConfigWatch watch,
            ConfigOverlay overlay,
            ConfigTelemetry telemetry,
            ObservableCollection<ConfigWebhook> webhook)
        {
            Region = region;
            Language = language;
            Hash = hash ?? null;
            Output = output ?? new ConfigOutput();
            Formatter = formatter ?? new ConfigFormatter();
            Logger = logger ?? new ConfigLogger();
            Watch = watch ?? new ConfigWatch();
            Overlay = overlay ?? new ConfigOverlay();
            Telemetry = telemetry ?? new ConfigTelemetry();
            Webhook = webhook ?? new ObservableCollection<ConfigWebhook>();
        }

        [JsonProperty("region")]
        public Region? Region { get; set; }

        [JsonProperty("language")]
        public Language? Language { get; set; }

        public string Hash { get; set; }

        [JsonProperty("overlay")]
        public ConfigOverlay Overlay { get; set; }

        [JsonProperty("telemetry")]
        public ConfigTelemetry Telemetry { get; set; }

        [JsonProperty("watch")]
        public ConfigWatch Watch { get; set; }

        [JsonProperty("output")]
        public ConfigOutput Output { get; set; }

        [JsonProperty("formatter")]
        public ConfigFormatter Formatter { get; set; }

        [JsonProperty("logger")]
        public ConfigLogger Logger { get; set; }

        [JsonProperty("webhook")]
        public ObservableCollection<ConfigWebhook> Webhook { get; set; }
    }

    public class ConfigWebhook : BindingTarget
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("event")]
        public EventType Event { get; set; }

        [JsonProperty("type")]
        public RequestType Type { get; set; }

        [JsonProperty("endpoint")]
        public string Endpoint { get; set; }

        [JsonProperty("header")]
        public string Header { get; set; }
    }

    public class ConfigTelemetry : BindingTarget
    {
        [JsonProperty("enable")]
        public bool Enable { get; set; } = false;

        [JsonProperty("uuid")]
        public string UUID { get; set; } = null;

        [JsonProperty("agreement")]
        public string Agreement { get; set; } = null;
    }

    public class ConfigOverlay : BindingTarget
    {
        [JsonProperty("universalis")]
        public bool Universalis { get; set; } = false;
    }

    public class ConfigWatch : BindingTarget
    {
        public ConfigWatch() : this(null)
        {
        }

        [JsonConstructor]
        private ConfigWatch(ObservableCollection<int> fates)
        {
            Fates = fates ?? new ObservableCollection<int>();
        }

        [JsonProperty("fate")]
        public ObservableCollection<int> Fates { get; set; }
    }

    public class ConfigOutput : BindingTarget
    {
        [JsonProperty("toast")]
        public bool Toast { get; set; } = true;
        [JsonProperty("tts")]
        public bool TTS { get; set; } = true;
    }

    public class ConfigFormatter : BindingTarget
    {
        public ConfigFormatter() : this(null, null, null, null, null, null)
        {
        }

        [JsonConstructor]
        private ConfigFormatter(
            ConfigFormatterFate fate,
            ConfigFormatterFish fish,
            ConfigFormatterInstance instance,
            ConfigFormatterZone zone,
            ConfigFormatterCriticalEngagement criticalEngagement,
            ConfigFormatterTreasure treasure)
        {
            Fate = fate ?? new ConfigFormatterFate();
            Fish = fish ?? new ConfigFormatterFish();
            Instance = instance ?? new ConfigFormatterInstance();
            Zone = zone ?? new ConfigFormatterZone();
            CriticalEngagement = criticalEngagement ?? new ConfigFormatterCriticalEngagement();
            Treasure = treasure ?? new ConfigFormatterTreasure();
        }

        [JsonProperty("fate")]
        public ConfigFormatterFate Fate { get; set; }
        [JsonProperty("fish")]
        public ConfigFormatterFish Fish { get; set; }
        [JsonProperty("instance")]
        public ConfigFormatterInstance Instance { get; set; }
        [JsonProperty("zone")]
        public ConfigFormatterZone Zone { get; set; }
        [JsonProperty("critical-engagement")]
        public ConfigFormatterCriticalEngagement CriticalEngagement { get; set; }
        [JsonProperty("treasure")]
        public ConfigFormatterTreasure Treasure { get; set; }
    }

    public class ConfigFormatterFish : BindingTarget
    {
        [JsonProperty("bite")]
        public bool Bite { get; set; } = true;

        [JsonProperty("biteType")]
        public bool BiteType { get; set; } = true;
    }

    public class ConfigFormatterFate : BindingTarget
    {
        [JsonProperty("name")]
        public bool Name { get; set; } = true;
        [JsonProperty("level")]
        public bool Level { get; set; } = false;
        [JsonProperty("mute-while-loading")]
        public bool MuteWhileLoading { get; set; } = false;
    }

    public class ConfigFormatterCriticalEngagement : BindingTarget
    {
        [JsonProperty("name")]
        public bool Name { get; set; } = true;
    }

    public class ConfigFormatterTreasure : BindingTarget
    {
        [JsonProperty("result")]
        public bool Result { get; set; } = true;
    }

    public class ConfigFormatterInstance : BindingTarget
    {
        [JsonProperty("name")]
        public bool Name { get; set; } = true;
        [JsonProperty("level")]
        public bool Level { get; set; }
        [JsonProperty("type")]
        public bool Type { get; set; }
    }

    public class ConfigFormatterZone : BindingTarget
    {
        [JsonProperty("name")]
        public bool Name { get; set; }
        [JsonProperty("instance")]
        public bool Instance { get; set; } = true;
    }

    public class ConfigLogger : BindingTarget
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
        [JsonProperty("compat")]
        public bool Compat { get; set; }
        [JsonProperty("debug")]
        public bool Debug { get; set; }
    }
}
