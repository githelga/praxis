using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Praxis.Main.Tasks
{
    public static partial class TaskBlock
    {
        public static string Task2000(string input)
        {
            return "";
        }

        public static string Task2001(string input)
        {
            var arr = input.GetArrayFromString<int>().ToArray();
            return $"{arr[0] - arr[4]} {arr[1] - arr[3]}";
        }

        public static string Task2002(string input)
        {
            return "";
        }

        public static string Task2003(string input)
        {
            return "";
        }

        public static string Task2004(string input)
        {
            return "";
        }

        public static string Task2005(string input)
        {
            return "";
        }

        public static string Task2006(string input)
        {
            return "";
        }

        public static string Task2007(string input)
        {
            return "";
        }

        public static string Task2008(string input)
        {
            return "";
        }

        public static string Task2009(string input)
        {
            return "";
        }

        public static string Task2010(string input)
        {
            return "";
        }

        public static string Task2011(string input)
        {
            return "";
        }

        public static string Task2012(string input)
        {
            return ushort.Parse(input) + 5 >= 12 ? "YES" : "NO";
        }

        public static string Task2013(string input)
        {
            return "";
        }

        public static string Task2014(string input)
        {
            return "";
        }

        public static string Task2015(string input)
        {
            return "";
        }

        public static string Task2016(string input)
        {
            return "";
        }

        public static string Task2017(string input)
        {
            return "";
        }

        public static string Task2018(string input)
        {
            return "";
        }

        public static string Task2019(string input)
        {
            return "";
        }

        public static string Task2020(string input)
        {
            return "";
        }

        public static string Task2021(string input)
        {
            return "";
        }

        public static string Task2022(string input)
        {
            return "";
        }

        public static string Task2023(string input)
        {
            var tokens = input.GetArrayString();
            var mails = tokens.Skip(1).ToArray();
            var d1 = new List<string>() { "Alice", "Ariel", "Aurora", "Phil", "Peter", "Olaf", "Phoebus", "Ralph", "Robin" };
            var d2 = new List<string>() { "Bambi", "Belle", "Bolt", "Mulan", "Mowgli", "Mickey", "Silver", "Simba", "Stitch" };
            var d3 = new List<string>() { "Dumbo", "Genie", "Jiminy", "Kuzko", "Kida", "Kenai", "Tarzan", "Tiana", "Winnie" };
            var len = 0;
            var pos = 1;
            foreach (var mail in mails)
            {
                int newPos;
                if (d1.Contains(mail))
                    newPos = 1;
                else if (d2.Contains(mail))
                    newPos = 2;
                else if (d3.Contains(mail))
                    newPos = 3;
                else
                {
                    throw new Exception($"Mail '{mail}' is not find in the post");
                }
                len += Math.Abs(newPos - pos);
                pos = newPos;
            }
            return len.ToString();
        }

        public static string Task2024(string input)
        {
            return "";
        }

        public static string Task2025(string input)
        {
            return "";
        }

        public static string Task2026(string input)
        {
            return "";
        }

        public static string Task2027(string input)
        {
            return "";
        }

        public static string Task2028(string input)
        {
            return "";
        }

        public static string Task2029(string input)
        {
            return "";
        }

        public static string Task2030(string input)
        {
            return "";
        }

        public static string Task2031(string input)
        {
            return "";
        }

        public static string Task2032(string input)
        {
            return "";
        }

        public static string Task2033(string input)
        {
            var arr = input.GetArrayString().ToArray();
            var goods = Enumerable.Range(0, arr.Length / 3)
                .Select(i => arr.Skip(i * 3).Take(3).ToArray())
                .GroupBy(x => x[1], x => ulong.Parse(x[2]))
                .ToDictionary(x => x.Key, x => new Tuple<int, ulong>(x.Count(), x.Min()));
            var maxCount = goods.Max(x => x.Value.Item1);
            var resultGoods = goods.Where(x => x.Value.Item1 == maxCount).ToArray();
            return resultGoods.Length == 1 ? resultGoods[0].Key : resultGoods.OrderBy(x => x.Value.Item2).First().Key;
        }

        public static string Task2034(string input)
        {
            return "";
        }

        public static string Task2035(string input)
        {
            return "";
        }

        public static string Task2036(string input)
        {
            return "";
        }

        public static string Task2037(string input)
        {
            return "";
        }

        public static string Task2038(string input)
        {
            return "";
        }

        public static string Task2039(string input)
        {
            return "";
        }

        public static string Task2040(string input)
        {
            return "";
        }

        public static string Task2041(string input)
        {
            return "";
        }

        public static string Task2042(string input)
        {
            return "";
        }

        public static string Task2043(string input)
        {
            return "";
        }

        public static string Task2044(string input)
        {
            return "";
        }

        public static string Task2045(string input)
        {
            return "";
        }

        public static string Task2046(string input)
        {
            return "";
        }

        public static string Task2047(string input)
        {
            return "";
        }

        public static string Task2048(string input)
        {
            return "";
        }

        public static string Task2049(string input)
        {
            return "";
        }

        public static string Task2050(string input)
        {
            return "";
        }

        public static string Task2051(string input)
        {
            return "";
        }

        public static string Task2052(string input)
        {
            return "";
        }

        public static string Task2053(string input)
        {
            return "";
        }

        public static string Task2054(string input)
        {
            return "";
        }

        public static string Task2055(string input)
        {
            return "";
        }

        public static string Task2056(string input)
        {
            /*var count = ushort.Parse(Console.ReadLine());
            var markers = new List<ushort>();
            while (count != 0)
            {
                markers.Add(ushort.Parse(Console.ReadLine()));
                count--;
            }*/

            var markers = input.GetArrayFromString<ushort>().Skip(1).ToList();
            return markers.Any(x => x < 4) ? "None" : markers.All(x => x == 5) ? "Named" : markers.Sum(x => (double) x) / markers.Count >= 4.5 ? "High" : "Common";
        }

        public static string Task2057(string input)
        {
            return "";
        }

        public static string Task2058(string input)
        {
            return "";
        }

        public static string Task2059(string input)
        {
            return "";
        }

        public static string Task2060(string input)
        {
            return "";
        }

        public static string Task2061(string input)
        {
            return "";
        }

        public static string Task2062(string input)
        {
            return "";
        }

        public static string Task2063(string input)
        {
            return "";
        }

        public static string Task2064(string input)
        {
            return "";
        }

        public static string Task2065(string input)
        {
            return "";
        }

        public static string Task2066(string input)
        {
            var numbers = input.GetArrayFromString<int>().ToList();
            var min = numbers.Min();
            numbers.Remove(min);
            return $"{min - numbers.Aggregate((x, y) => x * y)}";
        }

        public static string Task2067(string input)
        {
            return "";
        }

        public static string Task2068(string input)
        {
            return "";
        }

        public static string Task2069(string input)
        {
            return "";
        }

        public static string Task2070(string input)
        {
            return "";
        }

        public static string Task2071(string input)
        {
            return "";
        }

        public static string Task2072(string input)
        {
            return "";
        }

        public static string Task2073(string input)
        {
            return "";
        }

        public static string Task2074(string input)
        {
            return "";
        }

        public static string Task2075(string input)
        {
            return "";
        }

        public static string Task2076(string input)
        {
            return "";
        }

        public static string Task2077(string input)
        {
            return "";
        }

        public static string Task2078(string input)
        {
            return "";
        }

        public static string Task2079(string input)
        {
            return "";
        }

        public static string Task2080(string input)
        {
            return "";
        }

        public static string Task2081(string input)
        {
            return "";
        }

        public static string Task2082(string input)
        {
            return "";
        }

        public static string Task2083(string input)
        {
            return "";
        }

        public static string Task2084(string input)
        {
            return "";
        }

        public static string Task2085(string input)
        {
            return "";
        }

        public static string Task2086(string input)
        {
            return "";
        }

        public static string Task2087(string input)
        {
            return "";
        }

        public static string Task2088(string input)
        {
            return "";
        }

        public static string Task2089(string input)
        {
            return "";
        }

        public static string Task2090(string input)
        {
            return "";
        }

        public static string Task2091(string input)
        {
            return "";
        }

        public static string Task2092(string input)
        {
            return "";
        }

        public static string Task2093(string input)
        {
            return "";
        }

        public static string Task2094(string input)
        {
            return "";
        }

        public static string Task2095(string input)
        {
            return "";
        }

        public static string Task2096(string input)
        {
            return "";
        }

        public static string Task2097(string input)
        {
            return "";
        }

        public static string Task2098(string input)
        {
            return "";
        }

        public static string Task2099(string input)
        {
            return "";
        }
    }
}