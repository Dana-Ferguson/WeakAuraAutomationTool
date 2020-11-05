using System;

namespace WeakAuraAutomationTool.LuaMachine
{
    internal class LuaFieldAttribute : Attribute
    {
        public readonly string Name;

        public LuaFieldAttribute(string name)
        {
            Name = name;
        }
    }

    /// <summary>
    /// Some LuaTables are hybrid Array\Class combos.
    /// So... they have keys of type long [1,2,..n] and keys of type string ["x", "y", ... "z"].
    /// Marking a class member with this attribute will absorb the long-keyed members. (todo: wording)
    /// </summary>
    internal class LuaArrayAttribute : Attribute
    {
        public LuaArrayAttribute()
        {
        }
    }
}