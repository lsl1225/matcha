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
            { 0x00D4, MatchaOpcode.ActorControl },
            { 0x03C1, MatchaOpcode.ActorControlSelf },
            { 0x00F2, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x034F, MatchaOpcode.CompanyAirshipStatus },
            { 0x0198, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0069, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x038C, MatchaOpcode.DirectorStart }, // unknown
            { 0x02DB, MatchaOpcode.EventPlay },
            { 0x0200, MatchaOpcode.Examine },
            { 0x025B, MatchaOpcode.FateInfo },
            { 0x0071, MatchaOpcode.InitZone },
            { 0x03DB, MatchaOpcode.InventoryTransaction },
            { 0x03A4, MatchaOpcode.ItemInfo },
            { 0x01DB, MatchaOpcode.MarketBoardItemListing },
            { 0x0306, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02F4, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0091, MatchaOpcode.NpcSpawn },
            { 0x020E, MatchaOpcode.PlayerSetup },
            { 0x010E, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x02a5, MatchaOpcode.ActorControl },
            { 0x01a3, MatchaOpcode.ActorControlSelf },
            { 0x03e6, MatchaOpcode.CEDirector },
            { 0x00e1, MatchaOpcode.CompanyAirshipStatus },
            { 0x01e6, MatchaOpcode.CompanySubmersibleStatus },
            { 0x00ca, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0251, MatchaOpcode.DirectorStart },
            { 0x03ce, MatchaOpcode.EventPlay },
            { 0x0255, MatchaOpcode.Examine },
            { 0x02cf, MatchaOpcode.FateInfo },
            { 0x01e3, MatchaOpcode.InitZone },
            { 0x01fc, MatchaOpcode.InventoryTransaction },
            { 0x036b, MatchaOpcode.ItemInfo },
            { 0x03b0, MatchaOpcode.MarketBoardItemListing },
            { 0x00ef, MatchaOpcode.MarketBoardItemListingCount },
            { 0x03ac, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0366, MatchaOpcode.NpcSpawn },
            { 0x03a8, MatchaOpcode.PlayerSetup },
            { 0x00c8, MatchaOpcode.PlayerSpawn },
        };
    }
}
