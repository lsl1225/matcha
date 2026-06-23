// Copyright (c) FFCafe. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.

namespace Cafe.Matcha.Constant
{
    using System.Collections.Generic;

    internal enum MatchaOpcode
    {
        ActorControl,
        ActorControlSelf,
        CEDirector,
        CompanyAirshipStatus,
        CompanySubmersibleStatus,
        ContentFinderNotifyPop,
        ResumeEventScene32,
        EventPlay,
        EventStart,
        Examine,
        FateInfo,
        InitZone,
        InventoryTransaction,
        ItemInfo,
        MarketBoardItemListing,
        MarketBoardItemListingCount,
        MarketBoardItemListingHistory,
        MarketBoardRequestItemListingInfo,
        NpcSpawn,
        PlayerSetup,
        PlayerSpawn,
        SubmarineStatusList,
        WorldVisitQueue,
    }

    internal static class OpcodeStorage
    {
        /*
         * CompanyAirshipStatus -> AirshipTimers
         * CompanySubmersibleStatus -> SubmarineTimers
         * ResumeEventScene32 -> MiniCactpotInit
         */
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x027F, MatchaOpcode.ActorControl },
            { 0x0362, MatchaOpcode.ActorControlSelf },
            { 0x013B, MatchaOpcode.CEDirector },
            { 0x027E, MatchaOpcode.CompanyAirshipStatus },
            { 0x00CD, MatchaOpcode.CompanySubmersibleStatus },
            { 0x00FD, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0065, MatchaOpcode.ResumeEventScene32 },
            { 0x029B, MatchaOpcode.EventPlay },
            { 0x0356, MatchaOpcode.EventStart },
            { 0x01BB, MatchaOpcode.Examine },
            { 0x0277, MatchaOpcode.FateInfo },
            { 0x008B, MatchaOpcode.InitZone },
            { 0x034F, MatchaOpcode.InventoryTransaction },
            { 0x0314, MatchaOpcode.ItemInfo },
            { 0x02E0, MatchaOpcode.MarketBoardItemListing },
            { 0x0184, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0230, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x820A, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0113, MatchaOpcode.NpcSpawn },
            { 0x03A8, MatchaOpcode.PlayerSetup },
            { 0x03B4, MatchaOpcode.PlayerSpawn },
            { 0x0370, MatchaOpcode.SubmarineStatusList },
            { 0x009E, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x027F, MatchaOpcode.ActorControl },
            { 0x0362, MatchaOpcode.ActorControlSelf },
            { 0x013B, MatchaOpcode.CEDirector },
            { 0x027E, MatchaOpcode.CompanyAirshipStatus },
            { 0x00CD, MatchaOpcode.CompanySubmersibleStatus },
            { 0x00FD, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0065, MatchaOpcode.ResumeEventScene32 },
            { 0x029B, MatchaOpcode.EventPlay },
            { 0x0356, MatchaOpcode.EventStart },
            { 0x01BB, MatchaOpcode.Examine },
            { 0x0277, MatchaOpcode.FateInfo },
            { 0x008B, MatchaOpcode.InitZone },
            { 0x034F, MatchaOpcode.InventoryTransaction },
            { 0x0314, MatchaOpcode.ItemInfo },
            { 0x02E0, MatchaOpcode.MarketBoardItemListing },
            { 0x0184, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0230, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x820A, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0113, MatchaOpcode.NpcSpawn },
            { 0x03A8, MatchaOpcode.PlayerSetup },
            { 0x03B4, MatchaOpcode.PlayerSpawn },
            { 0x0370, MatchaOpcode.SubmarineStatusList },
            { 0x009E, MatchaOpcode.WorldVisitQueue },
        };
    }
}
