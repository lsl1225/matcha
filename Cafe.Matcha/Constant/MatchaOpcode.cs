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
        UpdateInventorySlot,
        Logout,
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
            { 0x0229, MatchaOpcode.ActorControl },
            { 0x0101, MatchaOpcode.ActorControlSelf },
            { 0x034F, MatchaOpcode.CEDirector },
            { 0x032E, MatchaOpcode.CompanyAirshipStatus },
            { 0x011A, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0117, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0146, MatchaOpcode.ResumeEventScene32 },
            { 0x00B4, MatchaOpcode.EventPlay },
            { 0x0078, MatchaOpcode.EventStart },
            { 0x019E, MatchaOpcode.Examine },
            { 0x0310, MatchaOpcode.FateInfo },
            { 0x009C, MatchaOpcode.InitZone },
            { 0x01C9, MatchaOpcode.InventoryTransaction },
            { 0x0239, MatchaOpcode.ItemInfo },
            { 0x0131, MatchaOpcode.MarketBoardItemListing },
            { 0x00FF, MatchaOpcode.MarketBoardItemListingCount },
            { 0x02DA, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x80F2, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x017D, MatchaOpcode.NpcSpawn },
            { 0x02A6, MatchaOpcode.PlayerSetup },
            { 0x017C, MatchaOpcode.PlayerSpawn },
            { 0x0166, MatchaOpcode.SubmarineStatusList },
            { 0x02D8, MatchaOpcode.WorldVisitQueue },
            { 0x0081, MatchaOpcode.EventPlay4 },
            { 0x0250, MatchaOpcode.SystemLogMessage },
            { 0x006A, MatchaOpcode.FishCaught },
            { 0x00D4, MatchaOpcode.StatusEffectList },
            { 0x837D, MatchaOpcode.ClientTrigger },
            { 0x038D, MatchaOpcode.UpdateInventorySlot },
            { 0x00DE, MatchaOpcode.Logout },
        };
        public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0198, MatchaOpcode.ActorControl },
            { 0x01e6, MatchaOpcode.ActorControlSelf },
            { 0x020a, MatchaOpcode.CEDirector },
            { 0x0178, MatchaOpcode.CompanyAirshipStatus },
            { 0x039c, MatchaOpcode.CompanySubmersibleStatus },
            { 0x028a, MatchaOpcode.ContentFinderNotifyPop },
            { 0x01fe, MatchaOpcode.ResumeEventScene32 },
            { 0x0256, MatchaOpcode.EventPlay },
            { 0x0286, MatchaOpcode.EventStart },
            { 0x019c, MatchaOpcode.Examine },
            { 0x0259, MatchaOpcode.FateInfo },
            { 0x02cc, MatchaOpcode.InitZone },
            { 0x032d, MatchaOpcode.InventoryTransaction },
            { 0x00d1, MatchaOpcode.ItemInfo },
            { 0x0234, MatchaOpcode.MarketBoardItemListing },
            { 0x010d, MatchaOpcode.MarketBoardItemListingCount },
            { 0x011e, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x8248, MatchaOpcode.MarketBoardRequestItemListingInfo },
            { 0x0114, MatchaOpcode.NpcSpawn },
            { 0x0302, MatchaOpcode.PlayerSetup },
            { 0x0265, MatchaOpcode.PlayerSpawn },
            { 0x0367, MatchaOpcode.SubmarineStatusList },
            { 0x007c, MatchaOpcode.WorldVisitQueue },
            { 0x0324, MatchaOpcode.EventPlay4 },
            { 0x00eb, MatchaOpcode.SystemLogMessage },
            { 0x03cb, MatchaOpcode.FishCaught },
            { 0x02ce, MatchaOpcode.StatusEffectList },
            { 0x8368, MatchaOpcode.ClientTrigger },
            { 0x02a3, MatchaOpcode.UpdateInventorySlot },
            { 0x030d, MatchaOpcode.Logout },
        };
    }
}
