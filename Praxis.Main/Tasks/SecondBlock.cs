using System;
using System.Linq;
using System.Text;

namespace Praxis.Main.Tasks
{
    public static partial class TaskBlock
    {
        public static string Task1100(string input)
        {
            var tokens = input.GetArrayFromString<int>().ToList();
            var count = tokens.First();
            var list = tokens.Skip(1).ToList();
            var longArr = Enumerable.Range(0, count)
                .SelectMany(x => list.Skip(2 * x).Take(2).GroupBy(h => x, h => h))
                .ToDictionary(x => x.Key);
            var lightArr = Enumerable.Range(0, count).ToDictionary(x => x, x => longArr[x].Last()).ToArray();
            for (var i = 0; i < count - 1; i++)
            {
                for (var j = 0; j < count - i - 1; j++)
                {
                    if (lightArr[j].Value < lightArr[j + 1].Value)
                    {
                        var a = lightArr[j];
                        lightArr[j] = lightArr[j + 1];
                        lightArr[j + 1] = a;
                    }
                }
            }
            return string.Join("\r\n", lightArr.Select(k => $"{longArr[k.Key].First()} {k.Value}"));
        }

        public static string Task1101(string input)
        {
            return "";
        }

        public static string Task1102(string input)
        {
            return "";
        }

        public static string Task1103(string input)
        {
            return "";
        }

        public static string Task1104(string input)
        {
            return "";
        }

        public static string Task1105(string input)
        {
            return "";
        }

        public static string Task1106(string input)
        {
            return "";
        }

        public static string Task1107(string input)
        {
            return "";
        }

        public static string Task1108(string input)
        {
            return "";
        }

        public static string Task1109(string input)
        {
            return "";
        }

        public static string Task1110(string input)
        {
            return "";
        }

        public static string Task1111(string input)
        {
            return "";
        }

        public static string Task1112(string input)
        {
            return "";
        }

        public static string Task1113(string input)
        {
            return "";
        }

        public static string Task1114(string input)
        {
            return "";
        }

        public static string Task1115(string input)
        {
            return "";
        }

        public static string Task1116(string input)
        {
            return "";
        }

        public static string Task1117(string input)
        {
            return "";
        }

        public static string Task1118(string input)
        {
            return "";
        }

        public static string Task1119(string input)
        {
            return "";
        }

        public static string Task1120(string input)
        {
            return "";
        }

        public static string Task1121(string input)
        {
            return "";
        }

        public static string Task1122(string input)
        {
            return "";
        }

        public static string Task1123(string input)
        {
            return "";
        }

        public static string Task1124(string input)
        {
            return "";
        }

        public static string Task1125(string input)
        {
            return "";
        }

        public static string Task1126(string input)
        {
            return "";
        }

        public static string Task1127(string input)
        {
            return "";
        }

        public static string Task1128(string input)
        {
            return "";
        }

        public static string Task1129(string input)
        {
            return "";
        }

        public static string Task1130(string input)
        {
            return "";
        }

        public static string Task1131(string input)
        {
            return "";
        }

        public static string Task1132(string input)
        {
            return "";
        }

        public static string Task1133(string input)
        {
            return "";
        }

        public static string Task1134(string input)
        {
            return "";
        }

        public static string Task1135(string input)
        {
            return "";
        }

        public static string Task1136(string input)
        {
            return "";
        }

        public static string Task1137(string input)
        {
            return "";
        }

        public static string Task1138(string input)
        {
            return "";
        }

        public static string Task1139(string input)
        {
            return "";
        }

        public static string Task1140(string input)
        {
            return "";
        }

        public static string Task1141(string input)
        {
            return "";
        }

        public static string Task1142(string input)
        {
            return "";
        }

        public static string Task1143(string input)
        {
            return "";
        }

        public static string Task1144(string input)
        {
            return "";
        }

        public static string Task1145(string input)
        {
            return "";
        }

        public static string Task1146(string input)
        {
            return "";
        }

        public static string Task1147(string input)
        {
            return "";
        }

        public static string Task1148(string input)
        {
            return "";
        }

        public static string Task1149(string input)
        {
            return "";
        }

        public static string Task1150(string input)
        {
            return "";
        }

        public static string Task1151(string input)
        {
            return "";
        }

        public static string Task1152(string input)
        {
            return "";
        }

        public static string Task1153(string input)
        {
            return "";
        }

        public static string Task1154(string input)
        {
            return "";
        }

        public static string Task1155(string input)
        {
            return "";
        }

        public static string Task1156(string input)
        {
            return "";
        }

        public static string Task1157(string input)
        {
            return "";
        }

        public static string Task1158(string input)
        {
            return "";
        }

        public static string Task1159(string input)
        {
            return "";
        }

        public static string Task1160(string input)
        {
            return "";
        }

        public static string Task1161(string input)
        {
            return "";
        }

        public static string Task1162(string input)
        {
            return "";
        }

        public static string Task1163(string input)
        {
            return "";
        }

        public static string Task1164(string input)
        {
            return "";
        }

        public static string Task1165(string input)
        {
            return "";
        }

        public static string Task1166(string input)
        {
            return "";
        }

        public static string Task1167(string input)
        {
            return "";
        }

        public static string Task1168(string input)
        {
            return "";
        }

        public static string Task1169(string input)
        {
            return "";
        }

        public static string Task1170(string input)
        {
            return "";
        }

        public static string Task1171(string input)
        {
            return "";
        }

        public static string Task1172(string input)
        {
            return "";
        }

        public static string Task1173(string input)
        {
            return "";
        }

        public static string Task1174(string input)
        {
            return "";
        }

        public static string Task1175(string input)
        {
            return "";
        }

        public static string Task1176(string input)
        {
            return "";
        }

        public static string Task1177(string input)
        {
            return "";
        }

        public static string Task1178(string input)
        {
            return "";
        }

        public static string Task1179(string input)
        {
            return "";
        }

        public static string Task1180(string input)
        {
            return "";
        }

        public static string Task1181(string input)
        {
            return "";
        }

        public static string Task1182(string input)
        {
            return "";
        }

        public static string Task1183(string input)
        {
            return "";
        }

        public static string Task1184(string input)
        {
            return "";
        }

        public static string Task1185(string input)
        {
            return "";
        }

        public static string Task1186(string input)
        {
            return "";
        }

        public static string Task1187(string input)
        {
            return "";
        }

        public static string Task1188(string input)
        {
            return "";
        }

        public static string Task1189(string input)
        {
            return "";
        }

        public static string Task1190(string input)
        {
            return "";
        }

        public static string Task1191(string input)
        {
            return "";
        }

        public static string Task1192(string input)
        {
            return "";
        }

        public static string Task1193(string input)
        {
            return "";
        }

        public static string Task1194(string input)
        {
            return "";
        }

        public static string Task1195(string input)
        {
            return "";
        }

        public static string Task1196(string input)
        {
            return "";
        }

        public static string Task1197(string input)
        {
            return "";
        }

        public static string Task1198(string input)
        {
            return "";
        }

        public static string Task1199(string input)
        {
            return "";
        }
    }
}