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
            { 0x26F, MatchaOpcode.ActorControl },
            { 0xB2, MatchaOpcode.ActorControlSelf },
            { 0x2BD, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0xCE, MatchaOpcode.CompanyAirshipStatus },
            { 0x1E9, MatchaOpcode.CompanySubmersibleStatus },
            { 0xA9, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x352, MatchaOpcode.ResumeEventScene32 },
            { 0x93, MatchaOpcode.EventPlay },
            { 0x262, MatchaOpcode.EventStart },
            { 0x372, MatchaOpcode.Examine },
            { 0x2CF, MatchaOpcode.FateInfo },
            { 0x27C, MatchaOpcode.InitZone },
            { 0x1F6, MatchaOpcode.InventoryTransaction },
            { 0xC3, MatchaOpcode.ItemInfo },
            { 0x99, MatchaOpcode.MarketBoardItemListing },
            { 0x1F2, MatchaOpcode.MarketBoardItemListingCount },
            { 0x1A1, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x320, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x35C, MatchaOpcode.NpcSpawn },
            { 0x3DE, MatchaOpcode.PlayerSetup },
            { 0x3A4, MatchaOpcode.PlayerSpawn },
            { 0x27B, MatchaOpcode.WorldVisitQueue },
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
