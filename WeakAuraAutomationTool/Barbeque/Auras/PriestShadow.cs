using System;
using System.Collections.Generic;
using System.Text;

using WeakAuraAutomationTool.Warcraft;
using WeakAuraAutomationTool.Warcraft.Classes;
using WeakAuraAutomationTool.WeakAuras;

namespace WeakAuraAutomationTool.Barbeque.Auras
{
    internal static class PriestShadow
    {
        public static void Generate(WeakAura wa)
        {
            var shadow = new Shadow();

            var builder = new SpecBuilder(ClassSpec.Shadow);
            // todo: MindVision Alert

            builder.AddUtility(
                shadow.Dispersion.Buff(),
                shadow.Silence.DeBuff(),
                shadow.PsychicHorror.DeBuff(),
                shadow.DesperatePrayer,
                shadow.Fade.Buff(),
                shadow.LeapOfFaith,
                shadow.MassDispel,
                shadow.PsychicScream,
                shadow.MindBomb.DeBuff()
            ).AddCoreRotation(
                shadow.VampiricTouch.DoT().Passive(),
                shadow.ShadowWordPain.DoT().Passive(),
                shadow.DevouringPlague.DoT().Passive(),
                shadow.MindBlast.BigStacks(),
                // todo: Associate with Death and Madness
                shadow.ShadowWordDeath
            ).AddCoreCooldowns(
                // todo: will this become Void Bolt?
                shadow.VoidEruption.Buff(),
                shadow.Shadowfiend.Buff(),
                shadow.PowerInfusion.Buff(),
                shadow.VampiricEmbrace.Buff(),
                // todo: shadow.SearingNightmare,
                shadow.ShadowCrash,
                shadow.Damnation,
                shadow.VoidTorrent,
                shadow.SurrenderToMadness.Buff()
            ).AddMobility(
                shadow.PowerWordShield.AssociateAura(shadow.BodyAndSoul),
                shadow.PurifyDisease,
                shadow.DispelMagic
            ).AddCombatBuffs(
                shadow.AncientMadness.Buff().Passive(),
                shadow.Voidform.Buff().Passive(),
                shadow.Levitate.Buff().Passive(),
                shadow.ShackleUndead.Passive().DeBuff(),
                shadow.MindSoothe.Passive().DeBuff(),
                shadow.TwistOfFate.Passive().Buff(),
                shadow.HungeringVoid.Passive().DeBuff()
            ).AddAlerts(
                shadow.PowerWordFortitude.Passive().MissingBuff(),
                shadow.Shadowform.Buff().Passive().MissingBuff(),
                shadow.Voidform.Buff().Passive(),
                shadow.Dispersion.Buff().Passive(),
                shadow.MindControl.Buff().Passive(),
                shadow.DeathAndMadness.Passive().DeBuff(),
                shadow.UnfurlingDarkness.Passive().Buff(),
                shadow.SurrenderToMadness.Passive().Buff()
            ).Build(wa);
        }
    }
}