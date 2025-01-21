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
    }

    internal static class OpcodeStorage
    {
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x20B, MatchaOpcode.ActorControl },
            { 0x2D7, MatchaOpcode.ActorControlSelf },
            { 0x118, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x140, MatchaOpcode.CompanyAirshipStatus },
            { 0x3AF, MatchaOpcode.CompanySubmersibleStatus },
            { 0x27D, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x0280, MatchaOpcode.ResumeEventScene32 },
            { 0x024F, MatchaOpcode.EventPlay },
            { 0x385, MatchaOpcode.Examine },
            { 0x142, MatchaOpcode.FateInfo },
            { 0x33E, MatchaOpcode.InitZone },
            { 0x11E, MatchaOpcode.InventoryTransaction },
            { 0x00FD, MatchaOpcode.ItemInfo },
            { 0x2BE, MatchaOpcode.MarketBoardItemListing },
            { 0x271, MatchaOpcode.MarketBoardItemListingCount },
            { 0x35D, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x023C, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x2D6, MatchaOpcode.NpcSpawn },
            { 0x25D, MatchaOpcode.PlayerSetup },
            { 0x2AC, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0084, MatchaOpcode.ActorControl },
            { 0x007b, MatchaOpcode.ActorControlSelf },
            { 0x01b5, MatchaOpcode.CEDirector },
            { 0x0069, MatchaOpcode.CompanyAirshipStatus },
            { 0x02e4, MatchaOpcode.CompanySubmersibleStatus },
            { 0x007d, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0159, MatchaOpcode.ResumeEventScene32 },
            { 0x027c, MatchaOpcode.EventPlay },
            { 0x0096, MatchaOpcode.Examine },
            { 0x0242, MatchaOpcode.FateInfo },
            { 0x0317, MatchaOpcode.InitZone },
            { 0x0073, MatchaOpcode.InventoryTransaction },
            { 0x01d6, MatchaOpcode.ItemInfo },
            { 0x031c, MatchaOpcode.MarketBoardItemListing },
            { 0x027f, MatchaOpcode.MarketBoardItemListingCount },
            { 0x00df, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8380, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x00a4, MatchaOpcode.NpcSpawn },
            { 0x0207, MatchaOpcode.PlayerSetup },
            { 0x0125, MatchaOpcode.PlayerSpawn },
        };
    }
}
