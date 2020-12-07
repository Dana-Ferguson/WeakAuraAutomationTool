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

            builder.AddOverflow(
                shadow.PurifyDisease,
                shadow.DispelMagic,
                shadow.Dispersion.Buff(),
                shadow.DesperatePrayer,
                shadow.Fade.Buff(),
                shadow.LeapOfFaith,
                shadow.MassDispel,
                shadow.PsychicScream
            ).AddBottomBar(
                shadow.Silence.DeBuff(),
                shadow.PsychicHorror.DeBuff(),
                shadow.MindBomb.DeBuff(),
                shadow.VampiricEmbrace.Buff(),
                shadow.Fleshcraft.Buff()
            ).AddRightBar(
                shadow.Shadowfiend.Buff(),
                shadow.UnholyNova.DeBuff(),
                shadow.PowerInfusion.Buff(),
                // todo: shadow.SearingNightmare,
                shadow.SurrenderToMadness.Buff()
            ).AddCoreRotation(
                shadow.VampiricTouch.DoT().Passive(),
                shadow.ShadowWordPain.DoT().Passive(),
                shadow.MindBlast.BigStacks().AssociateAura(shadow.DarkThought).UseIcon(shadow.MindBlast),
                shadow.DevouringPlague.DoT().Passive(),
                shadow.VoidEruption.Buff(),
                // todo: Associate with Death and Madness
                shadow.ShadowWordDeath.AssociateAura(shadow.DeathAndMadness).UseIcon(shadow.ShadowWordDeath),
                shadow.Damnation,
                shadow.ShadowCrash,
                shadow.VoidTorrent
            ).AddCoreCooldowns(
            ).AddTopBar(
                shadow.Voidform.Buff().Passive(),
                shadow.DarkThought.Passive().Buff(),
                shadow.DeathAndMadness.Passive().DeBuff().UseIcon(shadow.MindBlast),
                shadow.BodyAndSoul.Passive().Buff().UseIcon(shadow.PowerWordShield),
                // shadow.AncientMadness.Buff().Passive(),
                // shadow.ShackleUndead.Passive().DeBuff(),
                // shadow.MindSoothe.Passive().DeBuff(),
                shadow.TwistOfFate.Passive().Buff(),
                shadow.HungeringVoid.Passive().DeBuff()
            ).AddAlerts(
                // shadow.PowerWordFortitude.Passive().MissingBuff(),
                shadow.Levitate.Buff().Passive(),
                shadow.Shadowform.Buff().Passive().MissingBuff(),
                shadow.Voidform.Buff().Passive(),
                shadow.Dispersion.Buff().Passive(),
                shadow.MindControl.Buff().Passive(),
                // shadow.DeathAndMadness.Passive().DeBuff(),
                shadow.UnfurlingDarkness.Passive().Buff(),
                shadow.SurrenderToMadness.Passive().Buff()
            ).Build(wa);
        }
    }
}