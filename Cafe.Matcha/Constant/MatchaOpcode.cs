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
            { 0x017B, MatchaOpcode.FateInfo }, // unk
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
