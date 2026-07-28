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
        SubmarineStatusList,
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
            { 0x0112, MatchaOpcode.ActorControl },
            { 0x020E, MatchaOpcode.ActorControlSelf },
            { 0x0097, MatchaOpcode.CEDirector },
            { 0x0145, MatchaOpcode.CompanyAirshipStatus },
            { 0x007A, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0148, MatchaOpcode.ContentFinderNotifyPop },
            { 0x02DE, MatchaOpcode.ResumeEventScene32 },
            { 0x015A, MatchaOpcode.EventPlay },
            { 0x00B4, MatchaOpcode.EventStart },
            { 0x0288, MatchaOpcode.Examine },
            { 0x00A6, MatchaOpcode.FateInfo },
            { 0x02D9, MatchaOpcode.InitZone },
            { 0x01DF, MatchaOpcode.InventoryTransaction },
            { 0x01EA, MatchaOpcode.ItemInfo },
            { 0x015C, MatchaOpcode.MarketBoardItemListing },
            { 0x00E6, MatchaOpcode.MarketBoardItemListingCount },
            { 0x013F, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8172, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0080, MatchaOpcode.NpcSpawn },
            { 0x03A7, MatchaOpcode.PlayerSetup },
            { 0x0071, MatchaOpcode.PlayerSpawn },
            { 0x037F, MatchaOpcode.SubmarineStatusList },
            { 0x0269, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0112, MatchaOpcode.ActorControl },
            { 0x020E, MatchaOpcode.ActorControlSelf },
            { 0x0097, MatchaOpcode.CEDirector },
            { 0x0145, MatchaOpcode.CompanyAirshipStatus },
            { 0x007A, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0148, MatchaOpcode.ContentFinderNotifyPop },
            { 0x02DE, MatchaOpcode.ResumeEventScene32 },
            { 0x015A, MatchaOpcode.EventPlay },
            { 0x00B4, MatchaOpcode.EventStart },
            { 0x0288, MatchaOpcode.Examine },
            { 0x00A6, MatchaOpcode.FateInfo },
            { 0x02D9, MatchaOpcode.InitZone },
            { 0x01DF, MatchaOpcode.InventoryTransaction },
            { 0x01EA, MatchaOpcode.ItemInfo },
            { 0x015C, MatchaOpcode.MarketBoardItemListing },
            { 0x00E6, MatchaOpcode.MarketBoardItemListingCount },
            { 0x013F, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8172, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0080, MatchaOpcode.NpcSpawn },
            { 0x03A7, MatchaOpcode.PlayerSetup },
            { 0x0071, MatchaOpcode.PlayerSpawn },
            { 0x037F, MatchaOpcode.SubmarineStatusList },
            { 0x0269, MatchaOpcode.WorldVisitQueue },
        };
    }
}
