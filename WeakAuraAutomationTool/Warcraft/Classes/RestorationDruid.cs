﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class RestorationDruid : Druid
    {
        public Spell Abundance = new Spell("Abundance", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 207383 }, new[] { 1 }, 1, 132124, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell BalanceAffinity = new Spell("Balance Affinity", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 197632 }, new[] { 1 }, 7, 236156, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell CenarionWard = new Spell("Cenarion Ward", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 102351 }, new[] { 0 }, 3, 132137, new double[] { 0 }, new double[] { 30 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Cultivation = new Spell("Cultivation", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 200390 }, new[] { 1 }, 14, 136041, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Efflorescence = new Spell("Efflorescence", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 145205 }, new[] { 39 }, 0, 134222, new double[] { 0 }, new double[] { 30 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData((SpellEffectName)0, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None) });
        public Spell FeralAffinity = new Spell("Feral Affinity", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 197490 }, new[] { 1 }, 8, 611425, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModPowerRegenPercent), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell Flourish = new Spell("Flourish", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 197721 }, new[] { 1 }, 21, 538743, new double[] { 0 }, new double[] { 8 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.HasteRanged), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell), new SpellEffectData(SpellEffectName.ScriptEffect, EffectAuraType.None) });
        public Spell Germination = new Spell("Germination", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 155675 }, new[] { 0 }, 20, 1033478, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell GuardianAffinity = new Spell("Guardian Affinity", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 197491 }, new[] { 1 }, 9, 611424, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell IncarnationTreeOfLife = new Spell("Incarnation: Tree of Life", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 33891 }, new[] { 1 }, 15, 236157, new double[] { 180 }, new double[] { -0.001 }, false, 0, new[] { "Incarnation" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunity), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModShapeshift), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy) });
        public Spell InnerPeace = new Spell("Inner Peace", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 197073 }, new[] { 0 }, 16, 132123, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell Innervate = new Spell("Innervate", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 29166, 326228 }, new[] { 42, 52 }, 0, 136048, new double[] { 0 }, new double[] { 10 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)423), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Ironbark = new Spell("Ironbark", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 102342, 197061 }, new[] { 12, 56 }, 0, 572025, new double[] { 0 }, new double[] { 12 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModHealingReceived) });
        public Spell LeatherSpecialization = new Spell("Leather Specialization", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 86093 }, new[] { 27 }, 0, 132646, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTotalStatPercentage) });
        public Spell Lifebloom = new Spell("Lifebloom", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 33763 }, new[] { 21 }, 0, 134206, new double[] { 0 }, new double[] { 15 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicHeal) });
        public Spell MasteryHarmony = new Spell("Mastery: Harmony", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 77495 }, new[] { 10 }, 0, 136044, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell NaturesCure = new Spell("Nature's Cure", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 88423 }, new[] { 19 }, 0, 236288, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dispel, EffectAuraType.None) });
        public Spell NaturesSwiftness = new Spell("Nature's Swiftness", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 132158 }, new[] { 58 }, 0, 136076, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIgnoreShapeshift) });
        public Spell Nourish = new Spell("Nourish", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 50464 }, new[] { 0 }, 2, 236162, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Heal, EffectAuraType.None) });
        public Spell OmenOfClarity = new Spell("Omen of Clarity", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 113043 }, new[] { 33 }, 0, 136017, new double[] { }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell Overgrowth = new Spell("Overgrowth", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 203651 }, new[] { 0 }, 18, 1408836, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Photosynthesis = new Spell("Photosynthesis", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 274902 }, new[] { 0 }, 19, 464030, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Rejuvenation = new Spell("Rejuvenation", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 774, 231040 }, new[] { 10, 26 }, 0, 136081, new double[] { 0 }, new double[] { 12 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicHeal) });
        public Spell SoulOfTheForest = new Spell("Soul of the Forest", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 158478 }, new[] { 0 }, 13, 236160, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell SpringBlossoms = new Spell("Spring Blossoms", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 207385 }, new[] { 1 }, 17, 306845, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Sunfire = new Spell("Sunfire", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 93402, 231050 }, new[] { 23, 32 }, 0, 236216, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None) });
        public Spell Swiftmend = new Spell("Swiftmend", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 18562 }, new[] { 11 }, 0, 134914, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Heal, EffectAuraType.None) });
        public Spell Tranquility = new Spell("Tranquility", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 740 }, new[] { 37 }, 0, 136107, new double[] { 180 }, new double[] { 8 }, false, 0, new[] { "Healing (Group) - Spell" }, new[] { new SpellEffectData(SpellEffectName.ApplyAreaAuraParty, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell) });
        public Spell UrsolsVortex = new Spell("Ursol's Vortex", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 102793 }, new[] { 28 }, 0, 571588, new double[] { 0 }, new double[] { 10 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell WildGrowth = new Spell("Wild Growth", ClassType.Druid, ClassSpec.RestorationDruid, new[] { 48438, 328025 }, new[] { 34, 49 }, 0, 236153, new double[] { 10 }, new double[] { 7 }, false, 40, new[] { "Wild Growth" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicHeal), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
    }
}