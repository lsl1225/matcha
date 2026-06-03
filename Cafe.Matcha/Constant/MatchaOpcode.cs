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
            { 0x01E8, MatchaOpcode.ActorControl },
            { 0x01C9, MatchaOpcode.ActorControlSelf },
            { 0x03DA, MatchaOpcode.CEDirector },
            { 0x0081, MatchaOpcode.CompanyAirshipStatus },
            { 0x0068, MatchaOpcode.CompanySubmersibleStatus },
            { 0x02F2, MatchaOpcode.ContentFinderNotifyPop },
            { 0x030C, MatchaOpcode.ResumeEventScene32 },
            { 0x007E, MatchaOpcode.EventPlay },
            { 0x0251, MatchaOpcode.EventStart },
            { 0x03A2, MatchaOpcode.Examine },
            { 0x03A9, MatchaOpcode.FateInfo },
            { 0x0096, MatchaOpcode.InitZone },
            { 0x028E, MatchaOpcode.InventoryTransaction },
            { 0x033E, MatchaOpcode.ItemInfo },
            { 0x0244, MatchaOpcode.MarketBoardItemListing },
            { 0x0287, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0113, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8292, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x026B, MatchaOpcode.NpcSpawn },
            { 0x023F, MatchaOpcode.PlayerSetup },
            { 0x0255, MatchaOpcode.PlayerSpawn },
            { 0x0292, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x01E8, MatchaOpcode.ActorControl },
            { 0x01C9, MatchaOpcode.ActorControlSelf },
            { 0x03DA, MatchaOpcode.CEDirector },
            { 0x0081, MatchaOpcode.CompanyAirshipStatus },
            { 0x0068, MatchaOpcode.CompanySubmersibleStatus },
            { 0x02F2, MatchaOpcode.ContentFinderNotifyPop },
            { 0x030C, MatchaOpcode.ResumeEventScene32 },
            { 0x007E, MatchaOpcode.EventPlay },
            { 0x0251, MatchaOpcode.EventStart },
            { 0x03A2, MatchaOpcode.Examine },
            { 0x03A9, MatchaOpcode.FateInfo },
            { 0x0096, MatchaOpcode.InitZone },
            { 0x028E, MatchaOpcode.InventoryTransaction },
            { 0x033E, MatchaOpcode.ItemInfo },
            { 0x0244, MatchaOpcode.MarketBoardItemListing },
            { 0x0287, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0113, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8292, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x026B, MatchaOpcode.NpcSpawn },
            { 0x023F, MatchaOpcode.PlayerSetup },
            { 0x0255, MatchaOpcode.PlayerSpawn },
            { 0x0292, MatchaOpcode.WorldVisitQueue },
        };
    }
}
