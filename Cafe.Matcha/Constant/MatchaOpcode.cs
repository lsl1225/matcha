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
            { 0x352, MatchaOpcode.ResumeEventScene32 }, // unk
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
            { 0x320, MatchaOpcode.MarketBoardRequestItemListingInfo }, // unk
            { 0x25E, MatchaOpcode.NpcSpawn },
            { 0x137, MatchaOpcode.PlayerSetup },
            { 0x374, MatchaOpcode.PlayerSpawn },
            { 0x27B, MatchaOpcode.WorldVisitQueue }, // unk
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x023b, MatchaOpcode.ActorControl },
            { 0x00f3, MatchaOpcode.ActorControlSelf },
            { 0x00c1, MatchaOpcode.CEDirector },
            { 0x0390, MatchaOpcode.CompanyAirshipStatus },
            { 0x0107, MatchaOpcode.CompanySubmersibleStatus },
            { 0x011f, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0353, MatchaOpcode.ResumeEventScene32 },
            { 0x0146, MatchaOpcode.EventPlay },
            { 0x036f, MatchaOpcode.EventStart },
            { 0x0187, MatchaOpcode.Examine },
            { 0x0360, MatchaOpcode.FateInfo },
            { 0x0332, MatchaOpcode.InitZone },
            { 0x0080, MatchaOpcode.InventoryTransaction },
            { 0x03ce, MatchaOpcode.ItemInfo },
            { 0x02f5, MatchaOpcode.MarketBoardItemListing },
            { 0x020e, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0143, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x80ed, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x017e, MatchaOpcode.NpcSpawn },
            { 0x008c, MatchaOpcode.PlayerSetup },
            { 0x02a9, MatchaOpcode.PlayerSpawn },
            { 0x03ad, MatchaOpcode.WorldVisitQueue },
        };
    }
}
