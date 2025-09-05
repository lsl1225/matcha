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
            { 0x3D1, MatchaOpcode.ActorControl },
            { 0x120, MatchaOpcode.ActorControlSelf },
            { 0x327, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x23C, MatchaOpcode.CompanyAirshipStatus },
            { 0x2EC, MatchaOpcode.CompanySubmersibleStatus },
            { 0xC2, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x253, MatchaOpcode.ResumeEventScene32 },
            { 0x1ED, MatchaOpcode.EventPlay },
            { 0xFB, MatchaOpcode.EventStart },
            { 0x1AF, MatchaOpcode.Examine },
            { 0xEB, MatchaOpcode.FateInfo },
            { 0x309, MatchaOpcode.InitZone },
            { 0x156, MatchaOpcode.InventoryTransaction },
            { 0x1EF, MatchaOpcode.ItemInfo },
            { 0xD8, MatchaOpcode.MarketBoardItemListing },
            { 0x2C7, MatchaOpcode.MarketBoardItemListingCount },
            { 0x29B, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x1EA, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0xE0, MatchaOpcode.NpcSpawn },
            { 0x141, MatchaOpcode.PlayerSetup },
            { 0x21E, MatchaOpcode.PlayerSpawn },
            { 0x2F0, MatchaOpcode.WorldVisitQueue },
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
