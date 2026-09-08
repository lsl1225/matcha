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
         * ResumeEventScene32 -> MiniCactpotInit (GROUP_EventResume)
         */
        public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x038C, MatchaOpcode.ActorControl },
            { 0x0258, MatchaOpcode.ActorControlSelf },
            { 0x0393, MatchaOpcode.CEDirector },
            { 0x02F8, MatchaOpcode.CompanyAirshipStatus },
            { 0x0222, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0080, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0335, MatchaOpcode.ResumeEventScene32 },
            { 0x01F1, MatchaOpcode.EventPlay },
            { 0x00F2, MatchaOpcode.EventStart },
            { 0x0069, MatchaOpcode.Examine },
            { 0x0106, MatchaOpcode.FateInfo },
            { 0x03A1, MatchaOpcode.InitZone },
            { 0x024E, MatchaOpcode.InventoryTransaction },
            { 0x0073, MatchaOpcode.ItemInfo },
            { 0x027B, MatchaOpcode.MarketBoardItemListing },
            { 0x0324, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02FE, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x025D, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x01C4, MatchaOpcode.NpcSpawn },
            { 0x01DD, MatchaOpcode.PlayerSetup },
            { 0x03B2, MatchaOpcode.PlayerSpawn },
            { 0x01A9, MatchaOpcode.SubmarineStatusList },
            { 0x0110, MatchaOpcode.WorldVisitQueue },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x038C, MatchaOpcode.ActorControl },
            { 0x0258, MatchaOpcode.ActorControlSelf },
            { 0x0393, MatchaOpcode.CEDirector },
            { 0x02F8, MatchaOpcode.CompanyAirshipStatus },
            { 0x0222, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0080, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0335, MatchaOpcode.ResumeEventScene32 },
            { 0x01F1, MatchaOpcode.EventPlay },
            { 0x00F2, MatchaOpcode.EventStart },
            { 0x0069, MatchaOpcode.Examine },
            { 0x0106, MatchaOpcode.FateInfo },
            { 0x03A1, MatchaOpcode.InitZone },
            { 0x024E, MatchaOpcode.InventoryTransaction },
            { 0x0073, MatchaOpcode.ItemInfo },
            { 0x027B, MatchaOpcode.MarketBoardItemListing },
            { 0x0324, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02FE, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x025D, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x01C4, MatchaOpcode.NpcSpawn },
            { 0x01DD, MatchaOpcode.PlayerSetup },
            { 0x03B2, MatchaOpcode.PlayerSpawn },
            { 0x01A9, MatchaOpcode.SubmarineStatusList },
            { 0x0110, MatchaOpcode.WorldVisitQueue },
        };
    }
}
