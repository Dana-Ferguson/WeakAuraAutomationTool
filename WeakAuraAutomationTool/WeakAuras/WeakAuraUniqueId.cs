using System;
using System.Collections.Generic;
using System.Text;
using WeakAuraAutomationTool.WeakAuras.Utility;

namespace WeakAuraAutomationTool.WeakAuras
{
    internal static class WeakAuraUniqueId
    {
        private static readonly Random Random = new Random();

        public static string Generate()
        {
            var sb = new StringBuilder();
            for (var i = 1; i < 11; i++)
            {
                var n = BitEncoding.ByteToB64(Random.Next(0, 63));
                sb.Append(n);
            }
            return sb.ToString();
        }

        public static string Generate(string name)
        {
            var bytes = Encoding.UTF8.GetBytes(name);
            var sha256 = new System.Security.Cryptography.SHA256CryptoServiceProvider();
            var hash = sha256.ComputeHash(bytes);

            var sb = new StringBuilder();
            for (var i = 1; i < 11; i++)
            {
                var n = BitEncoding.ByteToB64(hash[i] & 63);
                sb.Append(n);
            }
            return sb.ToString();
        }
    }
}