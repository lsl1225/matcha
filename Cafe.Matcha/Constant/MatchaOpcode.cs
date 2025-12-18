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
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x013C, MatchaOpcode.ActorControl },
            { 0x01D8, MatchaOpcode.ActorControlSelf },
            { 0x03C9, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x01A3, MatchaOpcode.CompanyAirshipStatus },
            { 0x01C0, MatchaOpcode.CompanySubmersibleStatus },
            { 0x029D, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x033C, MatchaOpcode.ResumeEventScene32 },
            { 0x01B8, MatchaOpcode.EventPlay },
            { 0x021C, MatchaOpcode.EventStart },
            { 0x01FF, MatchaOpcode.Examine },
            { 0x025A, MatchaOpcode.FateInfo },
            { 0x0175, MatchaOpcode.InitZone },
            { 0x02DC, MatchaOpcode.InventoryTransaction },
            { 0x0215, MatchaOpcode.ItemInfo },
            { 0x0067, MatchaOpcode.MarketBoardItemListing },
            { 0x0146, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0332, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x0320, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x02FC, MatchaOpcode.NpcSpawn },
            { 0x0090, MatchaOpcode.PlayerSetup },
            { 0x0107, MatchaOpcode.PlayerSpawn },
            { 0x0320, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0167, MatchaOpcode.ActorControl },
            { 0x0110, MatchaOpcode.ActorControlSelf },
            { 0x0364, MatchaOpcode.CEDirector },
            { 0x02f4, MatchaOpcode.CompanyAirshipStatus },
            { 0x00e5, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0080, MatchaOpcode.ContentFinderNotifyPop },
            { 0x024e, MatchaOpcode.ResumeEventScene32 },
            { 0x03b5, MatchaOpcode.EventPlay },
            { 0x0235, MatchaOpcode.EventStart },
            { 0x0340, MatchaOpcode.Examine },
            { 0x02e5, MatchaOpcode.FateInfo },
            { 0x0362, MatchaOpcode.InitZone },
            { 0x01a0, MatchaOpcode.InventoryTransaction },
            { 0x00b7, MatchaOpcode.ItemInfo },
            { 0x02c1, MatchaOpcode.MarketBoardItemListing },
            { 0x013f, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02ed, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8308, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x00fc, MatchaOpcode.NpcSpawn },
            { 0x0300, MatchaOpcode.PlayerSetup },
            { 0x03e7, MatchaOpcode.PlayerSpawn },
            { 0x03af, MatchaOpcode.WorldVisitQueue },
        };
    }
}
