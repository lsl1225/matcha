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
            { 0x0179, MatchaOpcode.DirectorStart },
            { 0x01A7, MatchaOpcode.EventPlay },
            { 0x035E, MatchaOpcode.Examine },
            { 0x032E, MatchaOpcode.FateInfo },
            { 0x0230, MatchaOpcode.InitZone },
            { 0x00C4, MatchaOpcode.InventoryTransaction },
            { 0x032A, MatchaOpcode.ItemInfo },
            { 0x0237, MatchaOpcode.MarketBoardItemListing },
            { 0x01FE, MatchaOpcode.MarketBoardItemListingCount },
            { 0x014A, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x027C, MatchaOpcode.NpcSpawn },
            { 0x025F, MatchaOpcode.PlayerSetup },
            { 0x00DD, MatchaOpcode.PlayerSpawn },
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
