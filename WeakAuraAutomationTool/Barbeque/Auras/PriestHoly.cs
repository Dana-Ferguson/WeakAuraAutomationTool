using System;
using System.Collections.Generic;
using System.Text;

using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    public static class PriestHoly
    {
        public static void Generate(WeakAura wa)
        {
            var holy = new HolyPriest();

            var builder = new SpecBuilder(ClassSpec.HolyPriest);
            // todo: MindVision Alert

            builder.AddOverflow(
                // Glow when health < 50%?
                holy.DesperatePrayer,
                holy.Fade.Buff(),
                holy.AngelicFeather.AssociateAura(holy.BodyAndSoul),
                holy.LeapOfFaith,
                // How many dispels?
                holy.MassDispel,
                // How many hit by scream?
                holy.PsychicScream,
                holy.ShiningForce.DeBuff()
            ).AddUtility(
                // Cooldowns
                holy.DivineHymn.Buff(),
                holy.PowerInfusion.Buff(),
                holy.GuardianSpirit,
                holy.Apotheosis.Buff(),
                holy.HolyWordSalvation,
                holy.SymbolOfHope
            ).AddCoreRotation(
                holy.CircleOfHealing,
                holy.PrayerOfMending,
                holy.Halo,
                holy.DivineStar,
                holy.HolyWordSanctify,
                holy.HolyWordSerenity,
                holy.HolyWordChastise,
                holy.ShadowWordPain.DoT().Passive(),
                holy.ShadowWordDeath
            ).AddCoreCooldowns(
            ).AddMobility(
                // discipline.PowerWordShield.AssociateAura(discipline.BodyAndSoul),
                holy.Purify,
                holy.DispelMagic
            ).AddCombatBuffs(
                holy.Levitate.Passive().Buff(),
                holy.ShackleUndead.Passive().DeBuff(),
                holy.MindSoothe.Passive().DeBuff(),
                holy.PrayerCircle.Passive().Buff(),
                holy.Apotheosis.Passive().Buff(),
                holy.SurgeOfLight.Passive().Buff()
            ).AddAlerts(
                // Check part for the missing buff?
                holy.PowerWordFortitude.Passive().MissingBuff(),
                holy.MindControl.Passive().Buff(),
                holy.Apotheosis.Passive().Buff(),
                holy.SpiritOfRedemption.Passive().Buff()
            ).Build(wa);
        }
    }
}