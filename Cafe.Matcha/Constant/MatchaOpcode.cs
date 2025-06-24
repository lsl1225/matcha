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
            { 0x3E7, MatchaOpcode.ActorControl },
            { 0x117, MatchaOpcode.ActorControlSelf },
            { 0x277, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0xC7, MatchaOpcode.CompanyAirshipStatus },
            { 0x2F9, MatchaOpcode.CompanySubmersibleStatus },
            { 0xA5, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x3A2, MatchaOpcode.ResumeEventScene32 },
            { 0x1E0, MatchaOpcode.EventPlay },
            { 0x290, MatchaOpcode.EventStart },
            { 0x364, MatchaOpcode.Examine },
            { 0x3E1, MatchaOpcode.FateInfo },
            { 0x37E, MatchaOpcode.InitZone },
            { 0x115, MatchaOpcode.InventoryTransaction },
            { 0x38E, MatchaOpcode.ItemInfo },
            { 0x167, MatchaOpcode.MarketBoardItemListing },
            { 0x223, MatchaOpcode.MarketBoardItemListingCount },
            { 0xA3, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x343, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x38C, MatchaOpcode.NpcSpawn },
            { 0x309, MatchaOpcode.PlayerSetup },
            { 0x32A, MatchaOpcode.PlayerSpawn },
            { 0x355, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x018e, MatchaOpcode.ActorControl },
            { 0x02df, MatchaOpcode.ActorControlSelf },
            { 0x0176, MatchaOpcode.CEDirector },
            { 0x0240, MatchaOpcode.CompanyAirshipStatus },
            { 0x01c5, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0114, MatchaOpcode.ContentFinderNotifyPop },
            { 0x03e1, MatchaOpcode.ResumeEventScene32 },
            { 0x013e, MatchaOpcode.EventPlay },
            { 0x0268, MatchaOpcode.EventStart },
            { 0x0259, MatchaOpcode.Examine },
            { 0x02c1, MatchaOpcode.FateInfo },
            { 0x010f, MatchaOpcode.InitZone },
            { 0x01c3, MatchaOpcode.InventoryTransaction },
            { 0x00c4, MatchaOpcode.ItemInfo },
            { 0x0313, MatchaOpcode.MarketBoardItemListing },
            { 0x011b, MatchaOpcode.MarketBoardItemListingCount },
            { 0x016a, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x81ff, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x01aa, MatchaOpcode.NpcSpawn },
            { 0x033b, MatchaOpcode.PlayerSetup },
            { 0x02c6, MatchaOpcode.PlayerSpawn },
            { 0x0391, MatchaOpcode.WorldVisitQueue },
        };
    }
}
