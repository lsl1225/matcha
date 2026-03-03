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
            { 0x0114, MatchaOpcode.ActorControl },
            { 0x014E, MatchaOpcode.ActorControlSelf },
            { 0x0277, MatchaOpcode.CEDirector },
            { 0x0388, MatchaOpcode.CompanyAirshipStatus },
            { 0x01AD, MatchaOpcode.CompanySubmersibleStatus },
            { 0x037E, MatchaOpcode.ContentFinderNotifyPop },
            { 0x034D, MatchaOpcode.ResumeEventScene32 },
            { 0x0091, MatchaOpcode.EventPlay },
            { 0x0085, MatchaOpcode.EventStart },
            { 0x008B, MatchaOpcode.Examine },
            { 0x010F, MatchaOpcode.FateInfo },
            { 0x009D, MatchaOpcode.InitZone },
            { 0x01C7, MatchaOpcode.InventoryTransaction },
            { 0x0328, MatchaOpcode.ItemInfo },
            { 0x0333, MatchaOpcode.MarketBoardItemListing },
            { 0x00F8, MatchaOpcode.MarketBoardItemListingCount },
            { 0x00A5, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x83DC, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0304, MatchaOpcode.NpcSpawn },
            { 0x00E5, MatchaOpcode.PlayerSetup },
            { 0x01A4, MatchaOpcode.PlayerSpawn },
            { 0x03DC, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0114, MatchaOpcode.ActorControl },
            { 0x014E, MatchaOpcode.ActorControlSelf },
            { 0x0277, MatchaOpcode.CEDirector },
            { 0x0388, MatchaOpcode.CompanyAirshipStatus },
            { 0x01AD, MatchaOpcode.CompanySubmersibleStatus },
            { 0x037E, MatchaOpcode.ContentFinderNotifyPop },
            { 0x034D, MatchaOpcode.ResumeEventScene32 },
            { 0x0091, MatchaOpcode.EventPlay },
            { 0x0085, MatchaOpcode.EventStart },
            { 0x008B, MatchaOpcode.Examine },
            { 0x010F, MatchaOpcode.FateInfo },
            { 0x009D, MatchaOpcode.InitZone },
            { 0x01C7, MatchaOpcode.InventoryTransaction },
            { 0x0328, MatchaOpcode.ItemInfo },
            { 0x0333, MatchaOpcode.MarketBoardItemListing },
            { 0x00F8, MatchaOpcode.MarketBoardItemListingCount },
            { 0x00A5, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x83DC, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0304, MatchaOpcode.NpcSpawn },
            { 0x00E5, MatchaOpcode.PlayerSetup },
            { 0x01A4, MatchaOpcode.PlayerSpawn },
            { 0x03DC, MatchaOpcode.WorldVisitQueue },
        };
    }
}
