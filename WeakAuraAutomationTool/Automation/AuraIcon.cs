using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.WeakAuras;
using WeakAuraAutomationTool.WeakAuras.Data;

namespace WeakAuraAutomationTool.Automation
{
    internal static class AuraIcon
    {
        public static Aura Generate(string name, string uid = null)
        {
            var icon = GetDefaultIcon(name, uid);
            icon.AddText();

            return icon;
        }

        private static Aura GetDefaultIcon(string name, string uid = null)
        {
            return new Aura
            {
                Id = name,
                Uid = uid ?? WeakAuraUniqueId.Generate(name),
                RegionType = "icon",
                Width = 40,
                Height = 40,
                XOffset = 0,
                YOffset = 0,
                TocVersion = 90001,
                Alpha = 0.75,
                Actions = DefaultActions(),
                Animation = DefaultAnimation(),
                Load = DefaultLoad(),
                SubRegions = new List<SubRegion>(),
                Advance = false,
                AnchorFrameType = "SCREEN",
                AnchorPoint = "CENTER",
                Api = false,
                AuthorOptions = new List<object>(),
                Auto = true,
                BackdropColor = null,
                BackgroundColor = null,
                BackgroundOffset = 0,
                BackgroundTexture = "",
                BlendMode = "",
                Border = false,
                BorderBackdrop = "",
                BorderColor = null,
                BorderEdge = "",
                BorderInset = 0,
                BorderOffset = 0,
                BorderSize = 0,
                Color = new Color(1, 1, 1),
                Compress = false,
                Conditions = new List<Condition>(),
                Config = new List<object>(),
                Cooldown = true,
                CooldownEdge = false,
                CooldownSwipe = true,
                CooldownTextDisabled = false,
                CropX = 0,
                CropY = 0,
                Desaturate = false,
                DesaturateBackground = false,
                DesaturateForeground = false,
                DiscreteRotation = 0,
                EndAngle = 0,
                Font = "",
                FontSize = 0,
                ForegroundColor = null,
                ForegroundTexture = "",
                FrameStrata = 1,
                Icon = true,
                IgnoreOptionsEventErrors = true,
                InternalVersion = 38,
                Inverse = true,
                KeepAspectRatio = false,
                Mirror = false,
                ModelFileId = "",
                ModelPath = "",
                ModelStRx = 0,
                ModelStRy = 0,
                ModelStRz = 0,
                ModelStTx = 0,
                ModelStTy = 0,
                ModelStTz = 0,
                ModelStUs = 0,
                ModelX = 0,
                ModelY = 0,
                ModelZ = 0,
                ModelIsUnit = false,
                Orientation = "",
                Rotate = false,
                Rotation = 0,
                SameTexture = false,
                Scale = 0,
                SelfPoint = "CENTER",
                Sequence = 0,
                SlantMode = "",
                StartAngle = 0,
                Texture = "",
                TextureWrapMode = "",
                Triggers = new Triggers
                {
                    Group = new List<TriggerGroup>(),
                    ActiveTriggerMode = 1,
                    Disjunctive = "any",
                },
                UseAdjustedMax = false,
                UseAdjustedMin = false,
                UserX = 0,
                UserY = 0,
                UseTooltip = false,
                Zoom = 0
            };
        }

        private static Load DefaultLoad()
        {
            return new Load();
        }

        private static Animation DefaultAnimation()
        {
            return new Animation
            {
                Finish = new AnimationStyle { DurationType = "seconds", EaseStrength = 3, EaseType = "none", Type = "none" },
                Main = new AnimationStyle { DurationType = "seconds", EaseStrength = 3, EaseType = "none", Type = "none" },
                Start = new AnimationStyle { DurationType = "seconds", EaseStrength = 3, EaseType = "none", Type = "none" }
            };
        }

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