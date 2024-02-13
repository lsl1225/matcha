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
            { 0x02CD, MatchaOpcode.ActorControl },
            { 0x032D, MatchaOpcode.ActorControlSelf },
            { 0x03D8, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x0172, MatchaOpcode.CompanyAirshipStatus },
            { 0x031D, MatchaOpcode.CompanySubmersibleStatus },
            { 0x022C, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x0338, MatchaOpcode.DirectorStart }, // unknown
            { 0x01A7, MatchaOpcode.EventPlay },
            { 0x035E, MatchaOpcode.Examine },
            { 0x032E, MatchaOpcode.FateInfo },
            { 0x0230, MatchaOpcode.InitZone },
            { 0x021B, MatchaOpcode.InventoryTransaction }, // unknown
            { 0x0270, MatchaOpcode.ItemInfo }, // unknown
            { 0x0237, MatchaOpcode.MarketBoardItemListing },
            { 0x01FE, MatchaOpcode.MarketBoardItemListingCount },
            { 0x014A, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x027C, MatchaOpcode.NpcSpawn },
            { 0x025F, MatchaOpcode.PlayerSetup },
            { 0x00DD, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x02c3, MatchaOpcode.ActorControl },
            { 0x0302, MatchaOpcode.ActorControlSelf },
            { 0x0362, MatchaOpcode.CEDirector },
            { 0x0269, MatchaOpcode.CompanyAirshipStatus },
            { 0x038e, MatchaOpcode.CompanySubmersibleStatus },
            { 0x01a5, MatchaOpcode.ContentFinderNotifyPop },
            { 0x00c2, MatchaOpcode.DirectorStart },
            { 0x00dc, MatchaOpcode.EventPlay },
            { 0x0192, MatchaOpcode.Examine },
            { 0x00af, MatchaOpcode.FateInfo },
            { 0x018d, MatchaOpcode.InitZone },
            { 0x03ca, MatchaOpcode.InventoryTransaction },
            { 0x01dd, MatchaOpcode.ItemInfo },
            { 0x0337, MatchaOpcode.MarketBoardItemListing },
            { 0x02d9, MatchaOpcode.MarketBoardItemListingCount },
            { 0x01bd, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0393, MatchaOpcode.NpcSpawn },
            { 0x0283, MatchaOpcode.PlayerSetup },
            { 0x039b, MatchaOpcode.PlayerSpawn },
        };
    }
}
