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
            { 0x0333, MatchaOpcode.ActorControl },
            { 0x0111, MatchaOpcode.ActorControlSelf },
            { 0x0383, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x027A, MatchaOpcode.CompanyAirshipStatus },
            { 0x020C, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0225, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x00E2, MatchaOpcode.DirectorStart },
            { 0x012A, MatchaOpcode.EventPlay },
            { 0x02BF, MatchaOpcode.Examine },
            { 0x00C9, MatchaOpcode.FateInfo },
            { 0x031B, MatchaOpcode.InitZone },
            { 0x0201, MatchaOpcode.InventoryTransaction },
            { 0x0344, MatchaOpcode.ItemInfo },
            { 0x03E5, MatchaOpcode.MarketBoardItemListing },
            { 0x02ED, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0109, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x02BD, MatchaOpcode.NpcSpawn },
            { 0x0216, MatchaOpcode.PlayerSetup },
            { 0x00F6, MatchaOpcode.PlayerSpawn },
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
