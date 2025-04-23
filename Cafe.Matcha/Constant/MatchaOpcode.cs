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
            { 0x9C, MatchaOpcode.ActorControl },
            { 0x2E2, MatchaOpcode.ActorControlSelf },
            { 0x369, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x353, MatchaOpcode.CompanyAirshipStatus },
            { 0x2EA, MatchaOpcode.CompanySubmersibleStatus },
            { 0x159, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x38F, MatchaOpcode.ResumeEventScene32 },
            { 0x10D, MatchaOpcode.EventPlay },
            { 0x127, MatchaOpcode.EventStart },
            { 0xD0, MatchaOpcode.Examine },
            { 0x363, MatchaOpcode.FateInfo },
            { 0x316, MatchaOpcode.InitZone },
            { 0x104, MatchaOpcode.InventoryTransaction },
            { 0x194, MatchaOpcode.ItemInfo },
            { 0x18F, MatchaOpcode.MarketBoardItemListing },
            { 0x136, MatchaOpcode.MarketBoardItemListingCount },
            { 0x1E2, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x325, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x25E, MatchaOpcode.NpcSpawn },
            { 0x137, MatchaOpcode.PlayerSetup },
            { 0x374, MatchaOpcode.PlayerSpawn },
            { 0x2A9, MatchaOpcode.WorldVisitQueue },
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
