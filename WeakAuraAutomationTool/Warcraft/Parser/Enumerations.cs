﻿using System;
using System.Collections.Generic;
using System.Text;

// ReSharper disable UnusedMember.Global

namespace WeakAuraAutomationTool.Warcraft.Parser
{
    internal enum SpellEffectName
    {
        Instakill = 1,
        SchoolDamage = 2,
        Dummy = 3,
        PortalTeleport = 4,
        TeleportUnitsOld = 5,
        ApplyAura = 6,
        EnvironmentalDamage = 7,
        PowerDrain = 8,
        HealthLeech = 9,
        Heal = 10,
        Bind = 11,
        Portal = 12,
        RitualBase = 13,
        IncreaseCurrencyCap = 14,
        RitualActivatePortal = 15,
        QuestComplete = 16,
        WeaponDamageNoSchool = 17,
        Resurrect = 18,
        AddExtraAttacks = 19,
        Dodge = 20,
        Evade = 21,
        Parry = 22,
        Block = 23,
        CreateItem = 24,
        Weapon = 25,
        Defense = 26,
        PersistentAreaAura = 27,
        Summon = 28,
        Leap = 29,
        Energize = 30,
        WeaponPercentDamage = 31,
        TriggerMissile = 32,
        OpenLock = 33,
        SummonChangeItem = 34,
        ApplyAreaAuraParty = 35,
        LearnSpell = 36,
        SpellDefense = 37,
        Dispel = 38,
        Language = 39,
        DualWield = 40,
        Jump = 41,
        JumpDest = 42,
        TeleportUnitsFaceCaster = 43,
        SkillStep = 44,
        PlayMovie = 45,
        Spawn = 46,
        TradeSkill = 47,
        Stealth = 48,
        Detect = 49,
        TransDoor = 50,
        ForceCriticalHit = 51,
        SetMaxBattlePetCount = 52,
        EnchantItem = 53,
        EnchantItemTemporary = 54,
        Tamecreature = 55,
        SummonPet = 56,
        LearnPetSpell = 57,
        WeaponDamage = 58,
        CreateRandomItem = 59,
        Proficiency = 60,
        SendEvent = 61,
        PowerBurn = 62,
        Threat = 63,
        TriggerSpell = 64,
        ApplyAreaAuraRaid = 65,
        RechargeItem = 66,
        HealMaxHealth = 67,
        InterruptCast = 68,
        Distract = 69,
        Pull = 70,
        Pickpocket = 71,
        AddFarsight = 72,
        UntrainTalents = 73,
        ApplyGlyph = 74,
        HealMechanical = 75,
        SummonObjectWild = 76,
        ScriptEffect = 77,
        Attack = 78,
        Sanctuary = 79,
        AddComboPoints = 80,
        PushAbilityToActionBar = 81,
        BindSight = 82,
        Duel = 83,
        Stuck = 84,
        SummonPlayer = 85,
        ActivateObject = 86,
        GameObjectDamage = 87,
        GameObjectRepair = 88,
        GameObjectSetDestructionState = 89,
        KillCredit = 90,
        ThreatAll = 91,
        EnchantHeldItem = 92,
        ForceDeselect = 93,
        SelfResurrect = 94,
        Skinning = 95,
        Charge = 96,
        CastButton = 97,
        KnockBack = 98,
        Disenchant = 99,
        Inebriate = 100,
        FeedPet = 101,
        DismissPet = 102,
        Reputation = 103,
        SummonObjectSlot1 = 104,
        Survey = 105,
        ChangeRaidMarker = 106,
        ShowCorpseLoot = 107,
        DispelMechanic = 108,
        ResurrectPet = 109,
        DestroyAllTotems = 110,
        DurabilityDamage = 111,
        AttackMe = 114,
        DurabilityDamagePct = 115,
        SkinPlayerCorpse = 116,
        SpiritHeal = 117,
        Skill = 118,
        ApplyAreaAuraPet = 119,
        TeleportGraveyard = 120,
        NormalizedWeaponDmg = 121,
        SendTaxi = 123,
        PullTowards = 124,
        ModifyThreatPercent = 125,
        StealBeneficialBuff = 126,
        Prospecting = 127,
        ApplyAreaAuraFriend = 128,
        ApplyAreaAuraEnemy = 129,
        RedirectThreat = 130,
        PlaySound = 131,
        PlayMusic = 132,
        UnlearnSpecialization = 133,
        KillCredit2 = 134,
        CallPet = 135,
        HealPct = 136,
        EnergizePct = 137,
        LeapBack = 138,
        ClearQuest = 139,
        ForceCast = 140,
        ForceCastWithValue = 141,
        TriggerSpellWithValue = 142,
        ApplyAreaAuraOwner = 143,
        KnockBackDest = 144,
        PullTowardsDest = 145,
        ActivateRune = 146,
        QuestFail = 147,
        TriggerMissileSpellWithValue = 148,
        ChargeDest = 149,
        QuestStart = 150,
        TriggerSpell2 = 151,
        SummonRafFriend = 152,
        CreateTamedPet = 153,
        DiscoverTaxi = 154,
        TitanGrip = 155,
        EnchantItemPrismatic = 156,
        CreateLoot = 157,
        Milling = 158,
        AllowRenamePet = 159,
        ForceCast2 = 160,
        TalentSpecCount = 161,
        TalentSpecSelect = 162,
        ObliterateItem = 163,
        RemoveAura = 164,
        DamageFromMaxHealthPct = 165,
        GiveCurrency = 166,
        UpdatePlayerPhase = 167,
        AllowControlPet = 168,
        DestroyItem = 169,
        UpdateZoneAurasAndPhases = 170,
        ResurrectWithAura = 172,
        UnlockGuildVaultTab = 173,
        ApplyAuraOnPet = 174,
        Sanctuary2 = 176,
        CreateAreaTrigger = 179,
        UpdateAreaTrigger = 180,
        RemoveTalent = 181,
        DespawnAreaTrigger = 182,
        Reputation2 = 184,
        RandomizeArchaeologyDigSites = 187,
        Loot = 189,
        TeleportToDigsite = 191,
        UncageBattlePet = 192,
        StartPetBattle = 193,
        PlayScene = 198,
        HealBattlePetPct = 200,
        EnableBattlePets = 201,
        ApplyAuraOn = 202,
        ChangeBattlePetQuality = 204,
        LaunchQuestChoice = 205,
        AlterItem = 206,
        LaunchQuestTask = 207,
        LearnGarrisonBuilding = 210,
        LearnGarrisonSpecialization = 211,
        CreateGarrison = 214,
        UpgradeCharacterSpells = 215,
        CreateShipment = 216,
        UpgradeGarrison = 217,
        CreateConversation = 219,
        AddGarrisonFollower = 220,
        CreateHeirloomItem = 222,
        ChangeItemBonuses = 223,
        ActivateGarrisonBuilding = 224,
        GrantBattlePetLevel = 225,
        TeleportToLfgDungeon = 227,
        SetFollowerQuality = 229,
        IncreaseFollowerItemLevel = 230,
        IncreaseFollowerExperience = 231,
        RemovePhase = 232,
        RandomizeFollowerAbilities = 233,
        GiveExperience = 236,
        GiveRestedExperienceBonus = 237,
        IncreaseSkill = 238,
        EndGarrisonBuildingConstruction = 239,
        GiveArtifactPower = 240,
        GiveArtifactPowerNoBonus = 242,
        ApplyEnchantIllusion = 243,
        LearnFollowerAbility = 244,
        UpgradeHeirloom = 245,
        FinishGarrisonMission = 246,
        AddGarrisonMission = 247,
        FinishShipment = 248,
        ForceEquipItem = 249,
        TakeScreenshot = 250,
        SetGarrisonCacheSize = 251,
        TeleportUnits = 252,
        GiveHonor = 253,
        LearnTransmogSet = 255,
        ModifyKeystone = 258,
        RespecAzeriteEmpoweredItem = 259,
        SummonStabledPet = 260,
        ScrapItem = 261,
        RepairItem = 263,
        RemoveGem = 264,
        LearnAzeriteEssencePower = 265,
        ApplyMountEquipment = 268,
        UpgradeItem = 269,
        ApplyAreaAuraPartyNonrandom = 271,
        ItemSpellSomething = 276,
        CovenantGarrTalent = 279,
    }

    internal enum EffectAuraType
    {
        None = 0,
        BindSight = 1,
        ModPossess = 2,
        PeriodicDamage = 3,
        Dummy = 4,
        ModConfuse = 5,
        ModCharm = 6,
        ModFear = 7,
        PeriodicHeal = 8,
        ModAttackSpeed = 9,
        ModThreat = 10,
        ModTaunt = 11,
        ModStun = 12,
        ModDamageDone = 13,
        ModDamageTaken = 14,
        DamageShield = 15,
        ModStealth = 16,
        ModStealthDetect = 17,
        ModInvisibility = 18,
        ModInvisibilityDetect = 19,
        ObsModHealth = 20,
        ObsModPower = 21,
        ModResistance = 22,
        PeriodicTriggerSpell = 23,
        PeriodicEnergize = 24,
        ModPacify = 25,
        ModRoot = 26,
        ModSilence = 27,
        ReflectSpells = 28,
        ModStat = 29,
        ModSkill = 30,
        ModIncreaseSpeed = 31,
        ModIncreaseMountedSpeed = 32,
        ModDecreaseSpeed = 33,
        ModIncreaseHealth = 34,
        ModIncreaseEnergy = 35,
        ModShapeshift = 36,
        EffectImmunity = 37,
        StateImmunity = 38,
        SchoolImmunity = 39,
        DamageImmunity = 40,
        DispelImmunity = 41,
        ProcTriggerSpell = 42,
        ProcTriggerDamage = 43,
        TrackCreatures = 44,
        TrackResources = 45,
        ModParryPercent = 47,
        ModDodgePercent = 49,
        ModCriticalHealingAmount = 50,
        ModBlockPercent = 51,
        ModWeaponCritPercent = 52,
        PeriodicLeech = 53,
        ModHitChance = 54,
        ModSpellHitChance = 55,
        Transform = 56,
        ModSpellCritChance = 57,
        ModIncreaseSwimSpeed = 58,
        ModDamageDoneCreature = 59,
        ModPacifySilence = 60,
        ModScale = 61,
        PeriodicHealthFunnel = 62,
        ModAdditionalPowerCost = 63,
        PeriodicManaLeech = 64,
        ModCastingSpeedNotStack = 65,
        FeignDeath = 66,
        ModDisarm = 67,
        ModStalked = 68,
        SchoolAbsorb = 69,
        ExtraAttacks = 70,
        ModSpellCritChanceSchool = 71,
        ModPowerCostSchoolPct = 72,
        ModPowerCostSchool = 73,
        ReflectSpellsSchool = 74,
        ModLanguage = 75,
        FarSight = 76,
        MechanicImmunity = 77,
        Mounted = 78,
        ModDamagePercentDone = 79,
        ModPercentStat = 80,
        SplitDamagePct = 81,
        WaterBreathing = 82,
        ModBaseResistance = 83,
        ModRegen = 84,
        ModPowerRegen = 85,
        ChannelDeathItem = 86,
        ModDamagePercentTaken = 87,
        ModHealthRegenPercent = 88,
        PeriodicDamagePercent = 89,
        ModDetectRange = 91,
        PreventsFleeing = 92,
        ModUnattackable = 93,
        InterruptRegen = 94,
        Ghost = 95,
        SpellMagnet = 96,
        ManaShield = 97,
        ModSkillTalent = 98,
        ModAttackPower = 99,
        AurasVisible = 100,
        ModResistancePct = 101,
        ModMeleeAttackPowerVersus = 102,
        ModTotalThreat = 103,
        WaterWalk = 104,
        FeatherFall = 105,
        Hover = 106,
        AddFlatModifier = 107,
        AddPctModifier = 108,
        AddTargetTrigger = 109,
        ModPowerRegenPercent = 110,
        AddCasterHitTrigger = 111,
        OverrideClassScripts = 112,
        ModRangedDamageTaken = 113,
        ModRangedDamageTakenPct = 114,
        ModHealing = 115,
        ModRegenDuringCombat = 116,
        ModMechanicResistance = 117,
        ModHealingPct = 118,
        PvpTalents = 119,
        Untrackable = 120,
        Empathy = 121,
        ModOffhandDamagePct = 122,
        ModTargetResistance = 123,
        ModRangedAttackPower = 124,
        ModMeleeDamageTaken = 125,
        ModMeleeDamageTakenPct = 126,
        RangedAttackPowerAttackerBonus = 127,
        ModPossessPet = 128,
        ModSpeedAlways = 129,
        ModMountedSpeedAlways = 130,
        ModRangedAttackPowerVersus = 131,
        ModIncreaseEnergyPercent = 132,
        ModIncreaseHealthPercent = 133,
        ModManaRegenInterrupt = 134,
        ModHealingDone = 135,
        ModHealingDonePercent = 136,
        ModTotalStatPercentage = 137,
        ModMeleeHaste = 138,
        ForceReaction = 139,
        ModRangedHaste = 140,
        ModBaseResistancePct = 142,
        ModResistanceExclusive = 143,
        SafeFall = 144,
        ModPetTalentPoints = 145,
        AllowTamePetType = 146,
        MechanicImmunityMask = 147,
        RetainComboPoints = 148,
        ReducePushback = 149,
        ModShieldBlockValuePct = 150,
        TrackStealthed = 151,
        ModDetectedRange = 152,
        ModStealthLevel = 154,
        ModWaterBreathing = 155,
        ModReputationGain = 156,
        PetDamageMulti = 157,
        ModShieldBlockValue = 158,
        NoPvpCredit = 159,
        ModHealthRegenInCombat = 161,
        PowerBurn = 162,
        ModCritDamageBonus = 163,
        MeleeAttackPowerAttackerBonus = 165,
        ModAttackPowerPct = 166,
        ModRangedAttackPowerPct = 167,
        ModDamageDoneVersus = 168,
        DetectAmore = 170,
        ModSpeedNotStack = 171,
        ModMountedSpeedNotStack = 172,
        ModSpellDamageOfStatPercent = 174,
        ModSpellHealingOfStatPercent = 175,
        SpiritOfRedemption = 176,
        AoeCharm = 177,
        ModAttackerSpellCritChance = 179,
        ModFlatSpellDamageVersus = 180,
        ModResistanceOfStatPercent = 182,
        ModCriticalThreat = 183,
        ModAttackerMeleeHitChance = 184,
        ModAttackerRangedHitChance = 185,
        ModAttackerSpellHitChance = 186,
        ModAttackerMeleeCritChance = 187,
        ModAttackerRangedCritChance = 188,
        ModRating = 189,
        ModFactionReputationGain = 190,
        UseNormalMovementSpeed = 191,
        ModMeleeRangedHaste = 192,
        MeleeSlow = 193,
        ModTargetAbsorbSchool = 194,
        ModTargetAbilityAbsorbSchool = 195,
        ModCooldown = 196,
        ModAttackerSpellAndWeaponCritChance = 197,
        ModXpPct = 200,
        Fly = 201,
        IgnoreCombatResult = 202,
        ModAttackerMeleeCritDamage = 203,
        ModAttackerRangedCritDamage = 204,
        ModSchoolCritDmgTaken = 205,
        ModIncreaseVehicleFlightSpeed = 206,
        ModIncreaseMountedFlightSpeed = 207,
        ModIncreaseFlightSpeed = 208,
        ModMountedFlightSpeedAlways = 209,
        ModVehicleSpeedAlways = 210,
        ModFlightSpeedNotStack = 211,
        ModRageFromDamageDealt = 213,
        ArenaPreparation = 215,
        HasteSpells = 216,
        ModMeleeHaste2 = 217,
        HasteRanged = 218,
        ModManaRegenFromStat = 219,
        ModRatingFromStat = 220,
        ModDetaunt = 221,
        RaidProcFromCharge = 223,
        GainTalent = 224,
        RaidProcFromChargeWithValue = 225,
        PeriodicDummy = 226,
        PeriodicTriggerSpellWithValue = 227,
        DetectStealth = 228,
        ModAoeDamageAvoidance = 229,
        ModMaxHealth = 230,
        ProcTriggerSpellWithValue = 231,
        MechanicDurationMod = 232,
        ChangeModelForAllHumanoids = 233,
        MechanicDurationModNotStack = 234,
        ModDispelResist = 235,
        ControlVehicle = 236,
        ModSpellDamageOfAttackPower = 237,
        ModSpellHealingOfAttackPower = 238,
        ModScale2 = 239,
        ModExpertise = 240,
        ForceMoveForward = 241,
        ModSpellDamageFromHealing = 242,
        ModFaction = 243,
        ComprehendLanguage = 244,
        ModAuraDurationByDispel = 245,
        ModAuraDurationByDispelNotStack = 246,
        CloneCaster = 247,
        ModCombatResultChance = 248,
        ConvertRune = 249,
        ModIncreaseHealth2 = 250,
        ModEnemyDodge = 251,
        ModSpeedSlowAll = 252,
        ModBlockCritChance = 253,
        ModDisarmOffhand = 254,
        ModMechanicDamageTakenPercent = 255,
        NoReagentUse = 256,
        ModTargetResistBySpellClass = 257,
        OverrideSummonedObject = 258,
        ScreenEffect = 260,
        Phase = 261,
        AbilityIgnoreAuraState = 262,
        AllowOnlyAbility = 263,
        ModImmuneAuraApplySchool = 267,
        ModIgnoreTargetResist = 269,
        SchoolMaskDamageFromCaster = 270,
        ModSpellDamageFromCaster = 271,
        IgnoreMeleeReset = 272,
        XRay = 273,
        ModIgnoreShapeshift = 275,
        ModDamageDoneForMechanic = 276,
        ModDisarmRanged = 278,
        InitializeImages = 279,
        ModHonorGainPct = 281,
        ModBaseHealthPct = 282,
        ModHealingReceived = 283,
        Linked = 284,
        ModAttackPowerOfArmor = 285,
        AbilityPeriodicCrit = 286,
        DeflectSpells = 287,
        IgnoreHitDirection = 288,
        PreventDurabilityLoss = 289,
        ModCritPct = 290,
        ModXpQuestPct = 291,
        OpenStable = 292,
        OverrideSpells = 293,
        PreventRegeneratePower = 294,
        SetVehicleId = 296,
        BlockSpellFamily = 297,
        Strangulate = 298,
        ShareDamagePct = 300,
        SchoolHealAbsorb = 301,
        ModDamageDoneVersusAuraState = 303,
        ModFakeInebriate = 304,
        ModMinimumSpeed = 305,
        HealAbsorbTest = 307,
        ModCritChanceForCaster = 308,
        ModResilience = 309,
        ModCreatureAoeDamageAvoidance = 310,
        AnimReplacementSet = 312,
        PreventResurrection = 314,
        UnderwaterWalking = 315,
        PeriodicHaste = 316,
        ModSpellPowerPct = 317,
        Mastery = 318,
        ModMeleeHaste3 = 319,
        ModRangedHaste2 = 320,
        ModNoActions = 321,
        InterfereTargetting = 322,
        LearnPvpTalent = 325,
        PhaseGroup = 326,
        ProcOnPowerAmount = 328,
        ModRuneRegenSpeed = 329,
        CastWhileWalking = 330,
        ForceWeather = 331,
        OverrideActionbarSpells = 332,
        OverrideActionbarSpellsTriggered = 333,
        ModBlind = 334,
        ModFlyingRestrictions = 336,
        ModVendorItemsPrices = 337,
        ModDurabilityLoss = 338,
        IncreaseSkillGainChance = 339,
        ModResurrectedHealthByGuildMember = 340,
        ModSpellCategoryCooldown = 341,
        ModMeleeRangedHaste2 = 342,
        ModMeleeDamageFromCaster = 343,
        ModAutoattackDamage = 344,
        BypassArmorForCaster = 345,
        EnableAltPower = 346,
        ModSpellCooldownByHaste = 347,
        DepositBonusMoneyInGuildBankOnLoot = 348,
        ModCurrencyGain = 349,
        ModGatheringItemsGainedPercent = 350,
        ModCamouflage = 353,
        ModCastingSpeed = 355,
        EnableBoss1UnitFrame = 357,
        WorgenAlteredForm = 358,
        ProcTriggerSpellCopy = 360,
        OverrideAutoattackWithMeleeSpell = 361,
        ModNextSpell = 363,
        MaxFarClipPlane = 365,
        OverrideSpellPowerByApPct = 366,
        OverrideAutoattackWithRangedSpell = 367,
        EnablePowerBarTimer = 369,
        SetFairFarClip = 370,
        ModSpeedNoControl = 373,
        ModFallDamagePct = 374,
        ModCurrencyGainFromSource = 376,
        CastWhileWalking2 = 377,
        ModManaRegenPct = 379,
        ModGlobalCooldownByHaste = 380,
        ModPetStatPct = 382,
        IgnoreSpellCooldown = 383,
        ChanceOverrideAutoattackWithSpellOnSelf = 385,
        ModTaxiFlightSpeed = 388,
        ShowConfirmationPrompt = 394,
        AreaTrigger = 395,
        ProcOnPowerAmount2 = 396,
        ModSkill2 = 400,
        ModPowerDisplay = 402,
        OverrideSpellVisual = 403,
        OverrideAttackPowerBySpPct = 404,
        ModRatingPct = 405,
        KeyboundOverride = 406,
        ModFear2 = 407,
        CanTurnWhileFalling = 409,
        ModMaxCharges = 411,
        ModCooldownByHasteRegen = 416,
        ModGlobalCooldownByHasteRegen = 417,
        ModMaxPower = 418,
        ModBaseManaPct = 419,
        ModBattlePetXpPct = 420,
        ModAbsorbEffectsAmountPct = 421,
        ScalePlayerLevel = 427,
        LinkedSummon = 428,
        PlayScene = 430,
        ModOverrideZonePvpType = 431,
        ModEnvironmentalDamageTaken = 436,
        ModMinimumSpeedRate = 437,
        PreloadPhase = 438,
        ModMultistrikeDamage = 440,
        ModMultistrikeChance = 441,
        ModReadiness = 442,
        ModLeech = 443,
        ModXpFromCreatureType = 447,
        OverridePetSpecs = 451,
        ChargeRecoveryMod = 453,
        ChargeRecoveryMultiplier = 454,
        ModRoot2 = 455,
        ChargeRecoveryAffectedByHaste = 456,
        ChargeRecoveryAffectedByHasteRegen = 457,
        IgnoreDualWieldHitPenalty = 458,
        IgnoreMovementForces = 459,
        ResetCooldownsOnDuelStart = 460,
        ModHealingAndAbsorbFromCaster = 462,
        ConvertCritRatingPctToParryRating = 463,
        ModAttackPowerOfBonusArmor = 464,
        ModBonusArmor = 465,
        ModBonusArmorPct = 466,
        ModStatBonusPct = 467,
        TriggerSpellOnHealthBelowPct = 468,
        ShowConfirmationPromptWithDifficulty = 469,
        ModVersatility = 471,
        PreventDurabilityLossFromCombat = 473,
        AllowUsingGameObjectsWhileMounted = 475,
        ModCurrencyGainLootedPct = 476,
        ConvertConsumedRune = 481,
        SuppressTransforms = 483,
        ModMovementForceMagnitude = 485,
    }

    internal enum DifficultyFlags
    {
        Heroic = 1,
        Default = 2,
        CanSelect = 4,
        ChallengeMode = 8,
        Legacy = 32,
        DisplayHeroic = 64,
        DisplayMythic = 128,
    }

    internal enum ItemsParseAllowableClass
    {
        Warrior = 1,
        Paladin = 2,
        Hunter = 4,
        Rogue = 8,
        Priest = 16,
        DeathKnight = 32,
        Shaman = 64,
        Mage = 128,
        Warlock = 256,
        Monk = 512,
        Druid = 1024,
        DemonHunter = 2048,
    }

    internal enum ItemsParseFlags0 : uint
    {
        NoPickup = 1,
        Conjured = 2,
        HasLoot = 3,
        HeroicTooltip = 4,
        Deprecated = 16,
        NoUserDestroy = 32,
        PlayerCast = 64,
        NoEquipCooldown = 128,
        MultiLootQuest = 256,
        IsWrapper = 512,
        UsesResources = 1024,
        MultiDrop = 2048,
        ItemPurchaseRecord = 4096,
        Petition = 8192,
        HasText = 16384,
        NoDisenchant = 32768,
        RealDuration = 65536,
        NoCreator = 131072,
        IsProspectable = 262144,
        UniqueEquippable = 524288,
        IgnoreForAuras = 1048576,
        IgnoreDefaultArenaRestrictions = 2097152,
        NoDurabilityLoss = 4194304,
        UseWhenShapeShifted = 8388608,
        HasQuestGlow = 16777216,
        HideUnusableRecipe = 33554432,
        NotUseableInArena = 67108864,
        IsBoundToAccount = 134217728,
        NoReagentCost = 268435456,
        IsMillable = 536870912,
        ReportToGuildChat = 1073741824,
        NoProgressiveLoot = 2147483648,
    }

    internal enum ItemsParseFlags1 : uint
    {
        FactionHorde = 1,
        FactionAlliance = 2,
        DoNotIgnoreBuyPrice = 4,
        ClassifyAsCaster = 8,
        ClassifyAsPhysical = 16,
        EveryoneCanRollNeed = 32,
        NoTradeBindOnAcquire = 64,
        CanTradeBindOnAcquire = 128,
        CanOnlyRollGreed = 256,
        CasterWeapon = 512,
        DeleteOnLogin = 1024,
        InternalItem = 2048,
        NoVendorValue = 4096,
        ShowBeforeDiscovered = 8192,
        OverrideGoldCost = 16384,
        IgnoreDefaultRatedBgRestrictions = 32768,
        NotUsableInRatedBg = 65536,
        BnetAccountTradeOk = 131072,
        ConfirmBeforeUse = 262144,
        ReevaluateBondingOnTransform = 524288,
        NoTransformOnChargeDepletion = 1048576,
        NoAlterItemVisual = 2097152,
        NoSourceForItemVisual = 4194304,
        IgnoreQualityForItemVisualSource = 8388608,
        NoDurability = 16777216,
        RoleTank = 33554432,
        RoleHealer = 67108864,
        RoleDamage = 134217728,
        CanDropInChallengeMode = 268435456,
        NeverStackInLootUi = 536870912,
        DisenchantToLootTable = 1073741824,
        UsedInATradeSkill = 2147483648,
    }

    internal enum ItemsParseFlags2 : uint
    {
        DoNotDestroyOnQuestAccept = 1,
        ItemCanBeUpgraded = 2,
        UpgradeFromItemOverridesDropUpgrade = 4,
        AlwaysFfaInLoot = 8,
        HideUpgradeLevelsIfNotUpgraded = 16,
        UpdateInteractions = 32,
        UpdateDoesNotLeaveProgressiveWinHistory = 64,
        IgnoreItemHistoryTracker = 128,
        IgnoreItemLevelCapInPvp = 256,
        DisplayAsHeirloom = 512,
        SkipUseCheckOnPickup = 1024,
        Obsolete = 2048,
        DoNotDisplayInGuildNews = 4096,
        PvpTournamentGear = 8192,
        RequiresStackChangeLog = 16384,
        UnusedFlag = 32768,
        HideNameSuffix = 65536,
        PushLoot = 131072,
        DoNotReportLootLogToParty = 262144,
        AlwaysAllowDualWield = 524288,
        Obliteratable = 1048576,
        ActsAsTransmogHiddenVisualOption = 2097152,
        ExpireOnWeeklyReset = 4194304,
        DoesNotShowUpInTransmogUntilCollected = 8388608,
        CanStoreEnchants = 16777216,
        HideQuestItemFromObjectTooltip = 33554432,
        DoNotToast = 67108864,
        IgnoreCreationContextForProgressiveWinHistory = 134217728,
        ForceAllSpecsForItemHistory = 268435456,
        SaveOnConsume = 536870912,
        ContainerSavesPlayerData = 1073741824,
        NoVoidStorage = 2147483648,
    }

    internal enum ItemsParseFlags3 : uint
    {
        HandleOnUseEffectImmediately = 1,
        AlwaysShowItemLevelInTooltip = 2,
        ShowsGenerationWithRandomStats = 4,
        ActivateOnEquipEffectsWhenTransmogrified = 8,
        EnforceTransmogWithChildItem = 16,
        Scrapable = 32,
        BypassRepRequirementsForTransmog = 64,
        DisplayOnlyOnDefinedRaces = 128,
        RegulatedCommodity = 256,
        CreateLootImmediately = 512,
        GenerateLootSpecItem = 1024,
        HiddenInRewardSummaries = 2048,
        DisallowWhileLevelLinked = 4096,
        DisallowEnchant = 8192,
        SquishUsingItemLevelAsPlayerLevel = 16384,
        AlwaysShowSellPriceInTooltip = 32768,
    }

    internal enum ItemSearchNameFlags0 : uint
    {
        NoPickup = 1,
        Conjured = 2,
        HasLoot = 3,
        HeroicTooltip = 4,
        Deprecated = 16,
        NoUserDestroy = 32,
        PlayerCast = 64,
        NoEquipCooldown = 128,
        MultiLootQuest = 256,
        IsWrapper = 512,
        UsesResources = 1024,
        MultiDrop = 2048,
        ItemPurchaseRecord = 4096,
        Petition = 8192,
        HasText = 16384,
        NoDisenchant = 32768,
        RealDuration = 65536,
        NoCreator = 131072,
        IsProspectable = 262144,
        UniqueEquippable = 524288,
        IgnoreForAuras = 1048576,
        IgnoreDefaultArenaRestrictions = 2097152,
        NoDurabilityLoss = 4194304,
        UseWhenShapeShifted = 8388608,
        HasQuestGlow = 16777216,
        HideUnusableRecipe = 33554432,
        NotUseableInArena = 67108864,
        IsBoundToAccount = 134217728,
        NoReagentCost = 268435456,
        IsMillable = 536870912,
        ReportToGuildChat = 1073741824,
        NoProgressiveLoot = 2147483648,
    }

    internal enum ItemSearchNameFlags1 : uint
    {
        FactionHorde = 1,
        FactionAlliance = 2,
        DoNotIgnoreBuyPrice = 4,
        ClassifyAsCaster = 8,
        ClassifyAsPhysical = 16,
        EveryoneCanRollNeed = 32,
        NoTradeBindOnAcquire = 64,
        CanTradeBindOnAcquire = 128,
        CanOnlyRollGreed = 256,
        CasterWeapon = 512,
        DeleteOnLogin = 1024,
        InternalItem = 2048,
        NoVendorValue = 4096,
        ShowBeforeDiscovered = 8192,
        OverrideGoldCost = 16384,
        IgnoreDefaultRatedBgRestrictions = 32768,
        NotUsableInRatedBg = 65536,
        BnetAccountTradeOk = 131072,
        ConfirmBeforeUse = 262144,
        ReevaluateBondingOnTransform = 524288,
        NoTransformOnChargeDepletion = 1048576,
        NoAlterItemVisual = 2097152,
        NoSourceForItemVisual = 4194304,
        IgnoreQualityForItemVisualSource = 8388608,
        NoDurability = 16777216,
        RoleTank = 33554432,
        RoleHealer = 67108864,
        RoleDamage = 134217728,
        CanDropInChallengeMode = 268435456,
        NeverStackInLootUi = 536870912,
        DisenchantToLootTable = 1073741824,
        UsedInATradeSkill = 2147483648,
    }

    internal enum ItemSearchNameFlags2 : uint
    {
        DoNotDestroyOnQuestAccept = 1,
        ItemCanBeUpgraded = 2,
        UpgradeFromItemOverridesDropUpgrade = 4,
        AlwaysFfaInLoot = 8,
        HideUpgradeLevelsIfNotUpgraded = 16,
        UpdateInteractions = 32,
        UpdateDoesNotLeaveProgressiveWinHistory = 64,
        IgnoreItemHistoryTracker = 128,
        IgnoreItemLevelCapInPvp = 256,
        DisplayAsHeirloom = 512,
        SkipUseCheckOnPickup = 1024,
        Obsolete = 2048,
        DoNotDisplayInGuildNews = 4096,
        PvpTournamentGear = 8192,
        RequiresStackChangeLog = 16384,
        UnusedFlag = 32768,
        HideNameSuffix = 65536,
        PushLoot = 131072,
        DoNotReportLootLogToParty = 262144,
        AlwaysAllowDualWield = 524288,
        Obliteratable = 1048576,
        ActsAsTransmogHiddenVisualOption = 2097152,
        ExpireOnWeeklyReset = 4194304,
        DoesNotShowUpInTransmogUntilCollected = 8388608,
        CanStoreEnchants = 16777216,
        HideQuestItemFromObjectTooltip = 33554432,
        DoNotToast = 67108864,
        IgnoreCreationContextForProgressiveWinHistory = 134217728,
        ForceAllSpecsForItemHistory = 268435456,
        SaveOnConsume = 536870912,
        ContainerSavesPlayerData = 1073741824,
        NoVoidStorage = 2147483648,
    }

    internal enum ItemSearchNameFlags3
    {
        HandleOnUseEffectImmediately = 1,
        AlwaysShowItemLevelInTooltip = 2,
        ShowsGenerationWithRandomStats = 4,
        ActivateOnEquipEffectsWhenTransmogrified = 8,
        EnforceTransmogWithChildItem = 16,
        Scrapable = 32,
        BypassRepRequirementsForTransmog = 64,
        DisplayOnlyOnDefinedRaces = 128,
        RegulatedCommodity = 256,
        CreateLootImmediately = 512,
        GenerateLootSpecItem = 1024,
        HiddenInRewardSummaries = 2048,
        DisallowWhileLevelLinked = 4096,
        DisallowEnchant = 8192,
        SquishUsingItemLevelAsPlayerLevel = 16384,
        AlwaysShowSellPriceInTooltip = 32768,
    }

    internal enum PlayerConditionClassMask
    {
        Warrior = 1,
        Paladin = 2,
        Hunter = 4,
        Rogue = 8,
        Priest = 16,
        DeathKnight = 32,
        Shaman = 64,
        Mage = 128,
        Warlock = 256,
        Monk = 512,
        Druid = 1024,
        DemonHunter = 2048,
    }

    internal enum RuneforgeLegendaryAbilityInventoryTypeMask
    {
        Head = 2,
        Neck = 4,
        Shoulder = 8,
        Body = 16,
        Chest = 32,
        Waist = 64,
        Legs = 128,
        Feet = 256,
        Wrist = 512,
        Hand = 1024,
        Finger = 2048,
        Trinket = 4096,
        MainHand = 8192,
        OffHand = 16384,
        Ranged = 32768,
        Cloak = 65536,
        TwoHandWeapon = 131072,
        Bag = 262144,
        Tabard = 524288,
        Robe = 1048576,
        WeaponMainHand = 2097152,
        WeaponOffHand = 4194304,
        Holdable = 8388608,
        Ammo = 16777216,
        Thrown = 33554432,
        RangedRight = 67108864,
        Quiver = 134217728,
        Relic = 268435456,
    }

    internal enum SpellMiscAttributes0 : uint
    {
        ReqAmmo = 2,
        OnNextSwing = 4,
        IsReplenishment = 8,
        Ability = 16,
        TradeSpell = 32,
        Passive = 64,
        HiddenClientSide = 128,
        HideInCombatLog = 256,
        TargetMainHandItem = 512,
        OnNextSwing2 = 1024,
        DaytimeOnly = 4096,
        NightOnly = 8192,
        IndoorsOnly = 16384,
        OutdoorsOnly = 32768,
        NotShapeshift = 65536,
        OnlyStealthed = 131072,
        DoNotAffectSheathState = 262144,
        LevelDamageCalculation = 524288,
        StopAttackTarget = 1048576,
        ImpossibleDodgeParryBlock = 2097152,
        CastTrackTarget = 4194304,
        CastableWhileDead = 8388608,
        CastableWhileMounted = 16777216,
        DisabledWhileActive = 33554432,
        Negative1 = 67108864,
        CastableWhileSitting = 134217728,
        CanNotUsedInCombat = 268435456,
        UnaffectedByInvulnerability = 536870912,
        HeartbeatResistCheck = 1073741824,
        CanNotCancel = 2147483648,
    }

    internal enum SpellMiscAttributes1
    {
        DismissPet = 1,
        DrainAllPower = 2,
        Channeled1 = 4,
        CanNotBeRedirected = 8,
        NotBreakStealth = 32,
        Channeled2 = 64,
        CanNotBeReflected = 128,
        CanNotTargetInCombat = 256,
        MeleeCombatStart = 512,
        NoThreat = 1024,
        IsPickpocket = 4096,
        Farsight = 8192,
        ChannelTrackTarget = 16384,
        DispelAurasOnImmunity = 32768,
        UnaffectedBySchoolImmune = 65536,
        UnAutoCastableByPet = 131072,
        CanNotTargetSelf = 524288,
        ReqComboPoints1 = 1048576,
        ReqComboPoints2 = 4194304,
        IsFishing = 16777216,
        DoNotDisplayInAuraBar = 268435456,
        ChannelDisplaySpellName = 536870912,
        EnableAtDodge = 1073741824,
    }

    internal enum SpellMiscAttributes2 : uint
    {
        CanTargetDead = 1,
        CanTargetNotInLos = 4,
        DisplayInStanceBar = 16,
        AutoRepeatFlag = 32,
        CanNotTargetTapped = 64,
        HealthFunnel = 2048,
        PreserveEnchantInArena = 8192,
        TameBeast = 65536,
        NotResetAutoActions = 131072,
        ReqDeadPet = 262144,
        NotNeedShapeshift = 524288,
        DamageReducedShield = 2097152,
        IsArcaneConcentration = 8388608,
        UnaffectedByAuraSchoolImmune = 67108864,
        IgnoreItemCheck = 268435456,
        CanNotCrit = 536870912,
        TriggeredCanTriggerProc = 1073741824,
        FoodBuff = 2147483648,
    }

    internal enum SpellMiscAttributes3
    {
        BlockableSpell = 8,
        IgnoreResurrectionTimer = 16,
        StackForDiffCasters = 128,
        OnlyTargetPlayers = 256,
        TriggeredCanTriggerProc2 = 512,
        MainHand = 1024,
        Battleground = 2048,
        OnlyTargetGhosts = 4096,
        DoNotDisplayChannelBar = 8192,
        IsHonorlessTarget = 16384,
        CanNotTriggerProc = 65536,
        NoInitialAggro = 131072,
        IgnoreHitResult = 262144,
        DisableProc = 524288,
        DeathPersistent = 1048576,
        ReqWand = 4194304,
        ReqOffhand = 16777216,
        TreatAsPeriodic = 33554432,
        CanProcWithTriggered = 67108864,
        DrainSoul = 134217728,
        NoDoneBonus = 536870912,
        DoNotDisplayRange = 1073741824,
    }

    internal enum SpellMiscAttributes4
    {
        IgnoreResistances = 1,
        ProcOnlyOnCaster = 2,
        NotStealable = 64,
        CanCastWhileCasting = 128,
        FixedDamage = 256,
        TriggerActivate = 512,
        SpellVsExtendCost = 1024,
        CombatLogNoCaster = 8192,
        DamageDoesNotBreakAuras = 16384,
        NotUsableInArenaOrRatedBg = 65536,
        UsableInArena = 131072,
        AreaTargetChain = 262144,
        NotCheckSelfCastPower = 1048576,
        IsPetScaling = 33554432,
        CastOnlyInOutland = 67108864,
    }

    internal enum SpellMiscAttributes5
    {
        CanChannelWhenMoving = 1,
        NoReagentWhilePrep = 2,
        UsableWhileStunned = 8,
        SingleTargetSpell = 32,
        StartPeriodicAtApply = 512,
        HideDuration = 1024,
        AllowTargetOfTargetAsTarget = 2048,
        HasteAffectDuration = 8192,
        UsableWhileFeared = 131072,
        UsableWhileConfused = 262144,
        DoNotTurnDuringCast = 524288,
        DoNotShowAuraIfSelfCast = 134217728,
        DoNotShowAuraIfNotSelfCast = 268435456,
    }

    internal enum SpellMiscAttributes6 : uint
    {
        DoNotDisplayCooldown = 1,
        OnlyInArena = 2,
        IgnoreCasterAuras = 4,
        AssistIgnoreImmuneFlag = 8,
        UseSpellCastEvent = 64,
        CanNotTargetCrowdControlled = 256,
        CanTargetPossessedFriends = 1024,
        NotInRaidInstance = 2048,
        CastableWhileOnVehicle = 4096,
        CanTargetInvisible = 8192,
        CastByCharmer = 262144,
        OnlyVisibleToCaster = 1048576,
        ClientUiTargetEffects = 2097152,
        CanTargetUntargetable = 16777216,
        NotResetSwingIfInstant = 33554432,
        NoDonePctDamageMods = 536870912,
        IgnoreCategoryCooldownMods = 2147483648,
    }

    internal enum SpellMiscAttributes7 : uint
    {
        IgnoreDurationMods = 2,
        ReactivateAtResurrect = 4,
        IsCheatSpell = 8,
        SummonTotem = 32,
        NoPushbackOnDamage = 64,
        HordeOnly = 256,
        AllianceOnly = 512,
        DispelCharges = 1024,
        InterruptOnlyNonPlayer = 2048,
        SilenceOnlyNonPlayer = 4096,
        CanRestoreSecondaryPower = 65536,
        HasChargeEffect = 262144,
        ZoneTeleport = 524288,
        ConsolidatedRaidBuff = 268435456,
        ClientIndicator = 2147483648,
    }

    internal enum SpellMiscAttributes8 : uint
    {
        CanNotMiss = 1,
        AffectPartyAndRaid = 256,
        DoNotResetPeriodicTimer = 512,
        NameChangedDuringTransform = 1024,
        AuraSendAmount = 4096,
        WaterMount = 32768,
        RememberSpells = 262144,
        UseComboPointsOnAnyTarget = 524288,
        ArmorSpecialization = 1048576,
        BattleResurrection = 8388608,
        HealingSpell = 16777216,
        RaidMarker = 67108864,
        NotInBgOrArena = 268435456,
        MasterySpecialization = 536870912,
        AttackIgnoreImmuneToPcFlag = 2147483648,
    }

    internal enum SpellMiscAttributes9
    {
        RestrictedFlightArea = 4,
        SpecialDelayCalculation = 16,
        SummonPlayerTotem = 32,
        AimedShot = 256,
        NotUsableInArena = 512,
        Slam = 8192,
        UsableInRatedBattlegrounds = 16384,
    }

    internal enum SpellMiscAttributes10
    {
        WaterSpout = 16,
        TeleportPlayer = 128,
        HerbGatheringMining = 2048,
        UseSpellBaseLevelForScaling = 4096,
        MountIsNotAccountWide = 536870912,
    }

    internal enum SpellMiscAttributes11
    {
        ScalesWithItemLevel = 4,
        SpellAttr11AbsorbEnvironmentalDamage = 32,
        SpellAttr11RankIgnoresCasterLevel = 128,
        NotUsableInChallengeMode = 65536,
    }

    internal enum SpellMiscAttributes12
    {
        IsGarrisonBuff = 16777216,
        IsReadinessSpell = 134217728,
    }

    internal enum SpellMiscAttributes13
    {
        ActivatesRequiredShapeshift = 262144,
        IsAlwaysShown = 4194304,
    }
}