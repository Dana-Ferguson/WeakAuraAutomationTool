using System.Collections.Generic;
using WeakAuraAutomationTool.LuaMachine;
using WeakAuraAutomationTool.WeakAuras.Data;

namespace WeakAuraAutomationTool.WeakAuras
{
    public class WeakAuraTable
    {
        [LuaField("c")] public List<Aura> Children;
        [LuaField("d")] public Display Display;
        [LuaField("m")] public string MessageType;
        [LuaField("s")] public string WeakAuraVersion;
        [LuaField("v")] public double TransmissionVersion;

        public static WeakAuraTable Generate(string name = null, string uid = null)
        {
            return new WeakAuraTable
            {
                TransmissionVersion = 1421,
                MessageType = "d",
                WeakAuraVersion = "3.0.4",
                Display = GetDefaultWeakAuraDisplay(name, uid),
                Children = new List<Aura>()
            };
        }

        // Do I want to type all this out in code?
        // Or do I want to just parse the defaults?
        public static Display GetDefaultWeakAuraDisplay(string name = null, string uid = null)
        {
            // UnTrigger should be [], but.. won't be
            // todo: InternalVersion -- need to find where this is
            // todo: TocVersion -- need to find out what this is
            // todo: FrameStrata
            // todo: BorderEdge ?? How are these built?
            return new Display
            {
                Id = name ??= "BarbequeAuras",
                Uid = uid ?? WeakAuraUniqueId.Generate(name),
                Load = new Load
                {
                    Spec = new Spec { Multi = new List<object>() },
                    Class = new Class { Multi = new List<object>() },
                    Size = new Size { Multi = new List<object>() }
                },
                Scale = 1,
                BorderSize = 2,
                BorderOffset = 2,
                BorderInset = 1,
                AuthorOptions = new List<object>(),
                BorderColor = new Color(0, 0, 0, 1),
                Triggers = new List<Triggers>
                {
                    new Triggers
                    {
                        Trigger = new Trigger
                        {
                            SubeventPrefix = "SPELL",
                            Type = "aura2",
                            Names = new List<string>(),
                            SpellIds = new List<long>(),
                            SubeventSuffix = "_CAST_START",
                            DebuffType = "HELPFUL",
                            Unit = "player"
                        }
                    }
                },
                AnchorPoint = "CENTER",
                Conditions = new List<object>(),
                SelfPoint = "BOTTOMLEFT",
                SubRegions = new List<object>(),
                InternalVersion = 38,
                AnchorFrameType = "SCREEN",
                BorderBackdrop = "Blizzard Tooltip",
                TocVersion = 90001,
                FrameStrata = 1,
                XOffset = -165,
                YOffset = -165,
                BorderEdge = "Square Full White",
                RegionType = "group",
                BackdropColor = new Color(1, 1, 1, 0.5),
                Config = new List<object>(),
                Animation = new Animation
                {
                    Main = new AnimationStyle { Type = "none", EaseStrength = 3, EaseType = "none", DurationType = "seconds" },
                    Start = new AnimationStyle { Type = "none", EaseStrength = 3, EaseType = "none", DurationType = "seconds" },
                    Finish = new AnimationStyle { Type = "none", EaseStrength = 3, EaseType = "none", DurationType = "seconds" }
                },
                Border = false,
                Actions = DefaultActions()
            };
        }

        // todo: is there a better place for this? How will this work with a future Automation\AuraActions class?
        private static Actions DefaultActions()
        {
            return new Actions
            {
                Finish = new Functions { Custom = "", DoCustom = false, HideAllGlows = false },
                Init = new Functions { Custom = "", DoCustom = false, HideAllGlows = false },
                Start = new Functions { Custom = "", DoCustom = false, HideAllGlows = false }
            };
        }
    }
}