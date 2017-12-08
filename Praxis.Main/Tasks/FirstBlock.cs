using System;
using System.Linq;

namespace Praxis.Main.Tasks
{
    public static partial class TaskBlock
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

        public static string Task1006(string input)
        {
            return "";
        }

        public static string Task1007(string input)
        {
            return "";
        }

        public static string Task1008(string input)
        {
            return "";
        }

        public static string Task1009(string input)
        {
            return "";
        }

        public static string Task1010(string input)
        {
            return "";
        }

        public static string Task1011(string input)
        {
            return "";
        }

        public static string Task1012(string input)
        {
            return "";
        }

        public static string Task1013(string input)
        {
            return "";
        }

        public static string Task1014(string input)
        {
            return "";
        }

        public static string Task1015(string input)
        {
            return "";
        }

        public static string Task1016(string input)
        {
            return "";
        }

        public static string Task1017(string input)
        {
            return "";
        }

        public static string Task1018(string input)
        {
            return "";
        }

        public static string Task1019(string input)
        {
            return "";
        }

        public static string Task1020(string input)
        {
            return "";
        }

        public static string Task1021(string input)
        {
            return "";
        }

        public static string Task1022(string input)
        {
            return "";
        }

        public static string Task1023(string input)
        {
            return "";
        }

        public static string Task1024(string input)
        {
            return "";
        }

        public static string Task1025(string input)
        {
            return "";
        }

        public static string Task1026(string input)
        {
            return "";
        }

        public static string Task1027(string input)
        {
            return "";
        }

        public static string Task1028(string input)
        {
            return "";
        }

        public static string Task1029(string input)
        {
            return "";
        }

        public static string Task1030(string input)
        {
            return "";
        }

        public static string Task1031(string input)
        {
            return "";
        }

        public static string Task1032(string input)
        {
            return "";
        }

        public static string Task1033(string input)
        {
            return "";
        }

        public static string Task1034(string input)
        {
            return "";
        }

        public static string Task1035(string input)
        {
            return "";
        }

        public static string Task1036(string input)
        {
            return "";
        }

        public static string Task1037(string input)
        {
            return "";
        }

        public static string Task1038(string input)
        {
            return "";
        }

        public static string Task1039(string input)
        {
            return "";
        }

        public static string Task1040(string input)
        {
            return "";
        }

        public static string Task1041(string input)
        {
            return "";
        }

        public static string Task1042(string input)
        {
            return "";
        }

        public static string Task1043(string input)
        {
            return "";
        }

        public static string Task1044(string input)
        {
            return "";
        }

        public static string Task1045(string input)
        {
            return "";
        }

        public static string Task1046(string input)
        {
            return "";
        }

        public static string Task1047(string input)
        {
            return "";
        }

        public static string Task1048(string input)
        {
            return "";
        }

        public static string Task1049(string input)
        {
            return "";
        }

        public static string Task1050(string input)
        {
            return "";
        }

        public static string Task1051(string input)
        {
            return "";
        }

        public static string Task1052(string input)
        {
            return "";
        }

        public static string Task1053(string input)
        {
            return "";
        }

        public static string Task1054(string input)
        {
            return "";
        }

        public static string Task1055(string input)
        {
            return "";
        }

        public static string Task1056(string input)
        {
            return "";
        }

        public static string Task1057(string input)
        {
            return "";
        }

        public static string Task1058(string input)
        {
            return "";
        }

        public static string Task1059(string input)
        {
            return "";
        }

        public static string Task1060(string input)
        {
            return "";
        }

        public static string Task1061(string input)
        {
            return "";
        }

        public static string Task1062(string input)
        {
            return "";
        }

        public static string Task1063(string input)
        {
            return "";
        }

        public static string Task1064(string input)
        {
            return "";
        }

        public static string Task1065(string input)
        {
            return "";
        }

        public static string Task1066(string input)
        {
            return "";
        }

        public static string Task1067(string input)
        {
            return "";
        }

        public static string Task1068(string input)
        {
            var number = int.Parse(input);
            return Enumerable.Range(number > 1 ? 1 : number, Math.Abs(number - 1) + 1).Sum(x => x).ToString();
        }

        public static string Task1069(string input)
        {
            return "";
        }

        public static string Task1070(string input)
        {
            return "";
        }

        public static string Task1071(string input)
        {
            return "";
        }

        public static string Task1072(string input)
        {
            return "";
        }

        public static string Task1073(string input)
        {
            return "";
        }

        public static string Task1074(string input)
        {
            return "";
        }

        public static string Task1075(string input)
        {
            return "";
        }

        public static string Task1076(string input)
        {
            return "";
        }

        public static string Task1077(string input)
        {
            return "";
        }

        public static string Task1078(string input)
        {
            return "";
        }

        public static string Task1079(string input)
        {
            return "";
        }

        public static string Task1080(string input)
        {
            return "";
        }

        public static string Task1081(string input)
        {
            return "";
        }

        public static string Task1082(string input)
        {
            return "";
        }

        public static string Task1083(string input)
        {
            return "";
        }

        public static string Task1084(string input)
        {
            return "";
        }

        public static string Task1085(string input)
        {
            return "";
        }

        public static string Task1086(string input)
        {
            return "";
        }

        public static string Task1087(string input)
        {
            return "";
        }

        public static string Task1088(string input)
        {
            return "";
        }

        public static string Task1089(string input)
        {
            return "";
        }

        public static string Task1090(string input)
        {
            return "";
        }

        public static string Task1091(string input)
        {
            return "";
        }

        public static string Task1092(string input)
        {
            return "";
        }

        public static string Task1093(string input)
        {
            return "";
        }

        public static string Task1094(string input)
        {
            return "";
        }

        public static string Task1095(string input)
        {
            return "";
        }

        public static string Task1096(string input)
        {
            return "";
        }

        public static string Task1097(string input)
        {
            return "";
        }

        public static string Task1098(string input)
        {
            return "";
        }

        public static string Task1099(string input)
        {
            return "";
        }
    }
}
