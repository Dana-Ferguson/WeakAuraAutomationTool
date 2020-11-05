using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class SubRegion
    {
        [LuaField("anchorXOffset")] public double AnchorXOffset;
        [LuaField("anchorYOffset")] public double AnchorYOffset;
        [LuaField("glow")] public bool Glow;
        [LuaField("glowBorder")] public bool GlowBorder;
        [LuaField("glowColor")] public Color GlowColor;
        [LuaField("glowFrequency")] public double GlowFrequency;
        [LuaField("glowLength")] public double GlowLength;
        [LuaField("glowLines")] public double GlowLines;
        [LuaField("glowScale")] public double GlowScale;
        [LuaField("glowThickness")] public double GlowThickness;
        [LuaField("glowType")] public string GlowType;
        [LuaField("glowXOffset")] public double GlowXOffset;
        [LuaField("glowYOffset")] public double GlowYOffset;
        [LuaField("rotateText")] public string RotateText;
        [LuaField("text_anchorPoint")] public string TextAnchorPoint;
        [LuaField("text_automaticWidth")] public string TextAutomaticWidth;
        [LuaField("text_color")] public Color TextColor;
        [LuaField("text_fixedWidth")] public double TextFixedWidth;
        [LuaField("text_font")] public string TextFont;
        [LuaField("text_fontSize")] public double TextFontSize;
        [LuaField("text_fontType")] public string TextFontType;
        [LuaField("text_justify")] public string TextJustify;
        [LuaField("text_selfPoint")] public string TextSelfPoint;
        [LuaField("text_shadowColor")] public Color TextShadowColor;
        [LuaField("text_shadowXOffset")] public double TextShadowXOffset;
        [LuaField("text_shadowYOffset")] public double TextShadowYOffset;
        [LuaField("text_text")] public string TextText;
        [LuaField("text_text_format_s_format")] public string TextTextFormatSFormat;
        [LuaField("text_visible")] public bool TextVisible;
        [LuaField("text_wordWrap")] public string TextWordWrap;
        [LuaField("type")] public string Type;
        [LuaField("useGlowColor")] public bool UseGlowColor;
    }
}