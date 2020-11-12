using System;
using System.Collections.Generic;
using System.Text;

using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class PriestDiscipline
    {
        public static void Generate(WeakAura wa)
        {
            var discipline = new Discipline();

            var builder = new SpecBuilder(ClassSpec.Discipline);
            // todo: MindVision Alert

            builder.AddOverflow(
                // Glow when health < 50%?
                discipline.DesperatePrayer,
                discipline.Fade.Buff(),
                discipline.AngelicFeather.AssociateAura(discipline.BodyAndSoul),
                discipline.LeapOfFaith,
                // How many dispels?
                discipline.MassDispel,
                // How many hit by scream?
                discipline.PsychicScream,
                discipline.ShiningForce.DeBuff()
            ).AddUtility(
                // Cooldowns
                discipline.PowerWordBarrier.Buff(),
                discipline.Shadowfiend.Buff(),
                discipline.PowerInfusion.Buff(),
                discipline.PainSuppression,
                discipline.Rapture.Buff(),
                discipline.Evangelism,
                discipline.SpiritShell.Buff()
            ).AddCoreRotation(
                discipline.Penance,
                // Purge the Wicked
                discipline.ShadowWordPain.DoT().Passive(),
                discipline.MindBlast.BigStacks(),
                discipline.ShadowWordDeath,
                discipline.PowerWordSolace,
                discipline.Schism.DeBuff(),
                discipline.PowerWordRadiance.Buff(),
                discipline.ShadowCovenant,
                discipline.Halo,
                discipline.DivineStar
            ).AddCoreCooldowns(
            ).AddMobility(
                // discipline.PowerWordShield.AssociateAura(discipline.BodyAndSoul),
                discipline.Purify,
                discipline.DispelMagic
            ).AddCombatBuffs(
                // Weakened Soul on Target? (Tracker for Group?)
                discipline.Levitate.Buff().Passive(),
                discipline.ShackleUndead.Passive().DeBuff(),
                discipline.MindSoothe.Passive().DeBuff()
            // discipline.HungeringVoid.Passive().DeBuff()
            ).AddAlerts(
                // todo: Atonement Tracker!!!!
                discipline.PowerWordFortitude.Passive().MissingBuff(),
                discipline.Rapture.Buff().Passive(),
                discipline.MindControl.Buff().Passive()
            // discipline.MindControl.Buff().Passive(),
            ).Build(wa);
        }
    }
}