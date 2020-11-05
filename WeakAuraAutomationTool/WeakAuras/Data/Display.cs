using System.Collections.Generic;
using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Display
    {
        [LuaField("actions")] public Actions Actions;
        [LuaField("align")] public string Align;
        [LuaField("anchorFrameType")] public string AnchorFrameType;
        [LuaField("anchorPerUnit")] public string AnchorPerUnit;
        [LuaField("anchorPoint")] public string AnchorPoint;
        [LuaField("animate")] public bool Animate;
        [LuaField("animation")] public Animation Animation;
        [LuaField("arcLength")] public double ArcLength;
        [LuaField("authorOptions")] public List<object> AuthorOptions;
        // [LuaField("backdropColor")] public List<double> BackdropColor;
        [LuaField("backdropColor")] public Color BackdropColor;
        [LuaField("border")] public bool Border;
        [LuaField("borderBackdrop")] public string BorderBackdrop;
        // [LuaField("borderColor")] public List<double> BorderColor;
        [LuaField("borderColor")] public Color BorderColor;
        [LuaField("borderEdge")] public string BorderEdge;
        [LuaField("borderInset")] public double BorderInset;
        [LuaField("borderOffset")] public double BorderOffset;
        [LuaField("borderSize")] public double BorderSize;
        [LuaField("columnSpace")] public double ColumnSpace;
        [LuaField("conditions")] public List<object> Conditions;
        [LuaField("config")] public List<object> Config;
        [LuaField("constantFactor")] public string ConstantFactor;
        [LuaField("frameStrata")] public double FrameStrata;
        [LuaField("fullCircle")] public bool FullCircle;
        [LuaField("gridType")] public string GridType;
        [LuaField("gridWidth")] public double GridWidth;
        [LuaField("grow")] public string Grow;
        [LuaField("id")] public string Id;
        [LuaField("ignoreOptionsEventErrors")] public bool IgnoreOptionsEventErrors;
        [LuaField("internalVersion")] public double InternalVersion;
        [LuaField("limit")] public double Limit;
        [LuaField("load")] public Load Load;
        [LuaField("radius")] public double Radius;
        [LuaField("regionType")] public string RegionType;
        [LuaField("rotation")] public double Rotation;
        [LuaField("rowSpace")] public double RowSpace;
        [LuaField("scale")] public double Scale;
        [LuaField("selfPoint")] public string SelfPoint;
        [LuaField("sort")] public string Sort;
        [LuaField("space")] public double Space;
        [LuaField("stagger")] public double Stagger;
        [LuaField("subRegions")] public List<object> SubRegions;
        [LuaField("tocversion")] public long TocVersion;
        [LuaField("triggers")] public List<Triggers> Triggers;
        [LuaField("uid")] public string Uid;
        [LuaField("useAnchorPerUnit")] public bool UseAnchorPerUnit;
        [LuaField("useLimit")] public bool UseLimit;
        [LuaField("xOffset")] public double XOffset;
        [LuaField("yOffset")] public double YOffset;
    }
}