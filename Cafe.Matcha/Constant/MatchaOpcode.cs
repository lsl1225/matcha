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
    DirectorStart,
    EventPlay,
    Examine,
    FateInfo,
    InitZone,
    InventoryTransaction,
    ItemInfo,
    MarketBoardItemListing,
    MarketBoardItemListingCount,
    MarketBoardItemListingHistory,
    NpcSpawn,
    PlayerSetup,
    PlayerSpawn,
  }

  internal static class OpcodeStorage
  {
    public static Dictionary<ushort, MatchaOpcode> Global = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x0148, MatchaOpcode.ActorControl },
            { 0x025D, MatchaOpcode.ActorControlSelf },
            { 0x00D5, MatchaOpcode.CEDirector },
            /*
             * AirshipTimers & SubmarineTimers
             */
            { 0x0123, MatchaOpcode.CompanyAirshipStatus },
            { 0x0185, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0279, MatchaOpcode.ContentFinderNotifyPop },
            /*
             * MiniCactpotInit
             */
            { 0x00E2, MatchaOpcode.DirectorStart }, // unknown
            { 0x0155, MatchaOpcode.EventPlay },
            { 0x02C0, MatchaOpcode.Examine },
            { 0x007A, MatchaOpcode.FateInfo },
            { 0x02D1, MatchaOpcode.InitZone },
            { 0x02BD, MatchaOpcode.InventoryTransaction },
            { 0x02F0, MatchaOpcode.ItemInfo },
            { 0x03E3, MatchaOpcode.MarketBoardItemListing },
            { 0x0286, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0229, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x00A7, MatchaOpcode.NpcSpawn },
            { 0x035F, MatchaOpcode.PlayerSetup },
            { 0x039C, MatchaOpcode.PlayerSpawn },
        };
    public static Dictionary<ushort, MatchaOpcode> China = new Dictionary<ushort, MatchaOpcode>
        {
            { 0x030f, MatchaOpcode.ActorControl },
            { 0x01a2, MatchaOpcode.ActorControlSelf },
            { 0x0241, MatchaOpcode.CEDirector },
            { 0x0233, MatchaOpcode.CompanyAirshipStatus },
            { 0x02b6, MatchaOpcode.CompanySubmersibleStatus },
            { 0x0222, MatchaOpcode.ContentFinderNotifyPop },
            { 0x0101, MatchaOpcode.DirectorStart },
            { 0x00a3, MatchaOpcode.EventPlay },
            { 0x01ef, MatchaOpcode.Examine },
            { 0x0379, MatchaOpcode.FateInfo },
            { 0x0341, MatchaOpcode.InitZone },
            { 0x02c8, MatchaOpcode.InventoryTransaction },
            { 0x036d, MatchaOpcode.ItemInfo },
            { 0x01c9, MatchaOpcode.MarketBoardItemListing },
            { 0x01bf, MatchaOpcode.MarketBoardItemListingCount },
            { 0x0074, MatchaOpcode.MarketBoardItemListingHistory },
            { 0x01d7, MatchaOpcode.NpcSpawn },
            { 0x02c1, MatchaOpcode.PlayerSetup },
            { 0x031b, MatchaOpcode.PlayerSpawn },
        };
  }
}
