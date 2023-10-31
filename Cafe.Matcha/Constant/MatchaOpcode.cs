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
            { 0x0342, MatchaOpcode.ActorControl },
            { 0x00E4, MatchaOpcode.ActorControlSelf },
            { 0x013C, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x00AB, MatchaOpcode.CompanyAirshipStatus },
            { 0x03C2, MatchaOpcode.CompanySubmersibleStatus },
            { 0x030D, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x0125, MatchaOpcode.DirectorStart },
            { 0x022E, MatchaOpcode.EventPlay },
            { 0x0153, MatchaOpcode.Examine },
            { 0x017B, MatchaOpcode.FateInfo },
            { 0x0243, MatchaOpcode.InitZone },
            { 0x02FD, MatchaOpcode.InventoryTransaction },
            { 0x008A, MatchaOpcode.ItemInfo },
            { 0x0376, MatchaOpcode.MarketBoardItemListing },
            { 0x02B6, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0253, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x02BB, MatchaOpcode.NpcSpawn },
            { 0x0095, MatchaOpcode.PlayerSetup },
            { 0x0167, MatchaOpcode.PlayerSpawn },
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
