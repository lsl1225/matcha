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
            { 0x00D8, MatchaOpcode.ActorControl },
            { 0x038A, MatchaOpcode.ActorControlSelf },
            { 0x0229, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x008F, MatchaOpcode.CompanyAirshipStatus },
            { 0x0228, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0214, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x033C, MatchaOpcode.ResumeEventScene32 }, // unk
            { 0x0250, MatchaOpcode.EventPlay },
            { 0x0076, MatchaOpcode.EventStart },
            { 0x00CE, MatchaOpcode.Examine },
            { 0x00EB, MatchaOpcode.FateInfo },
            { 0x012E, MatchaOpcode.InitZone },
            { 0x02DC, MatchaOpcode.InventoryTransaction }, // unk
            { 0x0215, MatchaOpcode.ItemInfo }, // unk
            { 0x0368, MatchaOpcode.MarketBoardItemListing },
            { 0x03BC, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0142, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x01EE, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x011E, MatchaOpcode.NpcSpawn },
            { 0x036F, MatchaOpcode.PlayerSetup },
            { 0x018B, MatchaOpcode.PlayerSpawn },
            { 0x01EE, MatchaOpcode.WorldVisitQueue },
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
