// Copyright (c) FFCafe. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.

namespace Cafe.Matcha.Constant
{
    internal enum ActorControlType : ushort
    {
        /*! Toggles weapon status -> Sheathed/UnSheathed
            \param param1 status 0|1 */
        ToggleWeapon = 0,
        /*! Toggles Autoattack status on/off
                \param param1 status 0|1 */
        AutoAttack = 1,
        SetStatus = 2,
        CastStart = 3,
        ToggleAggro = 4,
        ClassJobChange = 5,
        DefeatMsg = 6,
        GainExpMsg = 7,
        LevelUpEffect = 10,
        ExpChainMsg = 12,
        HpSetStat = 13,
        DeathAnimation = 14,
        CastInterrupt = 15,
        /*!
         * @brief Sent when a player uses an action
         *
         * param1 Seems to be always 1 from what I've seen, needs more research
         * param2 The actionid
         * param3 The action cooldown in ms / 10
         */
        ActionStart = 17,
        StatusEffectGain = 20,
        StatusEffectLose = 21,
        HPFloatingText = 23,
        UpdateRestedExp = 24,
        Unk2 = 25,
        Flee = 27,
        Unk3 = 32,
        CombatIndicationShow = 34,
        SpawnEffect = 37,
        ToggleInvisible = 38,
        ToggleActionUnlock = 41,
        UpdateUiExp = 43,
        DmgTakenMsg = 45,
        SetTarget = 50,
        ToggleNameHidden = 54,
        LimitbreakStart = 71,
        LimitbreakPartyStart = 72,
        BubbleText = 73,
        DamageEffect = 80,
        RaiseAnimation = 81,
        TreasureSpot = 84,
        TreasureScreenMsg = 87,
        SetOwnerId = 89,
        ItemRepairMsg = 92,
        BluActionLearn = 99,
        DirectorInit = 100,
        DirectorClear = 101,
        LeveStartAnim = 102,
        LeveStartError = 103,
        DirectorEObjMod = 106,
        DirectorUpdate = 109,
        ItemObtainMsg = 117,
        DutyQuestScreenMsg = 123,
        ItemObtainIcon = 132,
        FateItemFailMsg = 133,
        ItemFailMsg = 134,
        ActionLearnMsg1 = 135,
        FreeEventPos = 138,
        DailyQuestSeed = 144,
        SetBGM = 161,
        UnlockAetherCurrentMsg = 164,
        RemoveName = 168,
        ScreenFadeOut = 170,
        ZoneIn = 200,
        ZoneInDefaultPos = 201,
        TeleportStart = 203,
        TeleportDone = 205,
        TeleportDoneFadeOut = 206,
        DespawnZoneScreenMsg = 207,
        InstanceSelectDlg = 210,
        ActorDespawnEffect = 212,
        CompanionUnlock = 253,
        ObtainBarding = 254,
        EquipBarding = 255,
        CompanionMsg1 = 258,
        CompanionMsg2 = 259,
        ShowPetHotbar = 260,
        ActionLearnMsg = 265,
        ActorFadeOut = 266,
        ActorFadeIn = 267,
        WithdrawMsg = 268,
        OrderCompanion = 269,
        ToggleCompanion = 270,
        LearnCompanion = 271,
        ActorFateOut1 = 272,
        Emote = 290,
        EmoteInterrupt = 291,
        SetPose = 295,
        CraftingUnk = 300,
        GatheringSenseMsg = 304,
        PartyMsg = 305,
        GatheringSenseMsg1 = 306,
        GatheringSenseMsg2 = 312,
        FishingMsg = 320,
        FishingTotalFishCaught = 322,
        // FishingBaitMsg
        FishingBaitChange = 325,
        FishingReachMsg = 327,
        FishingFailMsg = 328,
        MateriaConvertMsg = 350,
        MeldSuccessMsg = 351,
        MeldFailMsg = 352,
        MeldModeToggle = 353,
        AetherRestoreMsg = 355,
        DyeMsg = 360,
        ToggleCrestMsg = 362,
        ToggleBulkCrestMsg = 363,
        MateriaRemoveMsg = 364,
        GlamourCastMsg = 365,
        GlamourRemoveMsg = 366,
        RelicInfuseMsg = 377,
        AetherReductionDlg = 381,
        HypnoslotResult = 407,
        /*!
         * param1 = state
         * param2 = actorid
         */
        EObjSetState = 409,
        Unk6 = 412,
        EObjAnimation = 413,
        SetTitle = 500,
        SetStatusIcon = 504,
        LimitBreakGauge = 505,
        SetHomepoint = 507,
        SetFavorite = 508,
        LearnTeleport = 509,
        OpenRecommendationGuide = 512,
        ArmoryErrorMsg = 513,
        AchievementPopup = 515,
        LogMsg = 517,
        AchievementMsg = 518,
        SetItemLevel = 521,
        ChallengeEntryCompleteMsg = 523,
        ChallengeEntryUnlockMsg = 524,
        /*!
         * Sent when a player desynths an item, one packet per result type (one for consumed item, one for each obtained items, and one for exp if the player received exp)
         * param1 = result type (4921 => Item consumed, 4922 => Item obtained, 4925 => Exp obtained)
         * param3 = item id (used for result types 4921 & 4922)
         * param5 = exp amount (x 100)
         */
        DesynthOrReductionResult = 527,
        GilTrailMsg = 529,
        HuntingLogRankUnlock = 541,
        HuntingLogEntryUpdate = 542,
        HuntingLogSectionFinish = 543,
        HuntingLogRankFinish = 544,
        SetMaxGearSets = 560,
        SetCharaGearParamUI = 608,
        ToggleWireframeRendering = 609,
        ExamineError = 703,
        GearSetEquipMsg = 801,
        SetBait = 805,
        SetFestival = 902,
        ToggleOrchestrionUnlock = 918,
        /*!
         * param1 = mountSpeed
         * Retail sends 12 for mount speed star 1 unlocked and 15 for mount speed star 2 unlocked
         * This also has to be sent before mounting finishes for it to take effect
         */
        SetMountSpeed = 927,
        Dismount = 929,
        BeginReplayAck = 930,
        EndReplayAck = 931,
        ShowHousingItemUI = 1015,
        ShowBuildPresetUI = 1001,
        /*!
         * param1 = plot id
         */
        ShowEstateExternalAppearanceUI = 1002,
        ShowEstateInternalAppearanceUI = 1003,
        BuildPresetResponse = 1005,
        /*!
         * param1 = u16 landid
         *          u16 slotid
         */
        RemoveExteriorHousingItem = 1007,
        /*!
         * param1 = object array index
         */
        RemoveInteriorHousingItem = 1009,
        /*!
         * param1 = identity shit
         *          u16 1 - container id
         *          u16 2 - plot id
         * param2 = item shit
         *          u16 1 - slot
         */
        HousingItemMoveConfirm = 1017,
        OpenEstateSettingsUI = 1023,
        HideAdditionalChambersDoor = 1024,
        /*!
         * param1 = outdoor furnishings
         *          u8 0 - relocation available, 1 = available
         *          u8 1 - outoor furnishings placed
         *          u8 2 - outdoor furnishings in storeroom
         *          u8 3 - outdoor funishings limit
         * param2 = indoor furnishings
         *          u16 0 - relocation available, 1 = available
         *          u16 1 - furnishings placed
         * param3 = indoor furnishings
         *          u16 0 - in storeroom
         *          u16 1 - indoor furnishings limit
         */
        HousingStoreroomStatus = 1049,
        SetPvPState = 1504,
        EndDuelSession = 1505,
        StartDuelCountdown = 1506,
        StartDuel = 1507,
        DuelResultScreen = 1508,
        SetDutyActionId = 1512,
        SetDutyActionHud = 1513,
        SetDutyActionActive = 1514,
        SetDutyActionRemaining = 1515,
        EurekaStep = 1850,
        FateStart = 2370,
        FateEnd = 2357,
        FateProgress = 2364
    }
}
