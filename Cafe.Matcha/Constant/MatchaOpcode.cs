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
            { 0x03A3, MatchaOpcode.ActorControl },
            { 0x008A, MatchaOpcode.ActorControlSelf },
            { 0x00BA, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x01FF, MatchaOpcode.CompanyAirshipStatus },
            { 0x0314, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0289, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x0259, MatchaOpcode.ResumeEventScene32 }, // unknown
            { 0x02F9, MatchaOpcode.EventPlay },
            { 0x006F, MatchaOpcode.Examine },
            { 0x011E, MatchaOpcode.FateInfo },
            { 0x036D, MatchaOpcode.InitZone },
            { 0x00AF, MatchaOpcode.InventoryTransaction },
            { 0x038D, MatchaOpcode.ItemInfo },
            { 0x02A1, MatchaOpcode.MarketBoardItemListing },
            { 0x034C, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0294, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x00B0, MatchaOpcode.MarketBoardRequestItemListingInfo }, // unknown
            { 0x037A, MatchaOpcode.NpcSpawn },
            { 0x01F0, MatchaOpcode.PlayerSetup },
            { 0x0171, MatchaOpcode.PlayerSpawn },
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
