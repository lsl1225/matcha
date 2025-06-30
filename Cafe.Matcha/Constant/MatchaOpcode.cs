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
            { 0x0344, MatchaOpcode.ActorControl },
            { 0x0393, MatchaOpcode.ActorControlSelf },
            { 0x02d4, MatchaOpcode.CEDirector },
            { 0x01d7, MatchaOpcode.CompanyAirshipStatus },
            { 0x03d7, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0181, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0133, MatchaOpcode.ResumeEventScene32 },
            { 0x031f, MatchaOpcode.EventPlay },
            { 0x01f9, MatchaOpcode.EventStart },
            { 0x02f9, MatchaOpcode.Examine },
            { 0x032e, MatchaOpcode.FateInfo },
            { 0x012a, MatchaOpcode.InitZone },
            { 0x009a, MatchaOpcode.InventoryTransaction },
            { 0x030f, MatchaOpcode.ItemInfo },
            { 0x0085, MatchaOpcode.MarketBoardItemListing },
            { 0x01c8, MatchaOpcode.MarketBoardItemListingCount },
            { 0x00e7, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8069, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x014f, MatchaOpcode.NpcSpawn },
            { 0x00cd, MatchaOpcode.PlayerSetup },
            { 0x00dc, MatchaOpcode.PlayerSpawn },
            { 0x025d, MatchaOpcode.WorldVisitQueue },
        };
    }
}
