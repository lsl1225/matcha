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
        WorldVisitQueue,
    }

    internal static class OpcodeStorage
    {
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x34A, MatchaOpcode.ActorControl },
            { 0x1CD, MatchaOpcode.ActorControlSelf },
            { 0x2B4, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x3E1, MatchaOpcode.CompanyAirshipStatus },
            { 0x283, MatchaOpcode.CompanySubmersibleStatus },
            { 0x81, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x35B, MatchaOpcode.ResumeEventScene32 }, // unknown
            { 0x6C, MatchaOpcode.EventPlay },
            { 0xA5, MatchaOpcode.EventStart },
            { 0x1AB, MatchaOpcode.Examine },
            { 0x387, MatchaOpcode.FateInfo },
            { 0x11F, MatchaOpcode.InitZone },
            { 0x38E, MatchaOpcode.InventoryTransaction },
            { 0x1D7, MatchaOpcode.ItemInfo },
            { 0x288, MatchaOpcode.MarketBoardItemListing },
            { 0x14B, MatchaOpcode.MarketBoardItemListingCount },
            { 0x2E7, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x182, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x329, MatchaOpcode.NpcSpawn },
            { 0x3C4, MatchaOpcode.PlayerSetup },
            { 0x2FC, MatchaOpcode.PlayerSpawn },
            { 0x1B7, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x02bf, MatchaOpcode.ActorControl },
            { 0x0119, MatchaOpcode.ActorControlSelf },
            { 0x036a, MatchaOpcode.CEDirector },
            { 0x0291, MatchaOpcode.CompanyAirshipStatus },
            { 0x01b4, MatchaOpcode.CompanySubmersibleStatus },
            { 0x01ad, MatchaOpcode.ContentFinderNotifyPop },
            { 0x01fe, MatchaOpcode.ResumeEventScene32 },
            { 0x008a, MatchaOpcode.EventPlay },
            { 0x01a7, MatchaOpcode.EventStart },
            { 0x02bd, MatchaOpcode.Examine },
            { 0x02b4, MatchaOpcode.FateInfo },
            { 0x0108, MatchaOpcode.InitZone },
            { 0x0162, MatchaOpcode.InventoryTransaction },
            { 0x03a9, MatchaOpcode.ItemInfo },
            { 0x0207, MatchaOpcode.MarketBoardItemListing },
            { 0x026e, MatchaOpcode.MarketBoardItemListingCount },
            { 0x010e, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x81bf, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x03bb, MatchaOpcode.NpcSpawn },
            { 0x0215, MatchaOpcode.PlayerSetup },
            { 0x01dd, MatchaOpcode.PlayerSpawn },
            { 0x0124, MatchaOpcode.WorldVisitQueue },
        };
    }
}
