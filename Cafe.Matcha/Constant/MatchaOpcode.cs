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
            { 0x02C9, MatchaOpcode.ActorControl },
            { 0x0340, MatchaOpcode.ActorControlSelf },
            { 0x0338, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x019B, MatchaOpcode.CompanyAirshipStatus },
            { 0x0136, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0147, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x00B3, MatchaOpcode.DirectorStart },
            { 0x0335, MatchaOpcode.EventPlay },
            { 0x0308, MatchaOpcode.Examine },
            { 0x02D3, MatchaOpcode.FateInfo },
            { 0x02D7, MatchaOpcode.InitZone },
            { 0x00E2, MatchaOpcode.InventoryTransaction },
            { 0x03AE, MatchaOpcode.ItemInfo },
            { 0x0077, MatchaOpcode.MarketBoardItemListing },
            { 0x00FB, MatchaOpcode.MarketBoardItemListingCount },
            { 0x00C5, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x03CE, MatchaOpcode.NpcSpawn },
            { 0x01AB, MatchaOpcode.PlayerSetup },
            { 0x0285, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0181, MatchaOpcode.ActorControl },
            { 0x00db, MatchaOpcode.ActorControlSelf },
            { 0x00d0, MatchaOpcode.CEDirector },
            { 0x02e8, MatchaOpcode.CompanyAirshipStatus },
            { 0x0330, MatchaOpcode.CompanySubmersibleStatus },
            { 0x036c, MatchaOpcode.ContentFinderNotifyPop },
            { 0x027e, MatchaOpcode.DirectorStart },
            { 0x021d, MatchaOpcode.EventPlay },
            { 0x00fa, MatchaOpcode.Examine },
            { 0x01f2, MatchaOpcode.FateInfo },
            { 0x00a2, MatchaOpcode.InitZone },
            { 0x028c, MatchaOpcode.InventoryTransaction },
            { 0x0336, MatchaOpcode.ItemInfo },
            { 0x0315, MatchaOpcode.MarketBoardItemListing },
            { 0x0319, MatchaOpcode.MarketBoardItemListingCount },
            { 0x018f, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x02ae, MatchaOpcode.NpcSpawn },
            { 0x030d, MatchaOpcode.PlayerSetup },
            { 0x0065, MatchaOpcode.PlayerSpawn },
        };
    }
}
