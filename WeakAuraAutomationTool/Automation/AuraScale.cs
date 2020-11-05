using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.WeakAuras;
using WeakAuraAutomationTool.WeakAuras.Data;

namespace WeakAuraAutomationTool.Automation
{
    internal static class AuraScale
    {
        public static Aura SetSize(this Aura aura, int width, int height)
        {
            aura.Width = width;
            aura.Height = height;

            return aura;
        }

        public static List<Aura> SetSize(this List<Aura> auras, int width, int height)
        {
            foreach (var aura in auras)
            {
                aura.Width = width;
                aura.Height = height;
            }

            return auras;
        }
    }
}