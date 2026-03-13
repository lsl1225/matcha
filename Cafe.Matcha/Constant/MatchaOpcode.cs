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
            { 0x00E7, MatchaOpcode.ActorControl },
            { 0x0217, MatchaOpcode.ActorControlSelf },
            { 0x02F5, MatchaOpcode.CEDirector },
            { 0x00CC, MatchaOpcode.CompanyAirshipStatus },
            { 0x0074, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0285, MatchaOpcode.ContentFinderNotifyPop },
            { 0x015E, MatchaOpcode.ResumeEventScene32 },
            { 0x02B4, MatchaOpcode.EventPlay },
            { 0x00BC, MatchaOpcode.EventStart },
            { 0x03C4, MatchaOpcode.Examine },
            { 0x02FA, MatchaOpcode.FateInfo },
            { 0x0246, MatchaOpcode.InitZone },
            { 0x011A, MatchaOpcode.InventoryTransaction },
            { 0x01A8, MatchaOpcode.ItemInfo },
            { 0x01C2, MatchaOpcode.MarketBoardItemListing },
            { 0x00A5, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02EF, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8350, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x03C3, MatchaOpcode.NpcSpawn },
            { 0x016D, MatchaOpcode.PlayerSetup },
            { 0x03CA, MatchaOpcode.PlayerSpawn },
            { 0x0350, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x00E7, MatchaOpcode.ActorControl },
            { 0x0217, MatchaOpcode.ActorControlSelf },
            { 0x02F5, MatchaOpcode.CEDirector },
            { 0x00CC, MatchaOpcode.CompanyAirshipStatus },
            { 0x0074, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0285, MatchaOpcode.ContentFinderNotifyPop },
            { 0x015E, MatchaOpcode.ResumeEventScene32 },
            { 0x02B4, MatchaOpcode.EventPlay },
            { 0x00BC, MatchaOpcode.EventStart },
            { 0x03C4, MatchaOpcode.Examine },
            { 0x02FA, MatchaOpcode.FateInfo },
            { 0x0246, MatchaOpcode.InitZone },
            { 0x011A, MatchaOpcode.InventoryTransaction },
            { 0x01A8, MatchaOpcode.ItemInfo },
            { 0x01C2, MatchaOpcode.MarketBoardItemListing },
            { 0x00A5, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02EF, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8350, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x03C3, MatchaOpcode.NpcSpawn },
            { 0x016D, MatchaOpcode.PlayerSetup },
            { 0x03CA, MatchaOpcode.PlayerSpawn },
            { 0x0350, MatchaOpcode.WorldVisitQueue },
        };
    }
}
