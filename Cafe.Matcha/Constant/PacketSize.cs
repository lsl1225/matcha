// Copyright (c) FFCafe. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.

namespace Cafe.Matcha.Constant
{
    public class PacketSize
    {
        public const int ResumeEventScene32 = 168;
        public const int NpcSpawn = 688; // 7.2 Fix (original: 680)
        public const int ActorControl = 56;
        public const int FateInfo = 56;
        public const int ActorControlSelf = 64;
        public const int ContentFinderNotifyPop = 72;
        public const int CompanyAirshipStatus = 176;
        public const int CompanySubmersibleStatus = 176;
        public const int InitZone = 144;
        public const int EventPlay = 72;
        public const int MarketBoardItemListingCount = 40;
        public const int MarketBoardItemListing = 1480;
        public const int ItemInfo = 96;
        public const int InventoryTransaction = 80;
        public const int Examine = 976;
        // 挖宝的数据包大小是 ActorControl -> EObjAnimation
        public const int TreasureShiftingWheel = ActorControl;
        public const int TreasureResult = ActorControlSelf;
    }
}
