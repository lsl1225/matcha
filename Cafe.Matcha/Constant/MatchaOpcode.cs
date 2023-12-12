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
            { 0x03B6, MatchaOpcode.ActorControl },
            { 0x00E2, MatchaOpcode.ActorControlSelf },
            { 0x038B, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x0200, MatchaOpcode.CompanyAirshipStatus },
            { 0x006F, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0318, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x0338, MatchaOpcode.DirectorStart },
            { 0x0331, MatchaOpcode.EventPlay },
            { 0x01D1, MatchaOpcode.Examine },
            { 0x02EA, MatchaOpcode.FateInfo },
            { 0x0180, MatchaOpcode.InitZone },
            { 0x021B, MatchaOpcode.InventoryTransaction },
            { 0x0270, MatchaOpcode.ItemInfo },
            { 0x025A, MatchaOpcode.MarketBoardItemListing },
            { 0x02A5, MatchaOpcode.MarketBoardItemListingCount },
            { 0x00E7, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x023B, MatchaOpcode.NpcSpawn },
            { 0x023D, MatchaOpcode.PlayerSetup },
            { 0x007E, MatchaOpcode.PlayerSpawn },
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
