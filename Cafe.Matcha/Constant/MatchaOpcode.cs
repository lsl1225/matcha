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
        EventPlay4,
        SystemLogMessage,
        FishCaught,
        StatusEffectList,
        ClientTrigger,
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
            { 0x025F, MatchaOpcode.ActorControl },
            { 0x0204, MatchaOpcode.ActorControlSelf },
            { 0x031E, MatchaOpcode.CEDirector },
            { 0x006C, MatchaOpcode.CompanyAirshipStatus },
            { 0x01EC, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0333, MatchaOpcode.ContentFinderNotifyPop },
            { 0x024D, MatchaOpcode.ResumeEventScene32 },
            { 0x01FD, MatchaOpcode.EventPlay },
            { 0x02E1, MatchaOpcode.EventStart },
            { 0x01F2, MatchaOpcode.Examine },
            { 0x0154, MatchaOpcode.FateInfo },
            { 0x032B, MatchaOpcode.InitZone },
            { 0x023A, MatchaOpcode.InventoryTransaction },
            { 0x0084, MatchaOpcode.ItemInfo },
            { 0x034D, MatchaOpcode.MarketBoardItemListing },
            { 0x00C0, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0241, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8320, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x020C, MatchaOpcode.NpcSpawn },
            { 0x0093, MatchaOpcode.PlayerSetup },
            { 0x01C4, MatchaOpcode.PlayerSpawn },
            { 0x038A, MatchaOpcode.SubmarineStatusList },
            { 0x01E8, MatchaOpcode.WorldVisitQueue },
            { 0x01c6, MatchaOpcode.EventPlay4 },
            { 0x00a8, MatchaOpcode.SystemLogMessage },
            { 0x0110, MatchaOpcode.FishCaught },
            { 0x0083, MatchaOpcode.StatusEffectList },
            { 0x8187, MatchaOpcode.ClientTrigger },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x025F, MatchaOpcode.ActorControl },
            { 0x0204, MatchaOpcode.ActorControlSelf },
            { 0x031E, MatchaOpcode.CEDirector },
            { 0x006C, MatchaOpcode.CompanyAirshipStatus },
            { 0x01EC, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0333, MatchaOpcode.ContentFinderNotifyPop },
            { 0x024D, MatchaOpcode.ResumeEventScene32 },
            { 0x01FD, MatchaOpcode.EventPlay },
            { 0x02E1, MatchaOpcode.EventStart },
            { 0x01F2, MatchaOpcode.Examine },
            { 0x0154, MatchaOpcode.FateInfo },
            { 0x032B, MatchaOpcode.InitZone },
            { 0x023A, MatchaOpcode.InventoryTransaction },
            { 0x0084, MatchaOpcode.ItemInfo },
            { 0x034D, MatchaOpcode.MarketBoardItemListing },
            { 0x00C0, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0241, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8320, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x020C, MatchaOpcode.NpcSpawn },
            { 0x0093, MatchaOpcode.PlayerSetup },
            { 0x01C4, MatchaOpcode.PlayerSpawn },
            { 0x038A, MatchaOpcode.SubmarineStatusList },
            { 0x01E8, MatchaOpcode.WorldVisitQueue },
            { 0x01c6, MatchaOpcode.EventPlay4 },
            { 0x00a8, MatchaOpcode.SystemLogMessage },
            { 0x0110, MatchaOpcode.FishCaught },
            { 0x0083, MatchaOpcode.StatusEffectList },
            { 0x8187, MatchaOpcode.ClientTrigger },
        };
    }
}
