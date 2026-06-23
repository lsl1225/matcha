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
            { 0x019F, MatchaOpcode.ActorControl },
            { 0x0164, MatchaOpcode.ActorControlSelf },
            { 0x0377, MatchaOpcode.CEDirector },
            { 0x03C5, MatchaOpcode.CompanyAirshipStatus },
            { 0x0066, MatchaOpcode.CompanySubmersibleStatus },
            { 0x024B, MatchaOpcode.ContentFinderNotifyPop },
            { 0x03A6, MatchaOpcode.ResumeEventScene32 },
            { 0x013E, MatchaOpcode.EventPlay },
            { 0x0202, MatchaOpcode.EventStart },
            { 0x032C, MatchaOpcode.Examine },
            { 0x022E, MatchaOpcode.FateInfo },
            { 0x0337, MatchaOpcode.InitZone },
            { 0x02A3, MatchaOpcode.InventoryTransaction },
            { 0x017C, MatchaOpcode.ItemInfo },
            { 0x00ED, MatchaOpcode.MarketBoardItemListing },
            { 0x0227, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0353, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8329, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0378, MatchaOpcode.NpcSpawn },
            { 0x0110, MatchaOpcode.PlayerSetup },
            { 0x02E0, MatchaOpcode.PlayerSpawn },
            { 0x035A, MatchaOpcode.SubmarineStatusList },
            { 0x0329, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x019F, MatchaOpcode.ActorControl },
            { 0x0164, MatchaOpcode.ActorControlSelf },
            { 0x0377, MatchaOpcode.CEDirector },
            { 0x03C5, MatchaOpcode.CompanyAirshipStatus },
            { 0x0066, MatchaOpcode.CompanySubmersibleStatus },
            { 0x024B, MatchaOpcode.ContentFinderNotifyPop },
            { 0x03A6, MatchaOpcode.ResumeEventScene32 },
            { 0x013E, MatchaOpcode.EventPlay },
            { 0x0202, MatchaOpcode.EventStart },
            { 0x032C, MatchaOpcode.Examine },
            { 0x022E, MatchaOpcode.FateInfo },
            { 0x0337, MatchaOpcode.InitZone },
            { 0x02A3, MatchaOpcode.InventoryTransaction },
            { 0x017C, MatchaOpcode.ItemInfo },
            { 0x00ED, MatchaOpcode.MarketBoardItemListing },
            { 0x0227, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0353, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8329, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0378, MatchaOpcode.NpcSpawn },
            { 0x0110, MatchaOpcode.PlayerSetup },
            { 0x02E0, MatchaOpcode.PlayerSpawn },
            { 0x035A, MatchaOpcode.SubmarineStatusList },
            { 0x0329, MatchaOpcode.WorldVisitQueue },
        };
    }
}
