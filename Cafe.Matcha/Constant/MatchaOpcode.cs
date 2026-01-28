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
            { 0x2C8, MatchaOpcode.ActorControl },
            { 0x2B3, MatchaOpcode.ActorControlSelf },
            { 0xF5, MatchaOpcode.CEDirector },
            { 0x3C6, MatchaOpcode.CompanyAirshipStatus },
            { 0x267, MatchaOpcode.CompanySubmersibleStatus },
            { 0x24F, MatchaOpcode.ContentFinderNotifyPop },
            { 0x3CE, MatchaOpcode.ResumeEventScene32 },
            { 0x352, MatchaOpcode.EventPlay },
            { 0x2F8, MatchaOpcode.EventStart },
            { 0x235, MatchaOpcode.Examine },
            { 0x20E, MatchaOpcode.FateInfo },
            { 0x1A4, MatchaOpcode.InitZone },
            { 0x1A9, MatchaOpcode.InventoryTransaction },
            { 0x94, MatchaOpcode.ItemInfo },
            { 0x69, MatchaOpcode.MarketBoardItemListing },
            { 0x210, MatchaOpcode.MarketBoardItemListingCount },
            { 0x377, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8389, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x2E8, MatchaOpcode.NpcSpawn },
            { 0xD7, MatchaOpcode.PlayerSetup },
            { 0x13E, MatchaOpcode.PlayerSpawn },
            { 0x0389, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x2C8, MatchaOpcode.ActorControl },
            { 0x2B3, MatchaOpcode.ActorControlSelf },
            { 0xF5, MatchaOpcode.CEDirector },
            { 0x3C6, MatchaOpcode.CompanyAirshipStatus },
            { 0x267, MatchaOpcode.CompanySubmersibleStatus },
            { 0x24F, MatchaOpcode.ContentFinderNotifyPop },
            { 0x3CE, MatchaOpcode.ResumeEventScene32 },
            { 0x352, MatchaOpcode.EventPlay },
            { 0x2F8, MatchaOpcode.EventStart },
            { 0x235, MatchaOpcode.Examine },
            { 0x20E, MatchaOpcode.FateInfo },
            { 0x1A4, MatchaOpcode.InitZone },
            { 0x1A9, MatchaOpcode.InventoryTransaction },
            { 0x94, MatchaOpcode.ItemInfo },
            { 0x69, MatchaOpcode.MarketBoardItemListing },
            { 0x210, MatchaOpcode.MarketBoardItemListingCount },
            { 0x377, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8389, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x2E8, MatchaOpcode.NpcSpawn },
            { 0xD7, MatchaOpcode.PlayerSetup },
            { 0x13E, MatchaOpcode.PlayerSpawn },
            { 0x0389, MatchaOpcode.WorldVisitQueue },
        };
    }
}
