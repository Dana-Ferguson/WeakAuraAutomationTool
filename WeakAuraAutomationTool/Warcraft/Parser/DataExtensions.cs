using System;
using System.Collections.Generic;
using System.Linq;
using WeakAuraAutomationTool.Warcraft.Parser.Enumerations;

namespace WeakAuraAutomationTool.Warcraft.Parser
{
    internal static class DataExtensions
    {
        public static int TalentPosition(this Talent talent) => talent.TierId * 3 + talent.ColumnIndex + 1;

        public static string Stringify<T>(this IEnumerable<T> enumerable) => string.Join(", ", enumerable.Select(item => item.ToString()));

        public static IEnumerable<string> GetAttributes(this IEnumerable<SpellMisc> spell) => spell.SelectMany(GetAttributes).ToList();

        public static IEnumerable<string> GetAttributes(this SpellMisc spell)
        {
            var attributes = new List<string>();

            spell.Attributes0.GetFlags<SpellMiscAttributes0>().AddTo(attributes);
            spell.Attributes1.GetFlags<SpellMiscAttributes1>().AddTo(attributes);
            spell.Attributes2.GetFlags<SpellMiscAttributes2>().AddTo(attributes);
            spell.Attributes3.GetFlags<SpellMiscAttributes3>().AddTo(attributes);
            spell.Attributes4.GetFlags<SpellMiscAttributes4>().AddTo(attributes);
            spell.Attributes5.GetFlags<SpellMiscAttributes5>().AddTo(attributes);
            spell.Attributes6.GetFlags<SpellMiscAttributes6>().AddTo(attributes);
            spell.Attributes7.GetFlags<SpellMiscAttributes7>().AddTo(attributes);
            spell.Attributes8.GetFlags<SpellMiscAttributes8>().AddTo(attributes);
            spell.Attributes9.GetFlags<SpellMiscAttributes9>().AddTo(attributes);
            spell.Attributes10.GetFlags<SpellMiscAttributes10>().AddTo(attributes);
            spell.Attributes11.GetFlags<SpellMiscAttributes11>().AddTo(attributes);
            spell.Attributes12.GetFlags<SpellMiscAttributes12>().AddTo(attributes);
            spell.Attributes13.GetFlags<SpellMiscAttributes13>().AddTo(attributes);
            // todo: is this important?
            // spell.Attributes14.GetFlags<SpellMiscAttributes14>().AddTo(attributes);

            // todo: other variables?

            return attributes;
        }

        private static IEnumerable<string> GetFlags<T>(this uint flags) where T : Enum
        {
            var mask = (T)Enum.ToObject(typeof(T), flags);
            return Enum.GetValues(typeof(T)).OfType<T>().Where(flag => mask.HasFlag(flag)).Select(flag => flag.ToString());
        }

        private static IEnumerable<string> AddTo(this IEnumerable<string> flags, List<string> values)
        {
            values.AddRange(flags);
            return values;
        }
    }
}