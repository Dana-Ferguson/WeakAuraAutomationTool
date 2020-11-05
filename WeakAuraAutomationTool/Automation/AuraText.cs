using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.WeakAuras;
using WeakAuraAutomationTool.WeakAuras.Data;

namespace WeakAuraAutomationTool.Automation
{
    internal static class AuraText
    {
        public static void AddText(this Aura aura)
        {
            aura.SubRegions.Add(TextSubRegion());
        }

        public static SubRegion TextSubRegion()
        {
            return new SubRegion
            {
                Type = "subtext",
                RotateText = "NONE",
                TextAnchorPoint = "INNER_BOTTOMRIGHT",
                TextAutomaticWidth = "Auto",
                TextColor = new Color(1, 1, 1),
                TextFixedWidth = 64,
                TextFont = "Friz Quadrata TT",
                TextFontSize = 12,
                TextFontType = "OUTLINE",
                TextJustify = "CENTER",
                TextSelfPoint = "AUTO",
                TextShadowColor = new Color(0),
                TextShadowXOffset = 0,
                TextShadowYOffset = 0,
                TextText = "%s",
                TextTextFormatSFormat = "none",
                TextVisible = true,
                TextWordWrap = "WordWrap",
                // Defaults:
                AnchorXOffset = 0,
                AnchorYOffset = 0,
                Glow = false,
                GlowBorder = false,
                GlowColor = null,
                GlowFrequency = 0,
                GlowLength = 0,
                GlowLines = 0,
                GlowScale = 0,
                GlowThickness = 0,
                GlowType = "",
                GlowXOffset = 0,
                GlowYOffset = 0,
                UseGlowColor = false
            };
        }
    }
}