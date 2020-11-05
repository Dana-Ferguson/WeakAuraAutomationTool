using System.Collections.Generic;
using WeakAuraAutomationTool.LuaMachine;

namespace WeakAuraAutomationTool.WeakAuras.Data
{
    public class Talent
    {
        // todo: ok, I was wrong, it's technically a HashSet, see: https://www.lua.org/pil/11.5.html
        // [LuaField("multi")] public Dictionary<long, bool> Multi;
        [LuaField("multi")] public List<object> Multi;
        [LuaField("single")] public double Single;
    }
}