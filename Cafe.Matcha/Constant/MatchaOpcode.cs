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
            { 0x03a0, MatchaOpcode.ActorControl },
            { 0x0286, MatchaOpcode.ActorControlSelf },
            { 0x036e, MatchaOpcode.CEDirector },
            /* 
             * AirshipTimers & SubmarineTimers
             */
            { 0x03af, MatchaOpcode.CompanyAirshipStatus },
            { 0x02ef, MatchaOpcode.CompanySubmersibleStatus },
            { 0x02d6, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x0145, MatchaOpcode.DirectorStart },
            { 0x02d2, MatchaOpcode.EventPlay },
            { 0x0075, MatchaOpcode.Examine },
            { 0x018c, MatchaOpcode.FateInfo },
            { 0x02d0, MatchaOpcode.InitZone },
            { 0x02df, MatchaOpcode.InventoryTransaction },
            { 0x0103, MatchaOpcode.ItemInfo },
            { 0x0122, MatchaOpcode.MarketBoardItemListing },
            { 0x0097, MatchaOpcode.MarketBoardItemListingCount },
            { 0x03e3, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x011c, MatchaOpcode.NpcSpawn },
            { 0x0263, MatchaOpcode.PlayerSetup },
            { 0x0251, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0342, MatchaOpcode.ActorControl },
            { 0x03d5, MatchaOpcode.ActorControlSelf },
            { 0x03ce, MatchaOpcode.CEDirector },
            { 0x02a7, MatchaOpcode.CompanyAirshipStatus },
            { 0x0146, MatchaOpcode.CompanySubmersibleStatus },
            { 0x00ef, MatchaOpcode.ContentFinderNotifyPop },
            { 0x01e3, MatchaOpcode.DirectorStart },
            { 0x00ae, MatchaOpcode.EventPlay },
            { 0x014e, MatchaOpcode.Examine },
            { 0x01ac, MatchaOpcode.FateInfo },
            { 0x00bc, MatchaOpcode.InitZone },
            { 0x0087, MatchaOpcode.InventoryTransaction },
            { 0x0265, MatchaOpcode.ItemInfo },
            { 0x0345, MatchaOpcode.MarketBoardItemListing },
            { 0x0069, MatchaOpcode.MarketBoardItemListingCount },
            { 0x01fd, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x01ca, MatchaOpcode.NpcSpawn },
            { 0x0322, MatchaOpcode.PlayerSetup },
            { 0x0391, MatchaOpcode.PlayerSpawn },
        };
    }
}
