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
            { 0x02E3, MatchaOpcode.ActorControl },
            { 0x0193, MatchaOpcode.ActorControlSelf },
            { 0x0083, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x02E2, MatchaOpcode.CompanyAirshipStatus },
            { 0x00D6, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0153, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x0231, MatchaOpcode.DirectorStart },
            { 0x034D, MatchaOpcode.EventPlay },
            { 0x0102, MatchaOpcode.Examine },
            { 0x007A, MatchaOpcode.FateInfo }, // FIXME
            { 0x0364, MatchaOpcode.InitZone },
            { 0x02ED, MatchaOpcode.InventoryTransaction },
            { 0x02D7, MatchaOpcode.ItemInfo },
            { 0x02DD, MatchaOpcode.MarketBoardItemListing },
            { 0x018E, MatchaOpcode.MarketBoardItemListingCount },
            { 0x01D7, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x03CE, MatchaOpcode.NpcSpawn },
            { 0x00D7, MatchaOpcode.PlayerSetup },
            { 0x0197, MatchaOpcode.PlayerSpawn },
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
