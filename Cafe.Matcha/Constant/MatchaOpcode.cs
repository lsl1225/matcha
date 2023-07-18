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
            { 0x0088, MatchaOpcode.ActorControl },
            { 0x02F7, MatchaOpcode.ActorControlSelf },
            { 0x0175, MatchaOpcode.CEDirector },
            /* 
             * AirshipTimers & SubmarineTimers
             */
            { 0x0075, MatchaOpcode.CompanyAirshipStatus },
            { 0x02C1, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0126, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x033F, MatchaOpcode.DirectorStart }, // unknown
            { 0x014A, MatchaOpcode.EventPlay },
            { 0x00ED, MatchaOpcode.Examine },
            { 0x020D, MatchaOpcode.FateInfo },
            { 0x00D8, MatchaOpcode.InitZone },
            { 0x01D2, MatchaOpcode.InventoryTransaction },
            { 0x0333, MatchaOpcode.ItemInfo },
            { 0x00EB, MatchaOpcode.MarketBoardItemListing },
            { 0x026B, MatchaOpcode.MarketBoardItemListingCount },
            { 0x03CB, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0179, MatchaOpcode.NpcSpawn },
            { 0x02C5, MatchaOpcode.PlayerSetup },
            { 0x02D3, MatchaOpcode.PlayerSpawn },
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
