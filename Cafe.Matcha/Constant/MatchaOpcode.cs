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
            { 0x0202, MatchaOpcode.ActorControl },
            { 0x015B, MatchaOpcode.ActorControlSelf },
            { 0x01AB, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x00B5, MatchaOpcode.CompanyAirshipStatus },
            { 0x00C9, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0124, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x039a, MatchaOpcode.ResumeEventScene32 }, // unk
            { 0x034E, MatchaOpcode.EventPlay },
            { 0x019D, MatchaOpcode.EventStart },
            { 0x02D5, MatchaOpcode.Examine },
            { 0x00C0, MatchaOpcode.FateInfo },
            { 0x02D0, MatchaOpcode.InitZone },
            { 0x0192, MatchaOpcode.InventoryTransaction }, // unk
            { 0x02a4, MatchaOpcode.ItemInfo }, // unk
            { 0x021A, MatchaOpcode.MarketBoardItemListing },
            { 0x00E6, MatchaOpcode.MarketBoardItemListingCount },
            { 0x03A9, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0151, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x018D, MatchaOpcode.NpcSpawn },
            { 0x0220, MatchaOpcode.PlayerSetup },
            { 0x01B3, MatchaOpcode.PlayerSpawn },
            { 0x02F0, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0099, MatchaOpcode.ActorControl },
            { 0x025e, MatchaOpcode.ActorControlSelf },
            { 0x014e, MatchaOpcode.CEDirector },
            { 0x019a, MatchaOpcode.CompanyAirshipStatus },
            { 0x02dd, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0246, MatchaOpcode.ContentFinderNotifyPop },
            { 0x020c, MatchaOpcode.ResumeEventScene32 },
            { 0x0380, MatchaOpcode.EventPlay },
            { 0x02b9, MatchaOpcode.EventStart },
            { 0x0097, MatchaOpcode.Examine },
            { 0x02a3, MatchaOpcode.FateInfo },
            { 0x00ce, MatchaOpcode.InitZone },
            { 0x01d6, MatchaOpcode.InventoryTransaction },
            { 0x032d, MatchaOpcode.ItemInfo },
            { 0x020e, MatchaOpcode.MarketBoardItemListing },
            { 0x01be, MatchaOpcode.MarketBoardItemListingCount },
            { 0x03ad, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x80ef, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x01f6, MatchaOpcode.NpcSpawn },
            { 0x00d8, MatchaOpcode.PlayerSetup },
            { 0x0222, MatchaOpcode.PlayerSpawn },
            { 0x0334, MatchaOpcode.WorldVisitQueue },
        };
    }
}
