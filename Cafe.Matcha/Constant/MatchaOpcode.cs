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
            { 0x0294, MatchaOpcode.ActorControlSelf },
            { 0x019E, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x00D0, MatchaOpcode.CompanyAirshipStatus },
            { 0x035D, MatchaOpcode.CompanySubmersibleStatus },
            { 0x02E8, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x02AE, MatchaOpcode.DirectorStart },
            { 0x03D1, MatchaOpcode.EventPlay },
            { 0x0084, MatchaOpcode.Examine },
            { 0x036B, MatchaOpcode.FateInfo },
            { 0x0336, MatchaOpcode.InitZone },
            { 0x0332, MatchaOpcode.InventoryTransaction },
            { 0x0217, MatchaOpcode.ItemInfo },
            { 0x03DE, MatchaOpcode.MarketBoardItemListing },
            { 0x0360, MatchaOpcode.MarketBoardItemListingCount },
            { 0x00B1, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0117, MatchaOpcode.NpcSpawn },
            { 0x0361, MatchaOpcode.PlayerSetup },
            { 0x0152, MatchaOpcode.PlayerSpawn },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x02c3, MatchaOpcode.ActorControl },
            { 0x0302, MatchaOpcode.ActorControlSelf },
            { 0x0362, MatchaOpcode.CEDirector },
            { 0x0269, MatchaOpcode.CompanyAirshipStatus },
            { 0x038e, MatchaOpcode.CompanySubmersibleStatus },
            { 0x01a5, MatchaOpcode.ContentFinderNotifyPop },
            { 0x00c2, MatchaOpcode.DirectorStart },
            { 0x00dc, MatchaOpcode.EventPlay },
            { 0x0192, MatchaOpcode.Examine },
            { 0x00af, MatchaOpcode.FateInfo },
            { 0x018d, MatchaOpcode.InitZone },
            { 0x03ca, MatchaOpcode.InventoryTransaction },
            { 0x01dd, MatchaOpcode.ItemInfo },
            { 0x0337, MatchaOpcode.MarketBoardItemListing },
            { 0x02d9, MatchaOpcode.MarketBoardItemListingCount },
            { 0x01bd, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0393, MatchaOpcode.NpcSpawn },
            { 0x0283, MatchaOpcode.PlayerSetup },
            { 0x039b, MatchaOpcode.PlayerSpawn },
        };
    }
}
