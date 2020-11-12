﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class Balance : Druid
    {
        public Spell AstralInfluence = new Spell("Astral Influence", ClassType.Druid, ClassSpec.Balance, new[] { 197524 }, new[] { 27 }, 0, 1029587, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)153), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackerRangedCritChance), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModManaRegenFromStat) });
        public Spell AstralPower = new Spell("Astral Power", ClassType.Druid, ClassSpec.Balance, new[] { 197911 }, new[] { 10 }, 0, 135724, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackerSpellCritChance) });
        public Spell CelestialAlignment = new Spell("Celestial Alignment", ClassType.Druid, ClassSpec.Balance, new[] { 194223 }, new[] { 39 }, 0, 136060, new double[] { 0 }, new double[] { 20 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MeleeSlow) });
        public Spell Eclipse = new Spell("Eclipse", ClassType.Druid, ClassSpec.Balance, new[] { 79577, 328021 }, new[] { 11, 47 }, 0, 236152, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell FeralAffinity = new Spell("Feral Affinity", ClassType.Druid, ClassSpec.Balance, new[] { 202157 }, new[] { 1 }, 7, 611425, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModPowerRegenPercent), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell ForceOfNature = new Spell("Force of Nature", ClassType.Druid, ClassSpec.Balance, new[] { 205636 }, new[] { 1 }, 3, 132129, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell FuryOfElune = new Spell("Fury of Elune", ClassType.Druid, ClassSpec.Balance, new[] { 202770 }, new[] { 0 }, 20, 132123, new double[] { 0 }, new double[] { 8 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicEnergize), new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell GuardianAffinity = new Spell("Guardian Affinity", ClassType.Druid, ClassSpec.Balance, new[] { 197491 }, new[] { 1 }, 8, 611424, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell Innervate = new Spell("Innervate", ClassType.Druid, ClassSpec.Balance, new[] { 29166 }, new[] { 42 }, 0, 136048, new double[] { 0 }, new double[] { 10 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)423) });
        public Spell LeatherSpecialization = new Spell("Leather Specialization", ClassType.Druid, ClassSpec.Balance, new[] { 86104 }, new[] { 27 }, 0, 132649, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTotalStatPercentage) });
        public Spell MasteryTotalEclipse = new Spell("Mastery: Total Eclipse", ClassType.Druid, ClassSpec.Balance, new[] { 326085 }, new[] { 10 }, 0, 236151, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell Moonfire = new Spell("Moonfire", ClassType.Druid, ClassSpec.Balance, new[] { 328023 }, new[] { 33 }, 0, 136096, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell MoonkinForm = new Spell("Moonkin Form", ClassType.Druid, ClassSpec.Balance, new[] { 24858, 231042 }, new[] { 21, 37 }, 0, 136036, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunity), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackerMeleeCritChance), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModBaseResistancePct), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseHealthPercent), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModShapeshift), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell NaturesBalance = new Spell("Nature's Balance", ClassType.Druid, ClassSpec.Balance, new[] { 202430 }, new[] { 0 }, 1, 132113, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicEnergize) });
        public Spell NewMoon = new Spell("New Moon", ClassType.Druid, ClassSpec.Balance, new[] { 274281 }, new[] { 0 }, 21, 1392545, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell RemoveCorruption = new Spell("Remove Corruption", ClassType.Druid, ClassSpec.Balance, new[] { 2782 }, new[] { 19 }, 0, 135952, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dispel, EffectAuraType.None) });
        public Spell ShapeshiftForm = new Spell("Shapeshift Form", ClassType.Druid, ClassSpec.Balance, new[] { 228545 }, new[] { 1 }, 0, 132115, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell ShootingStars = new Spell("Shooting Stars", ClassType.Druid, ClassSpec.Balance, new[] { 202342 }, new[] { 49 }, 0, 631519, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy) });
        public Spell SolarBeam = new Spell("Solar Beam", ClassType.Druid, ClassSpec.Balance, new[] { 78675 }, new[] { 26 }, 0, 252188, new double[] { 60 }, new double[] { 8 }, false, 40, new[] { "Solar Beam" }, new[] { new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None), new SpellEffectData(SpellEffectName.PersistentAreaAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell Solstice = new Spell("Solstice", ClassType.Druid, ClassSpec.Balance, new[] { 343647 }, new[] { 0 }, 19, 1392544, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell SoulOfTheForest = new Spell("Soul of the Forest", ClassType.Druid, ClassSpec.Balance, new[] { 114107 }, new[] { 0 }, 13, 236160, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell Starfall = new Spell("Starfall", ClassType.Druid, ClassSpec.Balance, new[] { 191034, 327541 }, new[] { 34, 54 }, 0, 236168, new double[] { 0 }, new double[] { 8 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AreaTrigger), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.CastWhileWalking), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.HealAbsorbTest), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy) });
        public Spell Starfire = new Spell("Starfire", ClassType.Druid, ClassSpec.Balance, new[] { 194153 }, new[] { 10 }, 0, 135753, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.ScriptEffect, EffectAuraType.None) });
        public Spell Starlord = new Spell("Starlord", ClassType.Druid, ClassSpec.Balance, new[] { 202345 }, new[] { 0 }, 14, 462651, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Starsurge = new Spell("Starsurge", ClassType.Druid, ClassSpec.Balance, new[] { 78674, 328022 }, new[] { 12, 58 }, 0, 135730, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell StellarDrift = new Spell("Stellar Drift", ClassType.Druid, ClassSpec.Balance, new[] { 202354 }, new[] { 0 }, 16, 236168, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell StellarFlare = new Spell("Stellar Flare", ClassType.Druid, ClassSpec.Balance, new[] { 202347 }, new[] { 0 }, 18, 1052602, new double[] { 0 }, new double[] { 24 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDamage), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Sunfire = new Spell("Sunfire", ClassType.Druid, ClassSpec.Balance, new[] { 93402, 231050 }, new[] { 23, 32 }, 0, 236216, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None) });
        public Spell TwinMoons = new Spell("Twin Moons", ClassType.Druid, ClassSpec.Balance, new[] { 279620 }, new[] { 0 }, 17, 136096, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Typhoon = new Spell("Typhoon", ClassType.Druid, ClassSpec.Balance, new[] { 132469 }, new[] { 28 }, 0, 236170, new double[] { 30 }, new double[] { }, false, 15, new[] { "Typhoon" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell WarriorOfElune = new Spell("Warrior of Elune", ClassType.Druid, ClassSpec.Balance, new[] { 202425 }, new[] { 0 }, 2, 135900, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell Wrath = new Spell("Wrath", ClassType.Druid, ClassSpec.Balance, new[] { 190984 }, new[] { 1 }, 0, 535045, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });

        // Todo:
        public Spell SolarEclipse = new Spell("Eclipse (Solar)", ClassType.Druid, ClassSpec.Balance, 48517, 0);
        public Spell LunarEclipse = new Spell("Eclipse (Lunar)", ClassType.Druid, ClassSpec.Balance, 207383, 0);
    }
}