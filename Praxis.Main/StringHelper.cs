using System;
using System.Collections.Generic;
using System.Linq;

namespace Praxis.Main
{
    internal static class StringHelper
    {
        private static IEnumerable<string> GetParts(this string s)
        {
            return s.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        }

        public static IEnumerable<int> GetIntArrayFromString(this string input)
        {
            return input.GetParts().Select(int.Parse);
        }

        public static IEnumerable<double> GetDoubleArrayFromString(this string input)
        {
            return input.GetParts().Select(x => double.Parse(x, Constants.Nfi));
        }
    }
}
