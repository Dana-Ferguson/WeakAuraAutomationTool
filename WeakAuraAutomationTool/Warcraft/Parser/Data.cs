using System;
using System.Collections.Generic;
using System.Text;

using CsvHelper.Configuration.Attributes;

// ReSharper disable UnusedMember.Global

namespace WeakAuraAutomationTool.Warcraft.Parser
{
    public class WowData
    {
        public readonly List<SpecializationSpell> SpecializationSpells = Csv.Load<SpecializationSpell>("data/specializationspells.csv");
        public readonly List<SpellRange> SpellRanges = Csv.Load<SpellRange>("data/spellrange.csv");

        public readonly List<Spell> Spells = Csv.Load<Spell>("data/spell.csv");
        public readonly List<SpellActionBarPref> SpellActionBarPrefs = Csv.Load<SpellActionBarPref>("data/spellactionbarpref.csv");
        public readonly List<SpellActivationOverlay> SpellActivationOverlays = Csv.Load<SpellActivationOverlay>("data/spellactivationoverlay.csv");
        public readonly List<SpellAuraOptions> SpellAuraOptions = Csv.Load<SpellAuraOptions>("data/spellauraoptions.csv");
        public readonly List<SpellAuraRestrictions> SpellAuraRestrictions = Csv.Load<SpellAuraRestrictions>("data/spellaurarestrictions.csv");
        public readonly List<SpellAuraVisibility> SpellAuraVisibilities = Csv.Load<SpellAuraVisibility>("data/spellauravisibility.csv");
        public readonly List<SpellCastingRequirements> SpellCastingRequirements = Csv.Load<SpellCastingRequirements>("data/spellcastingrequirements.csv");
        public readonly List<SpellCastTimes> SpellCastTimes = Csv.Load<SpellCastTimes>("data/spellcasttimes.csv");
        public readonly List<SpellCategories> SpellCategories = Csv.Load<SpellCategories>("data/spellcategories.csv");
        public readonly List<SpellCategory> SpellCategory = Csv.Load<SpellCategory>("data/spellcategory.csv");
        public readonly List<SpellChainEffects> SpellChainEffects = Csv.Load<SpellChainEffects>("data/spellchaineffects.csv");
        public readonly List<SpellClassOptions> SpellClassOptions = Csv.Load<SpellClassOptions>("data/spellclassoptions.csv");
        public readonly List<SpellCooldowns> SpellCooldowns = Csv.Load<SpellCooldowns>("data/spellcooldowns.csv");
        public readonly List<SpellDuration> SpellDurations = Csv.Load<SpellDuration>("data/spellduration.csv");
        public readonly List<SpellEffect> SpellEffects = Csv.Load<SpellEffect>("data/spelleffect.csv");
        public readonly List<SpellEquippedItems> SpellEquippedItems = Csv.Load<SpellEquippedItems>("data/spellequippeditems.csv");
        public readonly List<SpellInterrupts> SpellInterrupts = Csv.Load<SpellInterrupts>("data/spellinterrupts.csv");
        public readonly List<SpellLabel> SpellLabels = Csv.Load<SpellLabel>("data/spelllabel.csv");
        public readonly List<SpellLevels> SpellLevels = Csv.Load<SpellLevels>("data/spelllevels.csv");
        public readonly List<SpellMisc> SpellMisc = Csv.Load<SpellMisc>("data/spellmisc.csv");
        public readonly List<SpellName> SpellNames = Csv.Load<SpellName>("data/spellname.csv");
        public readonly List<SpellPower> SpellPower = Csv.Load<SpellPower>("data/spellpower.csv");
        public readonly List<Talent> Talents = Csv.Load<Talent>("data/talent.csv");
    }

    public class SpellRange
    {
        [Name("ID")] public int Id { get; set; }
        [Name("DisplayName_lang")] public string DisplayName { get; set; }
        [Name("DisplayNameShort_lang")] public string DisplayNameShort { get; set; }
        [Name("Flags")] public int SpellIdOverride { get; set; }
        [Name("RangeMin[0]")] public double RangeMin0 { get; set; }
        [Name("RangeMin[1]")] public double RangeMin1 { get; set; }
        [Name("RangeMax[0]")] public double RangeMax0 { get; set; }
        [Name("RangeMax[1]")] public double RangeMax1 { get; set; }
    }

    public class SpecializationSpell
    {
        [Name("Description_lang")] public string DescriptionLang { get; set; }
        [Name("ID")] public int Id { get; set; }
        [Name("SpecID")] public int SpecId { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
        [Name("OverridesSpellID")] public int SpellIdOverride { get; set; }
        [Name("DisplayOrder")] public int DisplayOrder { get; set; }
    }

    public class Spell
    {
        [Name("ID")] public int Id { get; set; }
        [Name("NameSubtext_lang")] public string NameSubtextLang { get; set; }
        [Name("Description_lang")] public string DescriptionLang { get; set; }
        [Name("AuraDescription_lang")] public string AuraDescriptionLang { get; set; }
    }

    public class SpellActionBarPref
    {
        [Name("ID")] public int Id { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
        [Name("PreferredActionBarMask")] public int PreferredActionBarMask { get; set; }
    }

    public class SpellActivationOverlay
    {
        [Name("ID")] public int Id { get; set; }
        [Name("IconHighlightSpellClassMask[0]")] public int IconHighlightSpellClassMask0 { get; set; }
        [Name("IconHighlightSpellClassMask[1]")] public int IconHighlightSpellClassMask1 { get; set; }
        [Name("IconHighlightSpellClassMask[2]")] public int IconHighlightSpellClassMask2 { get; set; }
        [Name("IconHighlightSpellClassMask[3]")] public int IconHighlightSpellClassMask3 { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
        [Name("OverlayFileDataID")] public int OverlayFileDataId { get; set; }
        [Name("ScreenLocationID")] public int ScreenLocationId { get; set; }
        [Name("SoundEntriesID")] public int SoundEntriesId { get; set; }
        [Name("Color")] public int Color { get; set; }
        [Name("Scale")] public double Scale { get; set; }
        [Name("TriggerType")] public int TriggerType { get; set; }
        [Name("TriggerSpell")] public int TriggerSpell { get; set; }
    }

    public class SpellAuraOptions
    {
        [Name("ID")] public int Id { get; set; }
        [Name("DifficultyID")] public int DifficultyId { get; set; }
        [Name("CumulativeAura")] public int CumulativeAura { get; set; }
        [Name("ProcCategoryRecovery")] public int ProcCategoryRecovery { get; set; }
        [Name("ProcChance")] public int ProcChance { get; set; }
        [Name("ProcCharges")] public int ProcCharges { get; set; }
        [Name("SpellProcsPerMinuteID")] public int SpellProcsPerMinuteId { get; set; }
        [Name("ProcTypeMask[0]")] public int ProcTypeMask0 { get; set; }
        [Name("ProcTypeMask[1]")] public int ProcTypeMask1 { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
    }

    public class SpellAuraRestrictions
    {
        [Name("ID")] public int Id { get; set; }
        [Name("DifficultyID")] public int DifficultyId { get; set; }
        [Name("CasterAuraState")] public int CasterAuraState { get; set; }
        [Name("TargetAuraState")] public int TargetAuraState { get; set; }
        [Name("ExcludeCasterAuraState")] public int ExcludeCasterAuraState { get; set; }
        [Name("ExcludeTargetAuraState")] public int ExcludeTargetAuraState { get; set; }
        [Name("CasterAuraSpell")] public int CasterAuraSpell { get; set; }
        [Name("TargetAuraSpell")] public int TargetAuraSpell { get; set; }
        [Name("ExcludeCasterAuraSpell")] public int ExcludeCasterAuraSpell { get; set; }
        [Name("ExcludeTargetAuraSpell")] public int ExcludeTargetAuraSpell { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
    }

    public class SpellAuraVisibility
    {
        [Name("ID")] public int Id { get; set; }
        [Name("Type")] public int Type { get; set; }
        [Name("Flags")] public int Flags { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
    }

    public class SpellCastingRequirements
    {
        [Name("ID")] public int Id { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
        [Name("FacingCasterFlags")] public int FacingCasterFlags { get; set; }
        [Name("MinFactionID")] public int MinFactionId { get; set; }
        [Name("MinReputation")] public int MinReputation { get; set; }
        [Name("RequiredAreasID")] public int RequiredAreasId { get; set; }
        [Name("RequiredAuraVision")] public int RequiredAuraVision { get; set; }
        [Name("RequiresSpellFocus")] public int RequiresSpellFocus { get; set; }
    }

    public class SpellCastTimes
    {
        [Name("ID")] public int Id { get; set; }
        [Name("Base")] public int Base { get; set; }
        [Name("Minimum")] public int Minimum { get; set; }
    }

    public class SpellCategories
    {
        [Name("ID")] public int Id { get; set; }
        [Name("DifficultyID")] public int DifficultyId { get; set; }
        [Name("Category")] public int Category { get; set; }
        [Name("DefenseType")] public int DefenseType { get; set; }
        [Name("DispelType")] public int DispelType { get; set; }
        [Name("Mechanic")] public int Mechanic { get; set; }
        [Name("PreventionType")] public int PreventionType { get; set; }
        [Name("StartRecoveryCategory")] public int StartRecoveryCategory { get; set; }
        [Name("ChargeCategory")] public int ChargeCategory { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
    }

    public class SpellCategory
    {
        [Name("ID")] public int Id { get; set; }
        [Name("Name_lang")] public string NameLang { get; set; }
        [Name("Flags")] public int Flags { get; set; }
        [Name("UsesPerWeek")] public int UsesPerWeek { get; set; }
        [Name("MaxCharges")] public int MaxCharges { get; set; }
        [Name("ChargeRecoveryTime")] public int ChargeRecoveryTime { get; set; }
        [Name("TypeMask")] public int TypeMask { get; set; }
    }

    public class SpellChainEffects
    {
        [Name("ID")] public int Id { get; set; }
        [Name("AvgSegLen")] public double AvgSegLen { get; set; }
        [Name("NoiseScale")] public double NoiseScale { get; set; }
        [Name("TexCoordScale")] public double TexCoordScale { get; set; }
        [Name("SegDuration")] public int SegDuration { get; set; }
        [Name("SegDelay")] public int SegDelay { get; set; }
        [Name("Flags")] public int Flags { get; set; }
        [Name("JointCount")] public int JointCount { get; set; }
        [Name("JointOffsetRadius")] public double JointOffsetRadius { get; set; }
        [Name("JointsPerMinorJoint")] public int JointsPerMinorJoint { get; set; }
        [Name("MinorJointsPerMajorJoint")] public int MinorJointsPerMajorJoint { get; set; }
        [Name("MinorJointScale")] public double MinorJointScale { get; set; }
        [Name("MajorJointScale")] public double MajorJointScale { get; set; }
        [Name("JointMoveSpeed")] public double JointMoveSpeed { get; set; }
        [Name("JointSmoothness")] public double JointSmoothness { get; set; }
        [Name("MinDurationBetweenJointJumps")] public double MinDurationBetweenJointJumps { get; set; }
        [Name("MaxDurationBetweenJointJumps")] public double MaxDurationBetweenJointJumps { get; set; }
        [Name("WaveHeight")] public double WaveHeight { get; set; }
        [Name("WaveFreq")] public double WaveFreq { get; set; }
        [Name("WaveSpeed")] public double WaveSpeed { get; set; }
        [Name("MinWaveAngle")] public double MinWaveAngle { get; set; }
        [Name("MaxWaveAngle")] public double MaxWaveAngle { get; set; }
        [Name("MinWaveSpin")] public double MinWaveSpin { get; set; }
        [Name("MaxWaveSpin")] public double MaxWaveSpin { get; set; }
        [Name("ArcHeight")] public double ArcHeight { get; set; }
        [Name("MinArcAngle")] public double MinArcAngle { get; set; }
        [Name("MaxArcAngle")] public double MaxArcAngle { get; set; }
        [Name("MinArcSpin")] public double MinArcSpin { get; set; }
        [Name("MaxArcSpin")] public double MaxArcSpin { get; set; }
        [Name("DelayBetweenEffects")] public double DelayBetweenEffects { get; set; }
        [Name("MinFlickerOnDuration")] public double MinFlickerOnDuration { get; set; }
        [Name("MaxFlickerOnDuration")] public double MaxFlickerOnDuration { get; set; }
        [Name("MinFlickerOffDuration")] public double MinFlickerOffDuration { get; set; }
        [Name("MaxFlickerOffDuration")] public double MaxFlickerOffDuration { get; set; }
        [Name("PulseSpeed")] public double PulseSpeed { get; set; }
        [Name("PulseOnLength")] public double PulseOnLength { get; set; }
        [Name("PulseFadeLength")] public double PulseFadeLength { get; set; }
        [Name("Alpha")] public int Alpha { get; set; }
        [Name("Red")] public int Red { get; set; }
        [Name("Green")] public int Green { get; set; }
        [Name("Blue")] public int Blue { get; set; }
        [Name("BlendMode")] public int BlendMode { get; set; }
        [Name("RenderLayer")] public int RenderLayer { get; set; }
        [Name("WavePhase")] public double WavePhase { get; set; }
        [Name("TimePerFlipFrame")] public double TimePerFlipFrame { get; set; }
        [Name("VariancePerFlipFrame")] public double VariancePerFlipFrame { get; set; }
        [Name("TextureParticleFileDataID")] public int TextureParticleFileDataId { get; set; }
        [Name("StartWidth")] public double StartWidth { get; set; }
        [Name("EndWidth")] public double EndWidth { get; set; }
        [Name("WidthScaleCurveID")] public int WidthScaleCurveId { get; set; }
        [Name("NumFlipFramesU")] public int NumFlipFramesU { get; set; }
        [Name("NumFlipFramesV")] public int NumFlipFramesV { get; set; }
        [Name("SoundKitID")] public int SoundKitId { get; set; }
        [Name("ParticleScaleMultiplier")] public double ParticleScaleMultiplier { get; set; }
        [Name("ParticleEmissionRateMultiplier")] public double ParticleEmissionRateMultiplier { get; set; }
        [Name("SpellChainEffectID[0]")] public int SpellChainEffectId0 { get; set; }
        [Name("SpellChainEffectID[1]")] public int SpellChainEffectId1 { get; set; }
        [Name("SpellChainEffectID[2]")] public int SpellChainEffectId2 { get; set; }
        [Name("SpellChainEffectID[3]")] public int SpellChainEffectId3 { get; set; }
        [Name("SpellChainEffectID[4]")] public int SpellChainEffectId4 { get; set; }
        [Name("SpellChainEffectID[5]")] public int SpellChainEffectId5 { get; set; }
        [Name("SpellChainEffectID[6]")] public int SpellChainEffectId6 { get; set; }
        [Name("SpellChainEffectID[7]")] public int SpellChainEffectId7 { get; set; }
        [Name("SpellChainEffectID[8]")] public int SpellChainEffectId8 { get; set; }
        [Name("SpellChainEffectID[9]")] public int SpellChainEffectId9 { get; set; }
        [Name("SpellChainEffectID[10]")] public int SpellChainEffectId10 { get; set; }
        [Name("TextureCoordScaleU[0]")] public double TextureCoordScaleU0 { get; set; }
        [Name("TextureCoordScaleU[1]")] public double TextureCoordScaleU1 { get; set; }
        [Name("TextureCoordScaleU[2]")] public double TextureCoordScaleU2 { get; set; }
        [Name("TextureCoordScaleV[0]")] public double TextureCoordScaleV0 { get; set; }
        [Name("TextureCoordScaleV[1]")] public double TextureCoordScaleV1 { get; set; }
        [Name("TextureCoordScaleV[2]")] public double TextureCoordScaleV2 { get; set; }
        [Name("TextureRepeatLengthU[0]")] public double TextureRepeatLengthU0 { get; set; }
        [Name("TextureRepeatLengthU[1]")] public double TextureRepeatLengthU1 { get; set; }
        [Name("TextureRepeatLengthU[2]")] public double TextureRepeatLengthU2 { get; set; }
        [Name("TextureRepeatLengthV[0]")] public double TextureRepeatLengthV0 { get; set; }
        [Name("TextureRepeatLengthV[1]")] public double TextureRepeatLengthV1 { get; set; }
        [Name("TextureRepeatLengthV[2]")] public double TextureRepeatLengthV2 { get; set; }
        [Name("TextureFileDataID[0]")] public int TextureFileDataId0 { get; set; }
        [Name("TextureFileDataID[1]")] public int TextureFileDataId1 { get; set; }
        [Name("TextureFileDataID[2]")] public int TextureFileDataId2 { get; set; }
    }

    public class SpellClassOptions
    {
        [Name("ID")] public int Id { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
        [Name("ModalNextSpell")] public int ModalNextSpell { get; set; }
        [Name("SpellClassSet")] public int SpellClassSet { get; set; }
        [Name("SpellClassMask[0]")] public int SpellClassMask0 { get; set; }
        [Name("SpellClassMask[1]")] public int SpellClassMask1 { get; set; }
        [Name("SpellClassMask[2]")] public int SpellClassMask2 { get; set; }
        [Name("SpellClassMask[3]")] public int SpellClassMask3 { get; set; }
    }

    public class SpellCooldowns
    {
        [Name("ID")] public int Id { get; set; }
        [Name("DifficultyID")] public int DifficultyId { get; set; }
        [Name("CategoryRecoveryTime")] public int CategoryRecoveryTime { get; set; }
        [Name("RecoveryTime")] public int RecoveryTime { get; set; }
        [Name("StartRecoveryTime")] public int StartRecoveryTime { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
    }

    public class SpellDuration
    {
        [Name("ID")] public int Id { get; set; }
        [Name("Duration")] public int Duration { get; set; }
        [Name("MaxDuration")] public int MaxDuration { get; set; }
    }

    public class SpellEffect
    {
        [Name("ID")] public int Id { get; set; }
        [Name("EffectAura")] public int EffectAura { get; set; }
        [Name("DifficultyID")] public int DifficultyId { get; set; }
        [Name("EffectIndex")] public int EffectIndex { get; set; }
        [Name("Effect")] public int Effect { get; set; }
        [Name("EffectAmplitude")] public double EffectAmplitude { get; set; }
        [Name("EffectAttributes")] public int EffectAttributes { get; set; }
        [Name("EffectAuraPeriod")] public int EffectAuraPeriod { get; set; }
        [Name("EffectBonusCoefficient")] public double EffectBonusCoefficient { get; set; }
        [Name("EffectChainAmplitude")] public double EffectChainAmplitude { get; set; }
        [Name("EffectChainTargets")] public int EffectChainTargets { get; set; }
        [Name("EffectItemType")] public int EffectItemType { get; set; }
        [Name("EffectMechanic")] public int EffectMechanic { get; set; }
        [Name("EffectPointsPerResource")] public int EffectPointsPerResource { get; set; }
        [Name("EffectPos_facing")] public double EffectPosFacing { get; set; }
        [Name("EffectRealPointsPerLevel")] public double EffectRealPointsPerLevel { get; set; }
        [Name("EffectTriggerSpell")] public int EffectTriggerSpell { get; set; }
        [Name("BonusCoefficientFromAP")] public double BonusCoefficientFromAp { get; set; }
        [Name("PvpMultiplier")] public double PvpMultiplier { get; set; }
        [Name("Coefficient")] public double Coefficient { get; set; }
        [Name("Variance")] public double Variance { get; set; }
        [Name("ResourceCoefficient")] public int ResourceCoefficient { get; set; }
        [Name("GroupSizeBasePointsCoefficient")] public double GroupSizeBasePointsCoefficient { get; set; }
        [Name("EffectBasePointsF")] public double EffectBasePointsF { get; set; }
        [Name("EffectMiscValue[0]")] public int EffectMiscValue0 { get; set; }
        [Name("EffectMiscValue[1]")] public int EffectMiscValue1 { get; set; }
        [Name("EffectRadiusIndex[0]")] public int EffectRadiusIndex0 { get; set; }
        [Name("EffectRadiusIndex[1]")] public int EffectRadiusIndex1 { get; set; }
        [Name("EffectSpellClassMask[0]")] public int EffectSpellClassMask0 { get; set; }
        [Name("EffectSpellClassMask[1]")] public int EffectSpellClassMask1 { get; set; }
        [Name("EffectSpellClassMask[2]")] public int EffectSpellClassMask2 { get; set; }
        [Name("EffectSpellClassMask[3]")] public int EffectSpellClassMask3 { get; set; }
        [Name("ImplicitTarget[0]")] public int ImplicitTarget0 { get; set; }
        [Name("ImplicitTarget[1]")] public int ImplicitTarget1 { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
    }

    public class SpellEquippedItems
    {
        [Name("ID")] public int Id { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
        [Name("EquippedItemClass")] public int EquippedItemClass { get; set; }
        [Name("EquippedItemInvTypes")] public int EquippedItemInvTypes { get; set; }
        [Name("EquippedItemSubclass")] public int EquippedItemSubclass { get; set; }
    }

    public class SpellInterrupts
    {
        [Name("ID")] public int Id { get; set; }
        [Name("DifficultyID")] public int DifficultyId { get; set; }
        [Name("InterruptFlags")] public int InterruptFlags { get; set; }
        [Name("AuraInterruptFlags[0]")] public int AuraInterruptFlags0 { get; set; }
        [Name("AuraInterruptFlags[1]")] public int AuraInterruptFlags1 { get; set; }
        [Name("ChannelInterruptFlags[0]")] public int ChannelInterruptFlags0 { get; set; }
        [Name("ChannelInterruptFlags[1]")] public int ChannelInterruptFlags1 { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
    }

    public class SpellLabel
    {
        [Name("ID")] public int Id { get; set; }
        [Name("LabelID")] public int LabelId { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
    }

    public class SpellLevels
    {
        [Name("ID")] public int Id { get; set; }
        [Name("DifficultyID")] public int DifficultyId { get; set; }
        [Name("MaxLevel")] public int MaxLevel { get; set; }
        [Name("MaxPassiveAuraLevel")] public int MaxPassiveAuraLevel { get; set; }
        [Name("LearnLevel")] public int LearnLevel { get; set; }
        [Name("Field_9_0_1_33978_004")] public int Field_9_0_1_33978_004 { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
    }

    public class SpellMisc
    {
        [Name("ID")] public int Id { get; set; }
        [Name("Attributes[0]")] public uint Attributes0 { get; set; }
        [Name("Attributes[1]")] public uint Attributes1 { get; set; }
        [Name("Attributes[2]")] public uint Attributes2 { get; set; }
        [Name("Attributes[3]")] public uint Attributes3 { get; set; }
        [Name("Attributes[4]")] public uint Attributes4 { get; set; }
        [Name("Attributes[5]")] public uint Attributes5 { get; set; }
        [Name("Attributes[6]")] public uint Attributes6 { get; set; }
        [Name("Attributes[7]")] public uint Attributes7 { get; set; }
        [Name("Attributes[8]")] public uint Attributes8 { get; set; }
        [Name("Attributes[9]")] public uint Attributes9 { get; set; }
        [Name("Attributes[10]")] public uint Attributes10 { get; set; }
        [Name("Attributes[11]")] public uint Attributes11 { get; set; }
        [Name("Attributes[12]")] public uint Attributes12 { get; set; }
        [Name("Attributes[13]")] public uint Attributes13 { get; set; }
        [Name("Attributes[14]")] public uint Attributes14 { get; set; }
        [Name("DifficultyID")] public int DifficultyId { get; set; }
        [Name("CastingTimeIndex")] public int CastingTimeIndex { get; set; }
        [Name("DurationIndex")] public int DurationIndex { get; set; }
        [Name("RangeIndex")] public int RangeIndex { get; set; }
        [Name("SchoolMask")] public int SchoolMask { get; set; }
        [Name("Speed")] public double Speed { get; set; }
        [Name("LaunchDelay")] public double LaunchDelay { get; set; }
        [Name("MinDuration")] public double MinDuration { get; set; }
        [Name("SpellIconFileDataID")] public int SpellIconFileDataId { get; set; }
        [Name("ActiveIconFileDataID")] public int ActiveIconFileDataId { get; set; }
        [Name("ContentTuningID")] public int ContentTuningId { get; set; }
        [Name("PlayerConditionID")] public int PlayerConditionId { get; set; }
        [Name("SpellVisualScript")] public int SpellVisualScript { get; set; }
        [Name("Field_9_0_1_35679_014")] public int Field_9_0_1_35679_014 { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
    }

    public class SpellName
    {
        [Name("ID")] public int Id { get; set; }
        [Name("Name_lang")] public string NameLang { get; set; }
    }

    public class SpellPower
    {
        [Name("ID")] public int Id { get; set; }
        [Name("OrderIndex")] public int OrderIndex { get; set; }
        [Name("ManaCost")] public int ManaCost { get; set; }
        [Name("ManaCostPerLevel")] public int ManaCostPerLevel { get; set; }
        [Name("ManaPerSecond")] public int ManaPerSecond { get; set; }
        [Name("PowerDisplayID")] public int PowerDisplayId { get; set; }
        [Name("AltPowerBarID")] public int AltPowerBarId { get; set; }
        [Name("PowerCostPct")] public double PowerCostPct { get; set; }
        [Name("PowerCostMaxPct")] public double PowerCostMaxPct { get; set; }
        [Name("PowerPctPerSecond")] public double PowerPctPerSecond { get; set; }
        [Name("PowerType")] public int PowerType { get; set; }
        [Name("RequiredAuraSpellID")] public int RequiredAuraSpellId { get; set; }
        [Name("OptionalCost")] public int OptionalCost { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
    }

    public class Talent
    {
        [Name("ID")] public int Id { get; set; }
        [Name("Description_lang")] public string DescriptionLang { get; set; }
        [Name("TierID")] public int TierId { get; set; }
        [Name("Flags")] public int Flags { get; set; }
        [Name("ColumnIndex")] public int ColumnIndex { get; set; }
        [Name("ClassID")] public int ClassId { get; set; }
        [Name("SpecID")] public int SpecId { get; set; }
        [Name("SpellID")] public int SpellId { get; set; }
        [Name("OverridesSpellID")] public int OverridesSpellId { get; set; }
        [Name("CategoryMask[0]")] public int CategoryMask0 { get; set; }
        [Name("CategoryMask[1]")] public int CategoryMask1 { get; set; }
    }
}