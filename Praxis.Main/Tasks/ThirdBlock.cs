using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Praxis.Main.Tasks
{
    public static partial class TaskBlock
    {
        public static string Task1200(string input)
        {
            return "";
        }

        public static string Task1201(string input)
        {
            return "";
        }

        public static string Task1202(string input)
        {
            return "";
        }

        public static string Task1203(string input)
        {
            return "";
        }

        public static string Task1204(string input)
        {
            return "";
        }

        public static string Task1205(string input)
        {
            return "";
        }

        public static string Task1206(string input)
        {
            return "";
        }

        public static string Task1207(string input)
        {
            return "";
        }

        public static string Task1208(string input)
        {
            return "";
        }

        public static string Task1209(string input)
        {
            var numbers = input.GetArrayFromString<int>();
            var sequense = numbers.Skip(1).ToList();
            var list = new List<int>();
            var max = sequense.Max();
            var i = 0;
            var last = 0;
            while (true)
            {
                if (last > max)
                    break;

                list.Add(i == 0 ? 1 + i : last + i);

                last = i == 0 ? 1 + i : last + i;
                i++;
            }
            return string.Join(" ", sequense.Select(x => list.Contains(x) ? 1 : 0));
        }

        public static string Task1210(string input)
        {
            return "";
        }

        public static string Task1211(string input)
        {
            return "";
        }

        public static string Task1212(string input)
        {
            return "";
        }

        public static string Task1213(string input)
        {
            return "";
        }

        public static string Task1214(string input)
        {
            return "";
        }

        public static string Task1215(string input)
        {
            return "";
        }

        public static string Task1216(string input)
        {
            return "";
        }

        public static string Task1217(string input)
        {
            return "";
        }

        public static string Task1218(string input)
        {
            return "";
        }

        public static string Task1219(string input)
        {
            return "";
        }

        public static string Task1220(string input)
        {
            return "";
        }

        public static string Task1221(string input)
        {
            return "";
        }

        public static string Task1222(string input)
        {
            return "";
        }

        public static string Task1223(string input)
        {
            return "";
        }

        public static string Task1224(string input)
        {
            return "";
        }
        public static string Task1225(string input)
        {
            var symbols = new List<string>() {"w", "b", "r"};
            var count = int.Parse(input);
            var n = symbols.SelectMany(x => GetLine(x, count)).Distinct();
            return n.Count().ToString();
        }

        private static IEnumerable<string> GetLine(string c, int max)
        {
            while (true)
            {
                if(c.Length > max || string.Equals(c, "b"))
                    yield break;

                if (c.Length == max)
                    yield return c;

                if (max - c.Length > 1)
                {
                    if (c.EndsWith("w"))
                        yield return $"{c}br";
                    if (c.EndsWith("r"))
                        yield return $"{c}bw";
                }

                c = $"{c}{(c.EndsWith("w") ? "r" : "w")}";
            }
        }

        public static string Task1226(string input)
        {
            var regex = new Regex("\\w+", RegexOptions.CultureInvariant);
            var arr = regex.Matches(input);
            var str = new StringBuilder();
            var len = arr.Count;
            var wordLen = 0;
            for(var i = 0; i < len; i++)
            {
                str.Append(string.Join("", arr[i].Value.Reverse()));
                wordLen += arr[i].Length;
                if (i + 1 < len)
                {
                    var ix = input.Substring(wordLen).IndexOf(arr[i + 1].Value, StringComparison.InvariantCulture);
                    str.Append(input.Substring(wordLen, ix));
                    wordLen += ix;
                }
                else
                {
                    str.Append(input.Substring(wordLen));
                }
            }
            return str.ToString();
        }

        public static string Task1227(string input)
        {
            return "";
        }

        public static string Task1228(string input)
        {
            return "";
        }

        public static string Task1229(string input)
        {
            return "";
        }

        public static string Task1230(string input)
        {
            return "";
        }

        public static string Task1231(string input)
        {
            return "";
        }

        public static string Task1232(string input)
        {
            return "";
        }

        public static string Task1233(string input)
        {
            return "";
        }

        public static string Task1234(string input)
        {
            return "";
        }

        public static string Task1235(string input)
        {
            return "";
        }

        public static string Task1236(string input)
        {
            return "";
        }

        public static string Task1237(string input)
        {
            return "";
        }

        public static string Task1238(string input)
        {
            return "";
        }

        public static string Task1239(string input)
        {
            return "";
        }

        public static string Task1240(string input)
        {
            return "";
        }

        public static string Task1241(string input)
        {
            return "";
        }

        public static string Task1242(string input)
        {
            return "";
        }

        public static string Task1243(string input)
        {
            var number = double.Parse(input);
            return $"{number % 7}";
        }

        public static string Task1244(string input)
        {
            return "";
        }

        public static string Task1245(string input)
        {
            return "";
        }

        public static string Task1246(string input)
        {
            return "";
        }

        public static string Task1247(string input)
        {
            return "";
        }

        public static string Task1248(string input)
        {
            return "";
        }

        public static string Task1249(string input)
        {
            return "";
        }

        public static string Task1250(string input)
        {
            return "";
        }

        public static string Task1251(string input)
        {
            return "";
        }

        public static string Task1252(string input)
        {
            return "";
        }

        public static string Task1253(string input)
        {
            return "";
        }

        public static string Task1254(string input)
        {
            return "";
        }

        public static string Task1255(string input)
        {
            return "";
        }

        public static string Task1256(string input)
        {
            return "";
        }

        public static string Task1257(string input)
        {
            return "";
        }

        public static string Task1258(string input)
        {
            return "";
        }

        public static string Task1259(string input)
        {
            return "";
        }

        public static string Task1260(string input)
        {
            return "";
        }

        public static string Task1261(string input)
        {
            return "";
        }

        public static string Task1262(string input)
        {
            return "";
        }

        public static string Task1263(string input)
        {
            var numbers = input.GetArrayFromString<int>().ToArray();
            var count = numbers[1];
            return string.Join("\r\n",
                numbers.Skip(2).GroupBy(x => x).OrderBy(x => x.Key).Select(x => string.Format(Constants.Nfi, "{0:F2}%", (double) x.Count() * 100 / count)));
        }

        public static string Task1264(string input)
        {
            var numbers = input.GetArrayFromString<int>().ToArray();
            return $"{numbers[0] * (numbers[1] + 1)}";
        }

        public static string Task1265(string input)
        {
            return "";
        }

        public static string Task1266(string input)
        {
            return "";
        }

        public static string Task1267(string input)
        {
            return "";
        }

        public static string Task1268(string input)
        {
            return "";
        }

        public static string Task1269(string input)
        {
            return "";
        }

        public static string Task1270(string input)
        {
            return "";
        }

        public static string Task1271(string input)
        {
            return "";
        }

        public static string Task1272(string input)
        {
            return "";
        }

        public static string Task1273(string input)
        {
            return "";
        }

        public static string Task1274(string input)
        {
            return "";
        }

        public static string Task1275(string input)
        {
            return "";
        }

        public static string Task1276(string input)
        {
            return "";
        }

        public static string Task1277(string input)
        {
            return "";
        }

        public static string Task1278(string input)
        {
            return "";
        }

        public static string Task1279(string input)
        {
            return "";
        }

        public static string Task1280(string input)
        {
            return "";
        }

        public static string Task1281(string input)
        {
            return "";
        }

        public static string Task1282(string input)
        {
            return "";
        }

        public static string Task1283(string input)
        {
            return "";
        }

        public static string Task1284(string input)
        {
            return "";
        }

        public static string Task1285(string input)
        {
            return "";
        }

        public static string Task1286(string input)
        {
            return "";
        }

        public static string Task1287(string input)
        {
            return "";
        }

        public static string Task1288(string input)
        {
            return "";
        }

        public static string Task1289(string input)
        {
            return "";
        }

        public static string Task1290(string input)
        {
            return "";
        }

        public static string Task1291(string input)
        {
            return "";
        }

        public static string Task1292(string input)
        {
            return "";
        }

        public static string Task1293(string input)
        {
            var tokens = input.GetArrayFromString<int>().ToArray();
            return $"{2 * tokens[0] * tokens[1] * tokens[2]}";
        }

        public static string Task1294(string input)
        {
            return "";
        }

        public static string Task1295(string input)
        {
            return "";
        }

        public static string Task1296(string input)
        {
            return "";
        }

        public static string Task1297(string input)
        {
            return "";
        }

        public static string Task1298(string input)
        {
            return "";
        }

        public static string Task1299(string input)
        {
            return "";
        }
    }
}