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
            { 0x0189, MatchaOpcode.ResumeEventScene32 },
            { 0x0250, MatchaOpcode.EventPlay },
            { 0x0076, MatchaOpcode.EventStart },
            { 0x00CE, MatchaOpcode.Examine },
            { 0x00EB, MatchaOpcode.FateInfo },
            { 0x012E, MatchaOpcode.InitZone },
            { 0x035F, MatchaOpcode.InventoryTransaction },
            { 0x022C, MatchaOpcode.ItemInfo },
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
            { 0x019b, MatchaOpcode.ActorControl },
            { 0x0347, MatchaOpcode.ActorControlSelf },
            { 0x0305, MatchaOpcode.CEDirector },
            { 0x03d5, MatchaOpcode.CompanyAirshipStatus },
            { 0x0139, MatchaOpcode.CompanySubmersibleStatus },
            { 0x03a7, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0199, MatchaOpcode.ResumeEventScene32 },
            { 0x0332, MatchaOpcode.EventPlay },
            { 0x03da, MatchaOpcode.EventStart },
            { 0x0070, MatchaOpcode.Examine },
            { 0x038a, MatchaOpcode.FateInfo },
            { 0x0242, MatchaOpcode.InitZone },
            { 0x02b7, MatchaOpcode.InventoryTransaction },
            { 0x00eb, MatchaOpcode.ItemInfo },
            { 0x01ad, MatchaOpcode.MarketBoardItemListing },
            { 0x01d8, MatchaOpcode.MarketBoardItemListingCount },
            { 0x025c, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x836f, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x039b, MatchaOpcode.NpcSpawn },
            { 0x0256, MatchaOpcode.PlayerSetup },
            { 0x00ca, MatchaOpcode.PlayerSpawn },
            { 0x036f, MatchaOpcode.WorldVisitQueue },
        };
    }
}
