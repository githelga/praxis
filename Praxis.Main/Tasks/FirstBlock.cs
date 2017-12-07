using System;
using System.Linq;

namespace Praxis.Main.Tasks
{
    public static class FirstBlock
    {
        public static string Task1000(string input)
        {
            var arr = input.GetIntArrayFromString().ToArray();
            return Enumerable.Range(0, arr.Length).Sum(x => arr[x]).ToString();
        }

        public static string Task1001(string input)
        {
            var arr = input.GetDoubleArrayFromString().Reverse().ToArray();
            return string.Join("\r\n",
                Enumerable.Range(0, arr.Length).Select(x => string.Format(Constants.Nfi, "{0:F4}", Math.Sqrt(arr[x]))));
        }

        public static string Task1002(string input)
        {
            return "";
        }

        public static string Task1003(string input)
        {
            return "";
        }

        public static string Task1004(string input)
        {
            return "";
        }

        public static string Task1005(string input)
        {
            var arr = input.GetIntArrayFromString().Skip(1).ToArray();

            var min = arr.Length < 2
                ? arr.FirstOrDefault()
                : arr.Min(a => Enumerable.Range(0, arr.Length - 1)
                    .Min(i => Math.Abs(arr.Except(new[] { a }).Take(i).Union(new[] { a }).Sum() -
                                       arr.Except(new[] { a }).Skip(i).Sum())));

            /* обычная разность между всеми комбинациями
             * var min2 = Enumerable.Range(1, arr.Count - 1)
                .Select(i => arr.Take(i).SelectMany(j => arr.Skip(i).Select(m => Math.Abs(m - j))).ToArray());*/

            return min.ToString();
        }

        public static string Task1068(string input)
        {
            var number = int.Parse(input);
            return Enumerable.Range(number > 1 ? 1 : number, Math.Abs(number - 1) + 1).Sum(x => x).ToString();
        }
    }
}
