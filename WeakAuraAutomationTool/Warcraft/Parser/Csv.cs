using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace WeakAuraAutomationTool.Warcraft.Parser
{
    /// <summary>
    /// Flags in WoW are 32 bit field masks, which maps better to UINT, but are pulled in as signed int's from the CSV
    /// </summary>
    public class UIntConverter : ITypeConverter
    {
        public string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
        {
            throw new NotImplementedException();
        }

        public object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            var numberStyle = memberMapData.TypeConverterOptions.NumberStyle ?? NumberStyles.Integer;

            if (int.TryParse(text, numberStyle, memberMapData.TypeConverterOptions.CultureInfo, out var i))
            {
                if (i > 0) return (uint)i;
                return BitConverter.ToUInt32(BitConverter.GetBytes(i));
            }

            throw new Exception($"Failed to convert to uint. Text is {text}. Line is {row.Context.Row}.");
        }
    }

    public class Csv
    {
        public readonly Dictionary<string, string> HeaderTypes;
        public readonly string[] Headers;
        public readonly object[,] Values;
        public readonly string Name;

        public static Csv Load(string path)
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Configuration.HasHeaderRecord = true;
            var records = csv.GetRecords<dynamic>();

            return new Csv(Path.GetFileNameWithoutExtension(path), records);
        }

        public static List<T> Load<T>(string path)
        {
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Configuration.TypeConverterCache.RemoveConverter<uint>();
            csv.Configuration.TypeConverterCache.AddConverter<uint>(new UIntConverter());

            csv.Configuration.HasHeaderRecord = true;
            return csv.GetRecords<T>().ToList();
        }

        public Csv(string name, IEnumerable<dynamic> csv)
        {
            var headerTypes = new Dictionary<string, string>();
            var headers = new HashSet<string>();
            var lines = new List<Dictionary<string, object>>();

            foreach (ExpandoObject record in csv)
            {
                var line = new Dictionary<string, object>();
                foreach (var (header, value) in record)
                {
                    headers.Add(header);
                    line[header] = value;

                    // if (value != null && !headerTypes.ContainsKey(header)) headerTypes[header] = value.GetType();
                    if (value != null) headerTypes[header] = DetectType((string)value, headerTypes.GetValueOrDefault(header));
                }
                lines.Add(line);
            }

            Name = name;
            Headers = headers.ToArray();
            Values = new object[headers.Count, lines.Count];
            HeaderTypes = headerTypes;

            var row = -1;
            foreach (var line in lines)
            {
                row++;

                for (var column = 0; column < headers.Count; column++)
                {
                    var header = Headers[column];
                    if (line.TryGetValue(header, out var value)) Values[column, row] = value;
                }
            }
        }

        public static string DetectType(string value, string oldType)
        {
            if (oldType == "string") return "string";
            if (int.TryParse(value, out _) && oldType != "double") return "int";
            if (double.TryParse(value, out _)) return "double";
            return "string";
        }

        private static readonly Regex ArrayMatch = new Regex(@"(.*)\[(\d*)\]", RegexOptions.Compiled);

        public void PrintClass()
        {
            Console.WriteLine($"public class {Name}");
            Console.WriteLine("{");
            foreach (var (header, type) in HeaderTypes)
            {
                var varName = ArrayMatch.Replace(header, "$1$2");
                Console.WriteLine($"    [Name(\"{header}\")] public {type} {varName} {{ get; set; }}");
            }
            Console.WriteLine("}");
        }
    }
}