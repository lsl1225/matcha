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
            { 0x0381, MatchaOpcode.ActorControl },
            { 0x014F, MatchaOpcode.ActorControlSelf },
            { 0x00BC, MatchaOpcode.CEDirector },
            /* 
             * AirshipTimers & SubmarineTimers
             */
            { 0x0132, MatchaOpcode.CompanyAirshipStatus },
            { 0x02B7, MatchaOpcode.CompanySubmersibleStatus },
            { 0x03E0, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x03C6, MatchaOpcode.DirectorStart },
            { 0x00FB, MatchaOpcode.EventPlay },
            { 0x0364, MatchaOpcode.Examine },
            { 0x01E8, MatchaOpcode.FateInfo },
            { 0x0347, MatchaOpcode.InitZone },
            { 0x02E9, MatchaOpcode.InventoryTransaction },
            { 0x0128, MatchaOpcode.ItemInfo },
            { 0x00A7, MatchaOpcode.MarketBoardItemListing },
            { 0x01A4, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02B4, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x01C4, MatchaOpcode.NpcSpawn },
            { 0x0218, MatchaOpcode.PlayerSetup },
            { 0x02CF, MatchaOpcode.PlayerSpawn },
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
