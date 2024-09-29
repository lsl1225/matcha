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
            { 0x0178, MatchaOpcode.ActorControl },
            { 0x02a7, MatchaOpcode.ActorControlSelf },
            { 0x0262, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x0371, MatchaOpcode.CompanyAirshipStatus },
            { 0x00f8, MatchaOpcode.CompanySubmersibleStatus },
            { 0x014f, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x0083, MatchaOpcode.DirectorStart },
            { 0x026d, MatchaOpcode.EventPlay },
            { 0x0326, MatchaOpcode.Examine },
            { 0x020a, MatchaOpcode.FateInfo },
            { 0x01f1, MatchaOpcode.InitZone },
            { 0x00e8, MatchaOpcode.InventoryTransaction },
            { 0x0236, MatchaOpcode.ItemInfo },
            { 0x01c3, MatchaOpcode.MarketBoardItemListing },
            { 0x00a0, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0102, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0186, MatchaOpcode.NpcSpawn },
            { 0x00c6, MatchaOpcode.PlayerSetup },
            { 0x024f, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x019b, MatchaOpcode.ActorControl },
            { 0x033f, MatchaOpcode.ActorControlSelf },
            { 0x00af, MatchaOpcode.CEDirector },
            { 0x0398, MatchaOpcode.CompanyAirshipStatus },
            { 0x0377, MatchaOpcode.CompanySubmersibleStatus },
            { 0x02c7, MatchaOpcode.ContentFinderNotifyPop },
            { 0x01b0, MatchaOpcode.DirectorStart },
            { 0x0230, MatchaOpcode.EventPlay },
            { 0x0233, MatchaOpcode.Examine },
            { 0x01b9, MatchaOpcode.FateInfo },
            { 0x00e1, MatchaOpcode.InitZone },
            { 0x02b9, MatchaOpcode.InventoryTransaction },
            { 0x037f, MatchaOpcode.ItemInfo },
            { 0x0079, MatchaOpcode.MarketBoardItemListing },
            { 0x032e, MatchaOpcode.MarketBoardItemListingCount },
            { 0x012c, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0261, MatchaOpcode.NpcSpawn },
            { 0x01f3, MatchaOpcode.PlayerSetup },
            { 0x0301, MatchaOpcode.PlayerSpawn },
        };
    }
}
