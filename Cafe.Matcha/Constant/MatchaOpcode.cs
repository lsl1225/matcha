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
            { 0x38E, MatchaOpcode.ActorControl },
            { 0x18C, MatchaOpcode.ActorControlSelf },
            { 0x26A, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x30E, MatchaOpcode.CompanyAirshipStatus },
            { 0x114, MatchaOpcode.CompanySubmersibleStatus },
            { 0x312, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0xA7, MatchaOpcode.ResumeEventScene32 }, // unknown
            { 0x6C, MatchaOpcode.EventPlay }, // unknown
            { 0x1B4, MatchaOpcode.EventStart },
            { 0x2FD, MatchaOpcode.Examine },
            { 0x2E1, MatchaOpcode.FateInfo },
            { 0x311, MatchaOpcode.InitZone },
            { 0x327, MatchaOpcode.InventoryTransaction },
            { 0x1D7, MatchaOpcode.ItemInfo }, // unknown
            { 0xB6, MatchaOpcode.MarketBoardItemListing },
            { 0x3CB, MatchaOpcode.MarketBoardItemListingCount },
            { 0x302, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x182, MatchaOpcode.MarketBoardRequestItemListingInfo }, // unknown
            { 0x100, MatchaOpcode.NpcSpawn },
            { 0x6B, MatchaOpcode.PlayerSetup },
            { 0x1AB, MatchaOpcode.PlayerSpawn },
            { 0x1B7, MatchaOpcode.WorldVisitQueue }, // unknown
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
