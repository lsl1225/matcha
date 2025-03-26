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
            { 0x208, MatchaOpcode.ActorControl },
            { 0x16F, MatchaOpcode.ActorControlSelf },
            { 0xB6, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x38B, MatchaOpcode.CompanyAirshipStatus },
            { 0x240, MatchaOpcode.CompanySubmersibleStatus },
            { 0x22D, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x34F, MatchaOpcode.ResumeEventScene32 },
            { 0x3DF, MatchaOpcode.EventPlay },
            { 0x3BB, MatchaOpcode.EventStart },
            { 0x87, MatchaOpcode.Examine },
            { 0x2D6, MatchaOpcode.FateInfo },
            { 0x2BB, MatchaOpcode.InitZone },
            { 0xC1, MatchaOpcode.InventoryTransaction },
            { 0x352, MatchaOpcode.ItemInfo },
            { 0x1D1, MatchaOpcode.MarketBoardItemListing },
            { 0x9D, MatchaOpcode.MarketBoardItemListingCount },
            { 0x30E, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x210, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x13F, MatchaOpcode.NpcSpawn },
            { 0xDA, MatchaOpcode.PlayerSetup },
            { 0x331, MatchaOpcode.PlayerSpawn },
            { 0x2A7, MatchaOpcode.WorldVisitQueue },
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
