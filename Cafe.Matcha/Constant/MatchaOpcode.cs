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
        DirectorStart,
        EventPlay,
        Examine,
        FateInfo,
        InitZone,
        InventoryTransaction,
        ItemInfo,
        MarketBoardItemListing,
        MarketBoardItemListingCount,
        MarketBoardItemListingHistory,
        NpcSpawn,
        PlayerSetup,
        PlayerSpawn,
    }

    internal static class OpcodeStorage
    {
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x02c2, MatchaOpcode.ActorControl },
            { 0x0256, MatchaOpcode.ActorControlSelf },
            { 0x02ad, MatchaOpcode.CEDirector },
            { 0x03d0, MatchaOpcode.CompanyAirshipStatus },
            { 0x016d, MatchaOpcode.CompanySubmersibleStatus },
            { 0x038a, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * DirectorStart a.k.a. MiniCactpotInit
             */
            { 0x0306, MatchaOpcode.DirectorStart },
            { 0x0284, MatchaOpcode.EventPlay },
            { 0x022f, MatchaOpcode.Examine },
            { 0x0232, MatchaOpcode.FateInfo },
            { 0x01fe, MatchaOpcode.InitZone },
            { 0x031b, MatchaOpcode.InventoryTransaction },
            { 0x034d, MatchaOpcode.ItemInfo },
            { 0x0379, MatchaOpcode.MarketBoardItemListing },
            { 0x0174, MatchaOpcode.MarketBoardItemListingCount },
            { 0x03cd, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0269, MatchaOpcode.NpcSpawn },
            { 0x02bf, MatchaOpcode.PlayerSetup },
            { 0x0094, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x03d0, MatchaOpcode.ActorControl },
            { 0x00f1, MatchaOpcode.ActorControlSelf },
            { 0x039d, MatchaOpcode.CEDirector },
            { 0x013b, MatchaOpcode.CompanyAirshipStatus },
            { 0x016e, MatchaOpcode.CompanySubmersibleStatus },
            { 0x02dd, MatchaOpcode.ContentFinderNotifyPop },
            { 0x00f2, MatchaOpcode.DirectorStart },
            { 0x022f, MatchaOpcode.EventPlay },
            { 0x00ec, MatchaOpcode.Examine },
            { 0x032a, MatchaOpcode.FateInfo },
            { 0x00ce, MatchaOpcode.InitZone },
            { 0x00a7, MatchaOpcode.InventoryTransaction },
            { 0x0399, MatchaOpcode.ItemInfo },
            { 0x0102, MatchaOpcode.MarketBoardItemListing },
            { 0x02e6, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0231, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x01c3, MatchaOpcode.NpcSpawn },
            { 0x01af, MatchaOpcode.PlayerSetup },
            { 0x008f, MatchaOpcode.PlayerSpawn },
        };
    }
}
