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
            { 0x01BB, MatchaOpcode.ActorControl },
            { 0x0228, MatchaOpcode.ActorControlSelf },
            { 0x0287, MatchaOpcode.CEDirector },
            { 0x01E5, MatchaOpcode.CompanyAirshipStatus },
            { 0x00A5, MatchaOpcode.CompanySubmersibleStatus },
            { 0x03C6, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0256, MatchaOpcode.DirectorStart }, // missing
            { 0x017F, MatchaOpcode.EventPlay },
            { 0x03DC, MatchaOpcode.Examine },
            { 0x0355, MatchaOpcode.FateInfo },
            { 0x037D, MatchaOpcode.InitZone },
            { 0x006e, MatchaOpcode.InventoryTransaction },  // missing
            { 0x01c2, MatchaOpcode.ItemInfo },  // missing
            { 0x03CB, MatchaOpcode.MarketBoardItemListing },
            { 0x032E, MatchaOpcode.MarketBoardItemListingCount },
            { 0x03B1, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x01C0, MatchaOpcode.NpcSpawn },
            { 0x027F, MatchaOpcode.PlayerSetup },
            { 0x0100, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x03d0, MatchaOpcode.ActorControl },
            { 0x00f1, MatchaOpcode.ActorControlSelf },
            { 0x039d, MatchaOpcode.CEDirector },
            { 0x013b, MatchaOpcode.CompanyAirshipStatus },
            { 0x016e, MatchaOpcode.CompanySubmersibleStatus },
            { 0x02dd, MatchaOpcode.ContentFinderNotifyPop },
            { 0x00f2, MatchaOpcode.DirectorStart },
            { 0x022f, MatchaOpcode.EventPlay },
            { 0x00ec, MatchaOpcode.Examine },
            { 0x032a, MatchaOpcode.FateInfo },
            { 0x00ce, MatchaOpcode.InitZone },
            { 0x00a7, MatchaOpcode.InventoryTransaction },
            { 0x0399, MatchaOpcode.ItemInfo },
            { 0x0102, MatchaOpcode.MarketBoardItemListing },
            { 0x02e6, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0231, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x01c3, MatchaOpcode.NpcSpawn },
            { 0x01af, MatchaOpcode.PlayerSetup },
            { 0x008f, MatchaOpcode.PlayerSpawn },
        };
    }
}
