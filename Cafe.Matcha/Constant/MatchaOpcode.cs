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
            { 0x1C5, MatchaOpcode.ActorControl },
            { 0x18B, MatchaOpcode.ActorControlSelf },
            { 0x16F, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x97, MatchaOpcode.CompanyAirshipStatus },
            { 0x2BA, MatchaOpcode.CompanySubmersibleStatus },
            { 0x13F, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x00E0, MatchaOpcode.ResumeEventScene32 }, // unknown
            { 0x03CA, MatchaOpcode.EventPlay },
            { 0x2CD, MatchaOpcode.Examine },
            { 0xE8, MatchaOpcode.FateInfo },
            { 0x247, MatchaOpcode.InitZone },
            { 0x28B, MatchaOpcode.InventoryTransaction },
            { 0x0310, MatchaOpcode.ItemInfo },
            { 0x311, MatchaOpcode.MarketBoardItemListing },
            { 0x1EC, MatchaOpcode.MarketBoardItemListingCount },
            { 0x1A2, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x024F, MatchaOpcode.MarketBoardRequestItemListingInfo }, // unknown
            { 0x3A3, MatchaOpcode.NpcSpawn },
            { 0x36D, MatchaOpcode.PlayerSetup },
            { 0x12A, MatchaOpcode.PlayerSpawn },
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
