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
            { 0x0243, MatchaOpcode.ActorControl },
            { 0x0196, MatchaOpcode.ActorControlSelf },
            { 0x01B0, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x020C, MatchaOpcode.CompanyAirshipStatus },
            { 0x0354, MatchaOpcode.CompanySubmersibleStatus },
            { 0x010C, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x024B, MatchaOpcode.DirectorStart },
            { 0x036E, MatchaOpcode.EventPlay },
            { 0x03BC, MatchaOpcode.Examine },
            { 0x0165, MatchaOpcode.FateInfo },
            { 0x038F, MatchaOpcode.InitZone },
            { 0x011D, MatchaOpcode.InventoryTransaction },
            { 0x015B, MatchaOpcode.ItemInfo },
            { 0x0233, MatchaOpcode.MarketBoardItemListing },
            { 0x0168, MatchaOpcode.MarketBoardItemListingCount },
            { 0x039F, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0379, MatchaOpcode.NpcSpawn },
            { 0x006D, MatchaOpcode.PlayerSetup },
            { 0x03E2, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x007a, MatchaOpcode.ActorControl },
            { 0x0139, MatchaOpcode.ActorControlSelf },
            { 0x034f, MatchaOpcode.CEDirector },
            { 0x03a5, MatchaOpcode.CompanyAirshipStatus },
            { 0x0274, MatchaOpcode.CompanySubmersibleStatus },
            { 0x00ec, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0377, MatchaOpcode.DirectorStart },
            { 0x00a0, MatchaOpcode.EventPlay },
            { 0x00f6, MatchaOpcode.Examine },
            { 0x020e, MatchaOpcode.FateInfo },
            { 0x024d, MatchaOpcode.InitZone },
            { 0x0111, MatchaOpcode.InventoryTransaction },
            { 0x0214, MatchaOpcode.ItemInfo },
            { 0x0188, MatchaOpcode.MarketBoardItemListing },
            { 0x02ba, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02e4, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x00d8, MatchaOpcode.NpcSpawn },
            { 0x028d, MatchaOpcode.PlayerSetup },
            { 0x00c0, MatchaOpcode.PlayerSpawn },
        };
    }
}
