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
            { 0xA1, MatchaOpcode.ActorControl },
            { 0x3BD, MatchaOpcode.ActorControlSelf },
            { 0x2B0, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x2EE, MatchaOpcode.CompanyAirshipStatus },
            { 0x1AD, MatchaOpcode.CompanySubmersibleStatus },
            { 0x387, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x20c, MatchaOpcode.ResumeEventScene32 },
            { 0x83, MatchaOpcode.EventPlay },
            { 0x107, MatchaOpcode.EventStart },
            { 0x241, MatchaOpcode.Examine },
            { 0xCE, MatchaOpcode.FateInfo },
            { 0x3A3, MatchaOpcode.InitZone },
            { 0xEB, MatchaOpcode.InventoryTransaction },
            { 0xf6, MatchaOpcode.ItemInfo },
            { 0x27D, MatchaOpcode.MarketBoardItemListing },
            { 0x11E, MatchaOpcode.MarketBoardItemListingCount },
            { 0x3C1, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x95, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x2EA, MatchaOpcode.NpcSpawn },
            { 0x26F, MatchaOpcode.PlayerSetup },
            { 0xE3, MatchaOpcode.PlayerSpawn },
            { 0x87, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x02e1, MatchaOpcode.ActorControl },
            { 0x01d2, MatchaOpcode.ActorControlSelf },
            { 0x026d, MatchaOpcode.CEDirector },
            { 0x01a3, MatchaOpcode.CompanyAirshipStatus },
            { 0x02fb, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0217, MatchaOpcode.ContentFinderNotifyPop },
            { 0x02bc, MatchaOpcode.ResumeEventScene32 },
            { 0x01fb, MatchaOpcode.EventPlay },
            { 0x0072, MatchaOpcode.EventStart },
            { 0x02fd, MatchaOpcode.Examine },
            { 0x00ab, MatchaOpcode.FateInfo },
            { 0x0148, MatchaOpcode.InitZone },
            { 0x02a7, MatchaOpcode.InventoryTransaction },
            { 0x0279, MatchaOpcode.ItemInfo },
            { 0x0128, MatchaOpcode.MarketBoardItemListing },
            { 0x0248, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0190, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x810a, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x00d8, MatchaOpcode.NpcSpawn },
            { 0x0299, MatchaOpcode.PlayerSetup },
            { 0x0107, MatchaOpcode.PlayerSpawn },
            { 0x039a, MatchaOpcode.WorldVisitQueue },
        };
    }
}
