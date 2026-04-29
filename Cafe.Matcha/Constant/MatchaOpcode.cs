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
            { 0x0328, MatchaOpcode.ActorControl },
            { 0x03E7, MatchaOpcode.ActorControlSelf },
            { 0x02F1, MatchaOpcode.CEDirector },
            { 0x008F, MatchaOpcode.CompanyAirshipStatus },
            { 0x019C, MatchaOpcode.CompanySubmersibleStatus },
            { 0x025F, MatchaOpcode.ContentFinderNotifyPop },
            { 0x026D, MatchaOpcode.ResumeEventScene32 },
            { 0x03B9, MatchaOpcode.EventPlay },
            { 0x02C1, MatchaOpcode.EventStart },
            { 0x0100, MatchaOpcode.Examine },
            { 0x03B3, MatchaOpcode.FateInfo },
            { 0x0098, MatchaOpcode.InitZone },
            { 0x03DF, MatchaOpcode.InventoryTransaction },
            { 0x013B, MatchaOpcode.ItemInfo },
            { 0x036F, MatchaOpcode.MarketBoardItemListing },
            { 0x0342, MatchaOpcode.MarketBoardItemListingCount },
            { 0x020A, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x82EB, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x02AE, MatchaOpcode.NpcSpawn },
            { 0x0354, MatchaOpcode.PlayerSetup },
            { 0x0343, MatchaOpcode.PlayerSpawn },
            { 0x02EB, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0328, MatchaOpcode.ActorControl },
            { 0x03E7, MatchaOpcode.ActorControlSelf },
            { 0x02F1, MatchaOpcode.CEDirector },
            { 0x008F, MatchaOpcode.CompanyAirshipStatus },
            { 0x019C, MatchaOpcode.CompanySubmersibleStatus },
            { 0x025F, MatchaOpcode.ContentFinderNotifyPop },
            { 0x026D, MatchaOpcode.ResumeEventScene32 },
            { 0x03B9, MatchaOpcode.EventPlay },
            { 0x02C1, MatchaOpcode.EventStart },
            { 0x0100, MatchaOpcode.Examine },
            { 0x03B3, MatchaOpcode.FateInfo },
            { 0x0098, MatchaOpcode.InitZone },
            { 0x03DF, MatchaOpcode.InventoryTransaction },
            { 0x013B, MatchaOpcode.ItemInfo },
            { 0x036F, MatchaOpcode.MarketBoardItemListing },
            { 0x0342, MatchaOpcode.MarketBoardItemListingCount },
            { 0x020A, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x82EB, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x02AE, MatchaOpcode.NpcSpawn },
            { 0x0354, MatchaOpcode.PlayerSetup },
            { 0x0343, MatchaOpcode.PlayerSpawn },
            { 0x02EB, MatchaOpcode.WorldVisitQueue },
        };
    }
}
