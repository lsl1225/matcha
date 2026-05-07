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
        ResumeEventScene32,
        EventPlay,
        EventStart,
        Examine,
        FateInfo,
        InitZone,
        InventoryTransaction,
        ItemInfo,
        MarketBoardItemListing,
        MarketBoardItemListingCount,
        MarketBoardItemListingHistory,
        MarketBoardRequestItemListingInfo,
        NpcSpawn,
        PlayerSetup,
        PlayerSpawn,
        WorldVisitQueue,
    }

    internal static class OpcodeStorage
    {
        /*
         * CompanyAirshipStatus -> AirshipTimers
         * CompanySubmersibleStatus -> SubmarineTimers
         * ResumeEventScene32 -> MiniCactpotInit
         */
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0343, MatchaOpcode.ActorControl },
            { 0x020E, MatchaOpcode.ActorControlSelf },
            { 0x016C, MatchaOpcode.CEDirector },
            { 0x021A, MatchaOpcode.CompanyAirshipStatus },
            { 0x0163, MatchaOpcode.CompanySubmersibleStatus },
            { 0x007E, MatchaOpcode.ContentFinderNotifyPop },
            { 0x00D6, MatchaOpcode.ResumeEventScene32 },
            { 0x010F, MatchaOpcode.EventPlay },
            { 0x034C, MatchaOpcode.EventStart },
            { 0x02C4, MatchaOpcode.Examine },
            { 0x00E1, MatchaOpcode.FateInfo },
            { 0x0237, MatchaOpcode.InitZone },
            { 0x0318, MatchaOpcode.InventoryTransaction },
            { 0x01A0, MatchaOpcode.ItemInfo },
            { 0x032D, MatchaOpcode.MarketBoardItemListing },
            { 0x02E8, MatchaOpcode.MarketBoardItemListingCount },
            { 0x01CC, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x81A3, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x00F6, MatchaOpcode.NpcSpawn },
            { 0x01D6, MatchaOpcode.PlayerSetup },
            { 0x02AA, MatchaOpcode.PlayerSpawn },
            { 0x01A3, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0343, MatchaOpcode.ActorControl },
            { 0x020E, MatchaOpcode.ActorControlSelf },
            { 0x016C, MatchaOpcode.CEDirector },
            { 0x021A, MatchaOpcode.CompanyAirshipStatus },
            { 0x0163, MatchaOpcode.CompanySubmersibleStatus },
            { 0x007E, MatchaOpcode.ContentFinderNotifyPop },
            { 0x00D6, MatchaOpcode.ResumeEventScene32 },
            { 0x010F, MatchaOpcode.EventPlay },
            { 0x034C, MatchaOpcode.EventStart },
            { 0x02C4, MatchaOpcode.Examine },
            { 0x00E1, MatchaOpcode.FateInfo },
            { 0x0237, MatchaOpcode.InitZone },
            { 0x0318, MatchaOpcode.InventoryTransaction },
            { 0x01A0, MatchaOpcode.ItemInfo },
            { 0x032D, MatchaOpcode.MarketBoardItemListing },
            { 0x02E8, MatchaOpcode.MarketBoardItemListingCount },
            { 0x01CC, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x81A3, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x00F6, MatchaOpcode.NpcSpawn },
            { 0x01D6, MatchaOpcode.PlayerSetup },
            { 0x02AA, MatchaOpcode.PlayerSpawn },
            { 0x01A3, MatchaOpcode.WorldVisitQueue },
        };
    }
}
