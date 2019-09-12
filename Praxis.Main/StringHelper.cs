using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Praxis.Main
{
    internal static class StringHelper
    {
        private static readonly char[] SymbolsWithSpace = new[] {' ', '\t', '\r', '\n'};
        private static readonly char[] SymbolsWithOutSpace = new[] { '\r', '\n' };

        private static IEnumerable<string> GetParts(this string s, char[] symbols)
        {
            return s.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
        }

        public static IEnumerable<T> GetArrayFromString<T>(this string input) where T : struct
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in input.GetParts(SymbolsWithSpace))
            {
                yield return (T) converter.ConvertFrom(item);
            }
        }

        public static IEnumerable<string> GetArrayString(this string input)
        {
            return input.GetParts(SymbolsWithSpace);
        }

        public static IEnumerable<string> GetArrayStringWithoutSpace(this string input)
        {
            return input.GetParts(SymbolsWithOutSpace);
        }
    }
}