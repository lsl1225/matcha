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
            { 0x01DA, MatchaOpcode.CEDirector }, // unknown
            /* 
             * AirshipTimers & SubmarineTimers
             */
            { 0x03af, MatchaOpcode.CompanyAirshipStatus },
            { 0x02ef, MatchaOpcode.CompanySubmersibleStatus },
            { 0x02d6, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x03C6, MatchaOpcode.DirectorStart }, // unknown
            { 0x02d2, MatchaOpcode.EventPlay },
            { 0x0075, MatchaOpcode.Examine },
            { 0x01E8, MatchaOpcode.FateInfo }, // unknown
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
            { 0x020b, MatchaOpcode.ActorControl },
            { 0x0139, MatchaOpcode.ActorControlSelf },
            { 0x0239, MatchaOpcode.CEDirector },
            { 0x00b1, MatchaOpcode.CompanyAirshipStatus },
            { 0x0177, MatchaOpcode.CompanySubmersibleStatus },
            { 0x019d, MatchaOpcode.ContentFinderNotifyPop },
            { 0x035c, MatchaOpcode.DirectorStart },
            { 0x0082, MatchaOpcode.EventPlay },
            { 0x0123, MatchaOpcode.Examine },
            { 0x017c, MatchaOpcode.FateInfo },
            { 0x01c5, MatchaOpcode.InitZone },
            { 0x0278, MatchaOpcode.InventoryTransaction },
            { 0x0335, MatchaOpcode.ItemInfo },
            { 0x01b0, MatchaOpcode.MarketBoardItemListing },
            { 0x034c, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0323, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0267, MatchaOpcode.NpcSpawn },
            { 0x0085, MatchaOpcode.PlayerSetup },
            { 0x03ad, MatchaOpcode.PlayerSpawn },
        };
    }
}
