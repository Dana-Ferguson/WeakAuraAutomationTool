using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.Automation.Positioning;

namespace WeakAuraAutomationTool.Barbeque
{
    public static class Groups
    {
        public static AuraGrid Overflow => new AuraGrid
        {
            Origin = new Point(0, -100),
            Width = 8,
            Height = 5,
            InLine = Direction.Right,
            NextLine = Direction.Down,
            LuaId = 1
        };

        public static AuraGrid Utility => new AuraGrid
        {
            Origin = new Point(350, 250),
            Width = 2,
            Height = 5,
            InLine = Direction.Down,
            NextLine = Direction.Right,
            LuaId = 6
        };

        public static AuraGrid CoreRotation => new AuraGrid
        {
            Origin = new Point(-50, 250),
            Width = 2,
            Height = 5,
            InLine = Direction.Right,
            NextLine = Direction.Down,
            LuaId = 2
        };

        public static AuraGrid CoreCooldowns => new AuraGrid
        {
            Origin = new Point(-0, 100),
            Width = 2,
            Height = 5,
            InLine = Direction.Left,
            NextLine = Direction.Up,
            LuaId = 3
        };

        public static AuraGrid Mobility => new AuraGrid
        {
            Origin = new Point(100, 0),
            Width = 5,
            Height = 5,
            InLine = Direction.Right,
            NextLine = Direction.Down,
            LuaId = 4
        };

        public static AuraGrid CombatBuffs => new AuraGrid
        {
            Origin = new Point(75, 290),
            Width = 5,
            Height = 5,
            InLine = Direction.Right,
            NextLine = Direction.Up,
            LuaId = 5
        };

        public static AuraGrid Alert => new AuraGrid
        {
            Origin = new Point(-125, 225),
            Width = 1,
            Height = 1,
            InLine = Direction.Right,
            NextLine = Direction.Down,
            LuaId = 0
        };
    }
}