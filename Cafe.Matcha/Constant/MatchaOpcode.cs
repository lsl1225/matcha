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
            { 0x02df, MatchaOpcode.ActorControl },
            { 0x0251, MatchaOpcode.ActorControlSelf },
            { 0x00e8, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x00dd, MatchaOpcode.CompanyAirshipStatus },
            { 0x0078, MatchaOpcode.CompanySubmersibleStatus },
            { 0x01ae, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x0202, MatchaOpcode.DirectorStart },
            { 0x02eb, MatchaOpcode.EventPlay },
            { 0x0338, MatchaOpcode.Examine },
            { 0x007a, MatchaOpcode.FateInfo }, // FIXME
            { 0x023d, MatchaOpcode.InitZone },
            { 0x01dc, MatchaOpcode.InventoryTransaction },
            { 0x0197, MatchaOpcode.ItemInfo },
            { 0x03b2, MatchaOpcode.MarketBoardItemListing },
            { 0x03b5, MatchaOpcode.MarketBoardItemListingCount },
            { 0x01ab, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x01c4, MatchaOpcode.NpcSpawn },
            { 0x016e, MatchaOpcode.PlayerSetup },
            { 0x0154, MatchaOpcode.PlayerSpawn },
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
