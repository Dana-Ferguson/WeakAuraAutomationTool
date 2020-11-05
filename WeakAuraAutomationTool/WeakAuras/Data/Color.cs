using System;
using System.Collections.Generic;
using System.Linq;
using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    // todo: would it better to have a, Color(LuaValue value) and Color.ToLuaValue()???
    //       and then have the Serializer check for these?
    public class Color
    {
        [LuaField("1")] public double R;
        [LuaField("2")] public double G;
        [LuaField("3")] public double B;
        [LuaField("4")] public double A;

        public Color()
        {
        }

        public Color(double r = 0, double g = 0, double b = 0, double a = 1)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        public Color(IEnumerable<double> components)
        {
            var rgba = components.ToList();
            if (rgba.Count != 4) throw new Exception("There should be 4 color components.");
            R = rgba[0];
            G = rgba[1];
            B = rgba[2];
            A = rgba[3];
        }
    }
}