using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.WeakAuras;
using WeakAuraAutomationTool.WeakAuras.Data;

namespace WeakAuraAutomationTool.Automation
{
    internal static class AuraGlow
    {
        public static void AddGlow(this Aura aura, Color color = null)
        {
            // aura.SubRegions.Add(color == null ? GlowingSubRegion() : GlowingSubRegion(color));
            aura.SubRegions.Add(color == null ? AutoCastGlowingSubRegion() : AutoCastGlowingSubRegion(color));
        }

        private static SubRegion GlowingSubRegion(Color color)
        {
            var glow = AutoCastGlowingSubRegion();
            glow.GlowColor = color;
            glow.UseGlowColor = true;
            return glow;
        }

        private static SubRegion AutoCastGlowingSubRegion(Color color)
        {
            var glow = AutoCastGlowingSubRegion();
            glow.GlowColor = color;
            glow.UseGlowColor = true;
            return glow;
        }

        private static SubRegion AutoCastGlowingSubRegion()
        {
            return new SubRegion
            {
                Type = "subglow",
                Glow = true,
                GlowBorder = false,
                UseGlowColor = false,
                GlowColor = new Color(1, 1, 1),
                GlowFrequency = 0.25,
                GlowLength = 10,
                GlowLines = 8,
                GlowScale = 1,
                GlowThickness = 1,
                GlowType = "ACShine",
                GlowXOffset = 0,
                GlowYOffset = 0,
                // Defaults:
                AnchorXOffset = 0,
                AnchorYOffset = 0,
                RotateText = "",
                TextAnchorPoint = "",
                TextAutomaticWidth = "",
                TextColor = null,
                TextFixedWidth = 0,
                TextFont = "",
                TextFontSize = 0,
                TextFontType = "",
                TextJustify = "",
                TextSelfPoint = "",
                TextShadowColor = null,
                TextShadowXOffset = 0,
                TextShadowYOffset = 0,
                TextText = "",
                TextTextFormatSFormat = "",
                TextVisible = false,
                TextWordWrap = "",
            };
        }

        private static SubRegion GlowingSubRegion()
        {
            return new SubRegion
            {
                Type = "subglow",
                Glow = true,
                GlowBorder = false,
                UseGlowColor = false,
                GlowColor = new Color(1, 1, 1),
                GlowFrequency = 0.25,
                GlowLength = 10,
                GlowLines = 8,
                GlowScale = 1,
                GlowThickness = 1,
                GlowType = "buttonOverlay",
                GlowXOffset = 0,
                GlowYOffset = 0,
                // Defaults:
                AnchorXOffset = 0,
                AnchorYOffset = 0,
                RotateText = "",
                TextAnchorPoint = "",
                TextAutomaticWidth = "",
                TextColor = null,
                TextFixedWidth = 0,
                TextFont = "",
                TextFontSize = 0,
                TextFontType = "",
                TextJustify = "",
                TextSelfPoint = "",
                TextShadowColor = null,
                TextShadowXOffset = 0,
                TextShadowYOffset = 0,
                TextText = "",
                TextTextFormatSFormat = "",
                TextVisible = false,
                TextWordWrap = "",
            };
        }
    }
}