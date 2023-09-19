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
            { 0x00D4, MatchaOpcode.ActorControl },
            { 0x03C1, MatchaOpcode.ActorControlSelf },
            { 0x0147, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x034F, MatchaOpcode.CompanyAirshipStatus },
            { 0x0198, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0069, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x018D, MatchaOpcode.DirectorStart },
            { 0x02DB, MatchaOpcode.EventPlay },
            { 0x0200, MatchaOpcode.Examine },
            { 0x025B, MatchaOpcode.FateInfo },
            { 0x0071, MatchaOpcode.InitZone },
            { 0x03DB, MatchaOpcode.InventoryTransaction },
            { 0x03A4, MatchaOpcode.ItemInfo },
            { 0x01DB, MatchaOpcode.MarketBoardItemListing },
            { 0x0306, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02F4, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0091, MatchaOpcode.NpcSpawn },
            { 0x020E, MatchaOpcode.PlayerSetup },
            { 0x010E, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x007A, MatchaOpcode.ActorControl },
            { 0x0139, MatchaOpcode.ActorControlSelf },
            { 0x034F, MatchaOpcode.CEDirector },
            { 0x03A5, MatchaOpcode.CompanyAirshipStatus },
            { 0x0274, MatchaOpcode.CompanySubmersibleStatus },
            { 0x00EC, MatchaOpcode.ContentFinderNotifyPop },
            { 0x031e, MatchaOpcode.DirectorStart }, // unknown
            { 0x00A0, MatchaOpcode.EventPlay },
            { 0x00F6, MatchaOpcode.Examine },
            { 0x020E, MatchaOpcode.FateInfo },
            { 0x024D, MatchaOpcode.InitZone },
            { 0x0111, MatchaOpcode.InventoryTransaction },
            { 0x0214, MatchaOpcode.ItemInfo },
            { 0x0188, MatchaOpcode.MarketBoardItemListing },
            { 0x02BA, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02E4, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x00D8, MatchaOpcode.NpcSpawn },
            { 0x028D, MatchaOpcode.PlayerSetup },
            { 0x00C0, MatchaOpcode.PlayerSpawn },
        };
    }
}
