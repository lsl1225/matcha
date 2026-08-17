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
         * ResumeEventScene32 -> MiniCactpotInit (GROUP_EventResume)
         */
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0096, MatchaOpcode.ActorControl },
            { 0x037C, MatchaOpcode.ActorControlSelf },
            { 0x027D, MatchaOpcode.CEDirector },
            { 0x012E, MatchaOpcode.CompanyAirshipStatus },
            { 0x03AF, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0197, MatchaOpcode.ContentFinderNotifyPop },
            { 0x02C7, MatchaOpcode.ResumeEventScene32 },
            { 0x01A5, MatchaOpcode.EventPlay },
            { 0x0278, MatchaOpcode.EventStart },
            { 0x0097, MatchaOpcode.Examine },
            { 0x037D, MatchaOpcode.FateInfo },
            { 0x0161, MatchaOpcode.InitZone },
            { 0x0104, MatchaOpcode.InventoryTransaction },
            { 0x0204, MatchaOpcode.ItemInfo },
            { 0x0190, MatchaOpcode.MarketBoardItemListing },
            { 0x022F, MatchaOpcode.MarketBoardItemListingCount },
            { 0x017B, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x835B, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x00E9, MatchaOpcode.NpcSpawn },
            { 0x00A6, MatchaOpcode.PlayerSetup },
            { 0x032D, MatchaOpcode.PlayerSpawn },
            { 0x01A2, MatchaOpcode.SubmarineStatusList },
            { 0x0388, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x01DA, MatchaOpcode.ActorControl },
            { 0x035D, MatchaOpcode.ActorControlSelf },
            { 0x0092, MatchaOpcode.CEDirector },
            { 0x022F, MatchaOpcode.CompanyAirshipStatus },
            { 0x02B1, MatchaOpcode.CompanySubmersibleStatus },
            { 0x00B8, MatchaOpcode.ContentFinderNotifyPop },
            { 0x012D, MatchaOpcode.ResumeEventScene32 },
            { 0x02DD, MatchaOpcode.EventPlay },
            { 0x016D, MatchaOpcode.EventStart },
            { 0x02BB, MatchaOpcode.Examine },
            { 0x00E9, MatchaOpcode.FateInfo },
            { 0x028D, MatchaOpcode.InitZone },
            { 0x01C8, MatchaOpcode.InventoryTransaction },
            { 0x013A, MatchaOpcode.ItemInfo },
            { 0x0356, MatchaOpcode.MarketBoardItemListing },
            { 0x0256, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0127, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8070, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x006F, MatchaOpcode.NpcSpawn },
            { 0x03DD, MatchaOpcode.PlayerSetup },
            { 0x0398, MatchaOpcode.PlayerSpawn },
            { 0x01EF, MatchaOpcode.SubmarineStatusList },
            { 0x02E6, MatchaOpcode.WorldVisitQueue },
        };
    }
}
