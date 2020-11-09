using System;
using System.Collections.Generic;
using System.Text;

namespace WeakAuraAutomationTool.Warcraft.Parser.Enumerations
{
    [Flags]
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

    [Flags]
    internal enum SpellMiscAttributes1 : uint
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

    [Flags]
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

    [Flags]
    internal enum SpellMiscAttributes3 : uint
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

    [Flags]
    internal enum SpellMiscAttributes4 : uint
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

    [Flags]
    internal enum SpellMiscAttributes5 : uint
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

    [Flags]
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

    [Flags]
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

    [Flags]
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

    [Flags]
    internal enum SpellMiscAttributes9 : uint
    {
        RestrictedFlightArea = 4,
        SpecialDelayCalculation = 16,
        SummonPlayerTotem = 32,
        AimedShot = 256,
        NotUsableInArena = 512,
        Slam = 8192,
        UsableInRatedBattlegrounds = 16384,
    }

    [Flags]
    internal enum SpellMiscAttributes10 : uint
    {
        WaterSpout = 16,
        TeleportPlayer = 128,
        HerbGatheringMining = 2048,
        UseSpellBaseLevelForScaling = 4096,
        MountIsNotAccountWide = 536870912,
    }

    [Flags]
    internal enum SpellMiscAttributes11 : uint
    {
        ScalesWithItemLevel = 4,
        SpellAttr11AbsorbEnvironmentalDamage = 32,
        SpellAttr11RankIgnoresCasterLevel = 128,
        NotUsableInChallengeMode = 65536,
    }

    [Flags]
    internal enum SpellMiscAttributes12 : uint
    {
        IsGarrisonBuff = 16777216,
        IsReadinessSpell = 134217728,
    }

    [Flags]
    internal enum SpellMiscAttributes13 : uint
    {
        ActivatesRequiredShapeshift = 262144,
        IsAlwaysShown = 4194304,
    }
}