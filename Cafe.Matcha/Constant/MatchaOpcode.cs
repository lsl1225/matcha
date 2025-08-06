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
            { 0x00e4, MatchaOpcode.ActorControl },
            { 0x0276, MatchaOpcode.ActorControlSelf },
            { 0x0112, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x0139, MatchaOpcode.CompanyAirshipStatus },
            { 0x03d1, MatchaOpcode.CompanySubmersibleStatus },
            { 0x01c4, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x02BF, MatchaOpcode.ResumeEventScene32 },
            { 0x0191, MatchaOpcode.EventPlay },
            { 0x0095, MatchaOpcode.EventStart },
            { 0x01f6, MatchaOpcode.Examine },
            { 0x15F, MatchaOpcode.FateInfo }, // unk
            { 0x016c, MatchaOpcode.InitZone },
            { 0x0222, MatchaOpcode.InventoryTransaction },
            { 0x0283, MatchaOpcode.ItemInfo },
            { 0x0381, MatchaOpcode.MarketBoardItemListing },
            { 0x0303, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02bc, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x34A, MatchaOpcode.MarketBoardRequestItemListingInfo }, // unk
            { 0x022d, MatchaOpcode.NpcSpawn },
            { 0x037d, MatchaOpcode.PlayerSetup },
            { 0x01d0, MatchaOpcode.PlayerSpawn },
            { 0x03b2, MatchaOpcode.WorldVisitQueue },
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
