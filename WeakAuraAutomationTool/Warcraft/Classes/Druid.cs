﻿namespace WeakAuraAutomationTool.Warcraft.Classes
{
    public class Druid
    {
        public Spell AbolishCorruption = new Spell("Abolish Corruption", ClassType.Druid, ClassSpec.Spell, new[] { 236024 }, new[] { 14 }, 0, 136068, new double[] { 0 }, new double[] { 6 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ObsModHealth), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicTriggerSpell) });
        public Spell Abundance = new Spell("Abundance", ClassType.Druid, ClassSpec.Spell, new[] { 207640 }, new[] { 1 }, 0, 132124, new double[] { }, new double[] { 30 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell AquaticForm = new Spell("Aquatic Form", ClassType.Druid, ClassSpec.Spell, new[] { 276012 }, new[] { 17 }, 0, 132112, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell AquaticFormPassive = new Spell("Aquatic Form Passive", ClassType.Druid, ClassSpec.Spell, new[] { 5421 }, new[] { 1 }, 0, 132112, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSwimSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.WaterBreathing) });
        public Spell AstralCommunion = new Spell("Astral Communion", ClassType.Druid, ClassSpec.Spell, new[] { 202359 }, new[] { 1 }, 0, 611423, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None) });
        public Spell AstralForm = new Spell("Astral Form", ClassType.Druid, ClassSpec.Spell, new[] { 114302 }, new[] { 1 }, 0, 254087, new double[] { }, new double[] { -0.001 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell BalanceAffinity = new Spell("Balance Affinity", ClassType.Druid, ClassSpec.Spell, new[] { 197488 }, new[] { 1 }, 7, 236156, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell Barkskin = new Spell("Barkskin", ClassType.Druid, ClassSpec.Spell, new[] { 22812, 327993 }, new[] { 24, 44 }, 0, 136097, new double[] { 0 }, new double[] { 8 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ReducePushback) });
        public Spell BearForm = new Spell("Bear Form", ClassType.Druid, ClassSpec.Spell, new[] { 5487, 106829, 106899 }, new[] { 1, 8 }, 0, 132276, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunity), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackerMeleeCritChance), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModBaseResistancePct), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModExpertise), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIgnoreShapeshift), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModShapeshift), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell BearFormPassive = new Spell("Bear Form Passive", ClassType.Druid, ClassSpec.Spell, new[] { 1178 }, new[] { 1 }, 0, 132276, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModRageFromDamageDealt), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTotalStatPercentage) });
        public Spell BearFormPassive2 = new Spell("Bear Form Passive 2", ClassType.Druid, ClassSpec.Spell, new[] { 21178 }, new[] { 1 }, 0, 132276, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModThreat), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell Berserk = new Spell("Berserk", ClassType.Druid, ClassSpec.Spell, new[] { 279526 }, new[] { 19 }, 0, 236149, new double[] { 180 }, new double[] { 5 }, false, 0, new[] { "Berserk" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell CatForm = new Spell("Cat Form", ClassType.Druid, ClassSpec.Spell, new[] { 768, 3025 }, new[] { 1, 5 }, 0, 132115, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.HasteRanged), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunity), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAutoattackDamage), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIgnoreShapeshift), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModShapeshift), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell Cyclone = new Spell("Cyclone", ClassType.Druid, ClassSpec.Spell, new[] { 33786 }, new[] { 48 }, 0, 136022, new double[] { 0 }, new double[] { 6 }, false, 20, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModHealingPct), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SchoolImmunity) });
        public Spell Dash = new Spell("Dash", ClassType.Druid, ClassSpec.Spell, new[] { 1850, 219092 }, new[] { 6, 15 }, 0, 132120, new double[] { 120, 180 }, new double[] { 10 }, false, 0, new[] { "Speed" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell DemoralizingRoar = new Spell("Demoralizing Roar", ClassType.Druid, ClassSpec.Spell, new[] { 201664 }, new[] { 19 }, 0, 132117, new double[] { 0 }, new double[] { 8 }, true, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentDone) });
        public Spell DisplacerBeast = new Spell("Displacer Beast", ClassType.Druid, ClassSpec.Spell, new[] { 102280, 137452 }, new[] { 1 }, 0, 538514, new double[] { 0 }, new double[] { 2 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.Leap, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell DreamOfCenarius = new Spell("Dream of Cenarius", ClassType.Druid, ClassSpec.Spell, new[] { 145162, 158497, 158501, 158504 }, new[] { 1 }, 0, 132123, new double[] { }, new double[] { 40 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIgnoreShapeshift), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell Dreamwalk = new Spell("Dreamwalk", ClassType.Druid, ClassSpec.Spell, new[] { 293887 }, new[] { 10 }, 0, 135763, new double[] { 0 }, new double[] { }, false, 0, new[] { "Astral Recall" }, new[] { new SpellEffectData((SpellEffectName)203, EffectAuraType.None), new SpellEffectData(SpellEffectName.RitualBase, EffectAuraType.None) });
        public Spell EnragedMaim = new Spell("Enraged Maim", ClassType.Druid, ClassSpec.Spell, new[] { 236025, 236026 }, new[] { 25, 28 }, 0, 132134, new double[] { 0 }, new double[] { 5 }, true, 10, new[] { "Mez", "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell EnragedMangle = new Spell("Enraged Mangle", ClassType.Druid, ClassSpec.Spell, new[] { 202085 }, new[] { 10 }, 0, 132135, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.WeaponDamage, EffectAuraType.None) });
        public Spell EntanglingRoots = new Spell("Entangling Roots", ClassType.Druid, ClassSpec.Spell, new[] { 339, 235963, 343238 }, new[] { 4, 15, 56 }, 0, 136100, new double[] { 0 }, new double[] { 30 }, false, 35, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModHitChance), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModRoot2), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDamage) });
        public Spell FerociousBite = new Spell("Ferocious Bite", ClassType.Druid, ClassSpec.Spell, new[] { 22568, 213826 }, new[] { 3, 7 }, 0, 132127, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.PowerBurn, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Flap = new Spell("Flap", ClassType.Druid, ClassSpec.Spell, new[] { 164862 }, new[] { 21 }, 0, 132925, new double[] { 0 }, new double[] { 15 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.FeatherFall), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Hover), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.SuppressTransforms), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.WaterWalk) });
        public Spell FlightForm = new Spell("Flight Form", ClassType.Druid, ClassSpec.Spell, new[] { 165962, 276029 }, new[] { 24, 30 }, 0, 132128, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell ForceOfNature = new Spell("Force of Nature", ClassType.Druid, ClassSpec.Spell, new[] { 205644, 248280 }, new[] { 1 }, 0, 132129, new double[] { 8 }, new double[] { 10, 15 }, false, 40, new[] { "Taunt/Detaunt", "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTaunt), new SpellEffectData(SpellEffectName.AttackMe, EffectAuraType.None), new SpellEffectData(SpellEffectName.Summon, EffectAuraType.None) });
        public Spell FortifiedBark = new Spell("Fortified Bark", ClassType.Druid, ClassSpec.Spell, new[] { 203453 }, new[] { 1 }, 0, 134439, new double[] { }, new double[] { 12 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModAttackerSpellAndWeaponCritChance) });
        public Spell FreedomOfTheHerd = new Spell("Freedom of the Herd", ClassType.Druid, ClassSpec.Spell, new[] { 213200 }, new[] { 1 }, 0, 464343, new double[] { }, new double[] { }, true, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell FurySwipes = new Spell("Fury Swipes", ClassType.Druid, ClassSpec.Spell, new[] { 203197 }, new[] { 1 }, 0, 1033474, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell Gore = new Spell("Gore", ClassType.Druid, ClassSpec.Spell, new[] { 93622 }, new[] { 1 }, 0, 132135, new double[] { }, new double[] { 10 }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell Growl = new Spell("Growl", ClassType.Druid, ClassSpec.Spell, new[] { 6795 }, new[] { 9 }, 0, 132270, new double[] { 8 }, new double[] { 3 }, false, 30, new[] { "Taunt/Detaunt" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModTaunt), new SpellEffectData(SpellEffectName.AttackMe, EffectAuraType.None) });
        public Spell HeartOfTheWild = new Spell("Heart of the Wild", ClassType.Druid, ClassSpec.Spell, new[] { 319454 }, new[] { 0 }, 12, 135879, new double[] { 300 }, new double[] { 45 }, false, 0, new[] { "Heart of the Wild" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Hibernate = new Spell("Hibernate", ClassType.Druid, ClassSpec.Spell, new[] { 2637 }, new[] { 38 }, 0, 136090, new double[] { 0 }, new double[] { 40 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun) });
        public Spell IncarnationChosenOfElune = new Spell("Incarnation: Chosen of Elune", ClassType.Druid, ClassSpec.Spell, new[] { 102560 }, new[] { 1 }, 15, 571586, new double[] { 180 }, new double[] { 30 }, false, 0, new[] { "Incarnation" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MeleeSlow) });
        public Spell IntimidatingRoar = new Spell("Intimidating Roar", ClassType.Druid, ClassSpec.Spell, new[] { 236748 }, new[] { 16 }, 0, 132117, new double[] { 0 }, new double[] { 3 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModFear), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModRoot2) });
        public Spell Ironfur = new Spell("Ironfur", ClassType.Druid, ClassSpec.Spell, new[] { 192081 }, new[] { 18 }, 0, 1378702, new double[] { 0 }, new double[] { 7 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, (EffectAuraType)268) });
        public Spell JungleStalker = new Spell("Jungle Stalker", ClassType.Druid, ClassSpec.Spell, new[] { 252071 }, new[] { 1 }, 0, 642579, new double[] { }, new double[] { 30 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell Lifebloom = new Spell("Lifebloom", ClassType.Druid, ClassSpec.Spell, new[] { 33778, 188550, 290754 }, new[] { 14, 18, 26 }, 0, 134206, new double[] { 0 }, new double[] { 15 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicHeal), new SpellEffectData(SpellEffectName.Heal, EffectAuraType.None) });
        public Spell LunarBeam = new Spell("Lunar Beam", ClassType.Druid, ClassSpec.Spell, new[] { 204066 }, new[] { 1 }, 0, 136057, new double[] { 0 }, new double[] { 8.5 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None) });
        public Spell Maim = new Spell("Maim", ClassType.Druid, ClassSpec.Spell, new[] { 168877, 168878, 168879, 168880, 168881, 203123, 203126 }, new[] { 28, 30 }, 0, 132134, new double[] { 10 }, new double[] { 0 }, false, 10, new[] { "Mez", "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.WeaponDamage, EffectAuraType.None) });
        public Spell MalornesSwiftness = new Spell("Malorne's Swiftness", ClassType.Druid, ClassSpec.Spell, new[] { 236012, 236147 }, new[] { 1 }, 0, 1394966, new double[] { }, new double[] { }, true, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy) });
        public Spell Mangle = new Spell("Mangle", ClassType.Druid, ClassSpec.Spell, new[] { 33917 }, new[] { 8 }, 0, 132135, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell MassEntanglement = new Spell("Mass Entanglement", ClassType.Druid, ClassSpec.Spell, new[] { 102359 }, new[] { 1 }, 11, 538515, new double[] { 0 }, new double[] { 30 }, false, 30, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModRoot2), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDamage) });
        public Spell MightyBash = new Spell("Mighty Bash", ClassType.Druid, ClassSpec.Spell, new[] { 5211 }, new[] { 1 }, 10, 132114, new double[] { 60 }, new double[] { 4 }, false, 5, new[] { "Stun" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStun) });
        public Spell Moonfire = new Spell("Moonfire", ClassType.Druid, ClassSpec.Spell, new[] { 8921, 155625, 326646 }, new[] { 1, 2, 14 }, 0, 136096, new double[] { 0 }, new double[] { 16 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDamage), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell MoonkinForm = new Spell("Moonkin Form", ClassType.Druid, ClassSpec.Spell, new[] { 190024, 197625 }, new[] { 1 }, 0, 136036, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunity), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModBaseResistancePct), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseHealthPercent), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModShapeshift), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell MountForm = new Spell("Mount Form", ClassType.Druid, ClassSpec.Spell, new[] { 210053 }, new[] { 10 }, 0, 1394966, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunity), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMinimumSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModShapeshift), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSpeedAlways), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.UseNormalMovementSpeed) });
        public Spell NaturesCure = new Spell("Nature's Cure", ClassType.Druid, ClassSpec.Spell, new[] { 311698 }, new[] { 14 }, 0, 236288, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dispel, EffectAuraType.None) });
        public Spell NaturesVigil = new Spell("Nature's Vigil", ClassType.Druid, ClassSpec.Spell, new[] { 124974, 124988, 124991 }, new[] { 1 }, 0, 236764, new double[] { 0 }, new double[] { 30 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy), new SpellEffectData(SpellEffectName.Heal, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Overrun = new Spell("Overrun", ClassType.Druid, ClassSpec.Spell, new[] { 202246 }, new[] { 1 }, 0, 1408833, new double[] { 0 }, new double[] { }, true, 25, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Charge, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell OwlkinFrenzy = new Spell("Owlkin Frenzy", ClassType.Druid, ClassSpec.Spell, new[] { 157228 }, new[] { 16 }, 0, 236163, new double[] { }, new double[] { 10 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier) });
        public Spell PredatorySwiftness = new Spell("Predatory Swiftness", ClassType.Druid, ClassSpec.Spell, new[] { 69369 }, new[] { 1 }, 0, 132185, new double[] { }, new double[] { 12 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIgnoreShapeshift) });
        public Spell PrimalVitality = new Spell("Primal Vitality", ClassType.Druid, ClassSpec.Spell, new[] { 202808 }, new[] { 1 }, 0, 514640, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell ProtectorOfThePack = new Spell("Protector of the Pack", ClassType.Druid, ClassSpec.Spell, new[] { 202043 }, new[] { 50 }, 0, 136088, new double[] { }, new double[] { }, true, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.TriggerSpellOnHealthBelowPct) });
        public Spell Prowl = new Spell("Prowl", ClassType.Druid, ClassSpec.Spell, new[] { 5215, 102547 }, new[] { 1, 13 }, 0, 514640, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData((SpellEffectName)203, EffectAuraType.None), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AnimReplacementSet), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSpeedAlways), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModStealth), new SpellEffectData(SpellEffectName.Sanctuary2, EffectAuraType.None) });
        public Spell Quicksilver = new Spell("Quicksilver", ClassType.Druid, ClassSpec.Spell, new[] { 197479, 197481 }, new[] { 1 }, 0, 348567, new double[] { }, new double[] { 3 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed) });
        public Spell RagingFrenzy = new Spell("Raging Frenzy", ClassType.Druid, ClassSpec.Spell, new[] { 236153, 236665 }, new[] { 1 }, 0, 132091, new double[] { }, new double[] { }, true, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None) });
        public Spell Rebirth = new Spell("Rebirth", ClassType.Druid, ClassSpec.Spell, new[] { 20484, 328024 }, new[] { 29, 46 }, 0, 136080, new double[] { 600 }, new double[] { }, false, 40, new[] { "Resurrection (Full)" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Resurrect, EffectAuraType.None) });
        public Spell Regrowth = new Spell("Regrowth", ClassType.Druid, ClassSpec.Spell, new[] { 8936, 231032 }, new[] { 3, 52 }, 0, 136085, new double[] { 0 }, new double[] { 12 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicHeal), new SpellEffectData(SpellEffectName.Heal, EffectAuraType.None) });
        public Spell RejuvenationGermination = new Spell("Rejuvenation (Germination)", ClassType.Druid, ClassSpec.Spell, new[] { 155777 }, new[] { 1 }, 0, 1033478, new double[] { }, new double[] { 12 }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicHeal) });
        public Spell Renewal = new Spell("Renewal", ClassType.Druid, ClassSpec.Spell, new[] { 108238 }, new[] { 1 }, 5, 136059, new double[] { 0 }, new double[] { }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.HealPct, EffectAuraType.None) });
        public Spell RestorationAffinity = new Spell("Restoration Affinity", ClassType.Druid, ClassSpec.Spell, new[] { 197492 }, new[] { 1 }, 9, 236157, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddPctModifier), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells) });
        public Spell Revive = new Spell("Revive", ClassType.Druid, ClassSpec.Spell, new[] { 50769 }, new[] { 13 }, 0, 132132, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Resurrect, EffectAuraType.None) });
        public Spell RoaringSpeed = new Spell("Roaring Speed", ClassType.Druid, ClassSpec.Spell, new[] { 236148 }, new[] { 1 }, 0, 463283, new double[] { }, new double[] { }, true, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.AddFlatModifier) });
        public Spell Shapemender = new Spell("Shapemender", ClassType.Druid, ClassSpec.Spell, new[] { 200308 }, new[] { 1 }, 0, 236161, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData((SpellEffectName)0, EffectAuraType.None), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ProcTriggerSpell) });
        public Spell ShapemenderEffect = new Spell("Shapemender Effect", ClassType.Druid, ClassSpec.Spell, new[] { 200310 }, new[] { 1 }, 0, 236161, new double[] { }, new double[] { }, true, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.HealPct, EffectAuraType.None) });
        public Spell Shred = new Spell("Shred", ClassType.Druid, ClassSpec.Spell, new[] { 5221 }, new[] { 5 }, 0, 136231, new double[] { 0 }, new double[] { }, false, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell SkullBash = new Spell("Skull Bash", ClassType.Druid, ClassSpec.Spell, new[] { 221514 }, new[] { 26 }, 0, 236946, new double[] { 15 }, new double[] { }, false, 13, new[] { "Skull Bash" }, new[] { new SpellEffectData(SpellEffectName.Charge, EffectAuraType.None) });
        public Spell SolarBeam = new Spell("Solar Beam", ClassType.Druid, ClassSpec.Spell, new[] { 311930 }, new[] { 30 }, 0, 252188, new double[] { 60 }, new double[] { 8 }, false, 50, new[] { "Solar Beam" }, new[] { new SpellEffectData(SpellEffectName.CreateAreaTrigger, EffectAuraType.None), new SpellEffectData(SpellEffectName.PersistentAreaAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell Soothe = new Spell("Soothe", ClassType.Druid, ClassSpec.Spell, new[] { 2908 }, new[] { 41 }, 0, 132163, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dispel, EffectAuraType.None) });
        public Spell StampedingRoar = new Spell("Stampeding Roar", ClassType.Druid, ClassSpec.Spell, new[] { 77761, 77764, 106898 }, new[] { 22, 43 }, 0, 463283, new double[] { 120 }, new double[] { 8 }, false, 10, new[] { "Stampeding Roar" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.ScriptEffect, EffectAuraType.None) });
        public Spell Starfall = new Spell("Starfall", ClassType.Druid, ClassSpec.Spell, new[] { 50286 }, new[] { 29 }, 0, 136116, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Starfire = new Spell("Starfire", ClassType.Druid, ClassSpec.Spell, new[] { 197628 }, new[] { 1 }, 0, 135753, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell Starsurge = new Spell("Starsurge", ClassType.Druid, ClassSpec.Spell, new[] { 197626, 213797 }, new[] { 1, 14 }, 0, 135730, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell StrengthOfTheWild = new Spell("Strength of the Wild", ClassType.Druid, ClassSpec.Spell, new[] { 236716 }, new[] { 10 }, 0, 132136, new double[] { 0 }, new double[] { }, true, 5, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.DamageFromMaxHealthPct, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell Sunfire = new Spell("Sunfire", ClassType.Druid, ClassSpec.Spell, new[] { 197630 }, new[] { 1 }, 0, 236216, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell SurvivalInstincts = new Spell("Survival Instincts", ClassType.Druid, ClassSpec.Spell, new[] { 50322, 236156 }, new[] { 1, 18 }, 0, 236169, new double[] { 0 }, new double[] { 6 }, false, 15, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDamagePercentTaken), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None) });
        public Spell SwiftFlightFormPassive = new Spell("Swift Flight Form (Passive)", ClassType.Druid, ClassSpec.Spell, new[] { 40121 }, new[] { 27 }, 0, 132128, new double[] { }, new double[] { }, false, 0, new string[] { }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseVehicleFlightSpeed) });
        public Spell TeleportMoonglade = new Spell("Teleport: Moonglade", ClassType.Druid, ClassSpec.Spell, new[] { 18960, 293840 }, new[] { 12, 22 }, 0, 135758, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData((SpellEffectName)203, EffectAuraType.None), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSpellCritChanceSchool), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.OverrideActionbarSpells), new SpellEffectData(SpellEffectName.RitualBase, EffectAuraType.None), new SpellEffectData(SpellEffectName.TeleportUnits, EffectAuraType.None) });
        public Spell Thrash = new Spell("Thrash", ClassType.Druid, ClassSpec.Spell, new[] { 77758 }, new[] { 11 }, 0, 451161, new double[] { 0 }, new double[] { }, false, 8, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.Energize, EffectAuraType.None), new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell TigerDash = new Spell("Tiger Dash", ClassType.Druid, ClassSpec.Spell, new[] { 252216 }, new[] { 0 }, 4, 1817485, new double[] { 45 }, new double[] { 5 }, false, 0, new[] { "Speed" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.PeriodicDummy) });
        public Spell TravelForm = new Spell("Travel Form", ClassType.Druid, ClassSpec.Spell, new[] { 783, 159456, 165961 }, new[] { 10, 13, 20 }, 0, 132144, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.MechanicImmunity), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModMinimumSpeed), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModShapeshift), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModSpeedAlways), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.UseNormalMovementSpeed) });
        public Spell TreantForm = new Spell("Treant Form", ClassType.Druid, ClassSpec.Spell, new[] { 114282 }, new[] { 10 }, 0, 132145, new double[] { 0 }, new double[] { -0.001 }, false, 0, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModShapeshift) });
        public Spell Typhoon = new Spell("Typhoon", ClassType.Druid, ClassSpec.Spell, new[] { 61391 }, new[] { 1 }, 0, 135860, new double[] { }, new double[] { 6 }, false, 15, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModDecreaseSpeed), new SpellEffectData(SpellEffectName.KnockBack, EffectAuraType.None) });
        public Spell WildCharge = new Spell("Wild Charge", ClassType.Druid, ClassSpec.Spell, new[] { 16979, 49376, 102401, 102416, 102417 }, new[] { 0, 1 }, 6, 132183, new double[] { 15 }, new double[] { 0.5, 5 }, false, 25, new[] { "Feral Charge" }, new[] { new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.Dummy), new SpellEffectData(SpellEffectName.ApplyAura, EffectAuraType.ModIncreaseSwimSpeed), new SpellEffectData(SpellEffectName.Charge, EffectAuraType.None), new SpellEffectData(SpellEffectName.Dummy, EffectAuraType.None), new SpellEffectData(SpellEffectName.JumpDest, EffectAuraType.None), new SpellEffectData(SpellEffectName.LeapBack, EffectAuraType.None), new SpellEffectData(SpellEffectName.TriggerSpell, EffectAuraType.None) });
        public Spell Wrath = new Spell("Wrath", ClassType.Druid, ClassSpec.Spell, new[] { 5176 }, new[] { 1 }, 0, 535045, new double[] { 0 }, new double[] { }, false, 40, new[] { "uncategorized" }, new[] { new SpellEffectData(SpellEffectName.SchoolDamage, EffectAuraType.None) });
        public Spell YserasGift = new Spell("Ysera's Gift", ClassType.Druid, ClassSpec.Spell, new[] { 145109, 145110 }, new[] { 1 }, 0, 136041, new double[] { }, new double[] { }, false, 30, new string[] { }, new[] { new SpellEffectData(SpellEffectName.Heal, EffectAuraType.None) });
    }
}