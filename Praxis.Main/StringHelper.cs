using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Praxis.Main
{
    internal static class StringHelper
    {
        private static IEnumerable<string> GetParts(this string s)
        {
            return s.Split(new[] {' ', '\t', '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);
        }

        public static IEnumerable<T> GetArrayFromString<T>(this string input) where T: struct
        {
            var converter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in input.GetParts())
            {
                yield return (T)converter.ConvertFrom(item);
            }
        }
    }
}
