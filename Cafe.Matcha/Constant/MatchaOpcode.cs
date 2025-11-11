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
            { 0x113, MatchaOpcode.ActorControl },
            { 0x254, MatchaOpcode.ActorControlSelf },
            { 0x39D, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x2F4, MatchaOpcode.CompanyAirshipStatus },
            { 0x229, MatchaOpcode.CompanySubmersibleStatus },
            { 0xFC, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0xF4, MatchaOpcode.ResumeEventScene32 },
            { 0x1B1, MatchaOpcode.EventPlay },
            { 0x343, MatchaOpcode.EventStart },
            { 0x13A, MatchaOpcode.Examine },
            { 0x1C9, MatchaOpcode.FateInfo },
            { 0x2B1, MatchaOpcode.InitZone },
            { 0x117, MatchaOpcode.InventoryTransaction },
            { 0x1E7, MatchaOpcode.ItemInfo },
            { 0x241, MatchaOpcode.MarketBoardItemListing },
            { 0x104, MatchaOpcode.MarketBoardItemListingCount },
            { 0x1FB, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x1F3, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x2C9, MatchaOpcode.NpcSpawn },
            { 0x39A, MatchaOpcode.PlayerSetup },
            { 0x270, MatchaOpcode.PlayerSpawn },
            { 0x15F, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0167, MatchaOpcode.ActorControl },
            { 0x0110, MatchaOpcode.ActorControlSelf },
            { 0x0364, MatchaOpcode.CEDirector },
            { 0x02f4, MatchaOpcode.CompanyAirshipStatus },
            { 0x00e5, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0080, MatchaOpcode.ContentFinderNotifyPop },
            { 0x024e, MatchaOpcode.ResumeEventScene32 },
            { 0x03b5, MatchaOpcode.EventPlay },
            { 0x0235, MatchaOpcode.EventStart },
            { 0x0340, MatchaOpcode.Examine },
            { 0x02e5, MatchaOpcode.FateInfo },
            { 0x0362, MatchaOpcode.InitZone },
            { 0x01a0, MatchaOpcode.InventoryTransaction },
            { 0x00b7, MatchaOpcode.ItemInfo },
            { 0x02c1, MatchaOpcode.MarketBoardItemListing },
            { 0x013f, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02ed, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8308, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x00fc, MatchaOpcode.NpcSpawn },
            { 0x0300, MatchaOpcode.PlayerSetup },
            { 0x03e7, MatchaOpcode.PlayerSpawn },
            { 0x03af, MatchaOpcode.WorldVisitQueue },
        };
    }
}
