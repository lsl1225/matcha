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
            { 0x019D, MatchaOpcode.ActorControl },
            { 0x00A6, MatchaOpcode.ActorControlSelf },
            { 0x0122, MatchaOpcode.CEDirector },
            /* 
             * AirshipTimers & SubmarineTimers
             */
            { 0x03C5, MatchaOpcode.CompanyAirshipStatus },
            { 0x0372, MatchaOpcode.CompanySubmersibleStatus },
            { 0x021A, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x033F, MatchaOpcode.DirectorStart },
            { 0x036F, MatchaOpcode.EventPlay },
            { 0x0228, MatchaOpcode.Examine },
            { 0x028A, MatchaOpcode.FateInfo },
            { 0x01D5, MatchaOpcode.InitZone },
            { 0x0252, MatchaOpcode.InventoryTransaction },
            { 0x0388, MatchaOpcode.ItemInfo },
            { 0x0221, MatchaOpcode.MarketBoardItemListing },
            { 0x0067, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0069, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x00AC, MatchaOpcode.NpcSpawn },
            { 0x03E6, MatchaOpcode.PlayerSetup },
            { 0x01A7, MatchaOpcode.PlayerSpawn },
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
