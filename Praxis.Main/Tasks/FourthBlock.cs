using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Praxis.Main.Tasks
{
    public static partial class TaskBlock
    {
        public static string Task1300(string input)
        {
            return "";
        }

        public static string Task1301(string input)
        {
            return "";
        }

        public static string Task1302(string input)
        {
            return "";
        }

        public static string Task1303(string input)
        {
            return "";
        }

        public static string Task1304(string input)
        {
            return "";
        }

        public static string Task1305(string input)
        {
            return "";
        }

        public static string Task1306(string input)
        {
            return "";
        }

        public static string Task1307(string input)
        {
            return "";
        }

        public static string Task1308(string input)
        {
            return "";
        }

        public static string Task1309(string input)
        {
            return "";
        }

        public static string Task1310(string input)
        {
            return "";
        }

        public static string Task1311(string input)
        {
            return "";
        }

        public static string Task1312(string input)
        {
            return "";
        }

        public static string Task1313(string input)
        {
            var numbers = input.GetArrayFromString<int>().ToArray();
            var count = numbers[0];
            var len = count * count;
            var mass = Enumerable.Range(0, count).Select(x => numbers.Skip(1 + count * x).Take(count).ToArray()).ToArray();
            var k = 0;
            var str = new StringBuilder();
            while (len != 0)
            {
                var i = k > count ? count : k;
                var j = k > count ? k - count : 0;
                while (i > 0 && j < count)
                {
                    i--;
                    str.Append($"{(str.Length > 0 ? " " : "")}{mass[i][j]}");
                    len--;
                    j++;
                }
                k++;
            }
            return str.ToString();
        }

        public static string Task1314(string input)
        {
            return "";
        }

        public static string Task1315(string input)
        {
            return "";
        }

        public static string Task1316(string input)
        {
            return "";
        }

        public static string Task1317(string input)
        {
            return "";
        }

        public static string Task1318(string input)
        {
            return "";
        }

        public static string Task1319(string input)
        {
            var size = int.Parse(input);
            var len = size * size;
            var k = size;
            var arr = new int[size, size];
            var val = 1;
            while (val <= len)
            {
                var i = k > 0 ? 0 : 1 - k;
                var j = k > 0 ? k - 1 : 0;
                while (i > -1 && i < size && j < size)
                {
                    arr[i, j] = val;
                    val++;
                    i++;
                    j++;
                }
                k--;
            }
            var str = new StringBuilder();
            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    if (j != 0)
                        str.Append(" ");
                    str.Append($"{arr[i, j]}");
                }

                if(i < size - 1)
                    str.Append("\r\n");
            }
            return str.ToString();
        }

        public static string Task1320(string input)
        {
            return "";
        }

        public static string Task1321(string input)
        {
            return "";
        }

        public static string Task1322(string input)
        {
            return "";
        }

        public static string Task1323(string input)
        {
            return "";
        }

        public static string Task1324(string input)
        {
            return "";
        }

        public static string Task1325(string input)
        {
            return "";
        }

        public static string Task1326(string input)
        {
            return "";
        }

        public static string Task1327(string input)
        {
            return "";
        }

        public static string Task1328(string input)
        {
            return "";
        }

        public static string Task1329(string input)
        {
            return "";
        }

        public static string Task1330(string input)
        {
            return "";
        }

        public static string Task1331(string input)
        {
            return "";
        }

        public static string Task1332(string input)
        {
            return "";
        }

        public static string Task1333(string input)
        {
            return "";
        }

        public static string Task1334(string input)
        {
            return "";
        }

        public static string Task1335(string input)
        {
            return "";
        }

        public static string Task1336(string input)
        {
            return "";
        }

        public static string Task1337(string input)
        {
            return "";
        }

        public static string Task1338(string input)
        {
            return "";
        }

        public static string Task1339(string input)
        {
            return "";
        }

        public static string Task1340(string input)
        {
            return "";
        }

        public static string Task1341(string input)
        {
            return "";
        }

        public static string Task1342(string input)
        {
            return "";
        }

        public static string Task1343(string input)
        {
            return "";
        }

        public static string Task1344(string input)
        {
            return "";
        }

        public static string Task1345(string input)
        {
            return "";
        }

        public static string Task1346(string input)
        {
            return "";
        }

        public static string Task1347(string input)
        {
            return "";
        }

        public static string Task1348(string input)
        {
            return "";
        }

        public static string Task1349(string input)
        {
            return "";
        }

        public static string Task1350(string input)
        {
            return "";
        }

        public static string Task1351(string input)
        {
            return "";
        }

        public static string Task1352(string input)
        {
            return "";
        }

        public static string Task1353(string input)
        {
            return "";
        }

        public static string Task1354(string input)
        {
            return "";
        }

        public static string Task1355(string input)
        {
            return "";
        }

        public static string Task1356(string input)
        {
            return "";
        }

        public static string Task1357(string input)
        {
            return "";
        }

        public static string Task1358(string input)
        {
            return "";
        }

        public static string Task1359(string input)
        {
            return "";
        }

        public static string Task1360(string input)
        {
            return "";
        }

        public static string Task1361(string input)
        {
            return "";
        }

        public static string Task1362(string input)
        {
            return "";
        }

        public static string Task1363(string input)
        {
            return "";
        }

        public static string Task1364(string input)
        {
            return "";
        }

        public static string Task1365(string input)
        {
            return "";
        }

        public static string Task1366(string input)
        {
            return "";
        }

        public static string Task1367(string input)
        {
            return "";
        }

        public static string Task1368(string input)
        {
            return "";
        }

        public static string Task1369(string input)
        {
            return "";
        }

        public static string Task1370(string input)
        {
            return "";
        }

        public static string Task1371(string input)
        {
            return "";
        }

        public static string Task1372(string input)
        {
            return "";
        }

        public static string Task1373(string input)
        {
            return "";
        }

        public static string Task1374(string input)
        {
            return "";
        }

        public static string Task1375(string input)
        {
            return "";
        }

        public static string Task1376(string input)
        {
            return "";
        }

        public static string Task1377(string input)
        {
            return "";
        }

        public static string Task1378(string input)
        {
            return "";
        }

        public static string Task1379(string input)
        {
            return "";
        }

        public static string Task1380(string input)
        {
            return "";
        }

        public static string Task1381(string input)
        {
            return "";
        }

        public static string Task1382(string input)
        {
            return "";
        }

        public static string Task1383(string input)
        {
            return "";
        }

        public static string Task1384(string input)
        {
            return "";
        }

        public static string Task1385(string input)
        {
            return "";
        }

        public static string Task1386(string input)
        {
            return "";
        }

        public static string Task1387(string input)
        {
            return "";
        }

        public static string Task1388(string input)
        {
            return "";
        }

        public static string Task1389(string input)
        {
            return "";
        }

        public static string Task1390(string input)
        {
            return "";
        }

        public static string Task1391(string input)
        {
            return "";
        }

        public static string Task1392(string input)
        {
            return "";
        }

        public static string Task1393(string input)
        {
            return "";
        }

        public static string Task1394(string input)
        {
            return "";
        }

        public static string Task1395(string input)
        {
            return "";
        }

        public static string Task1396(string input)
        {
            return "";
        }

        public static string Task1397(string input)
        {
            return "";
        }

        public static string Task1398(string input)
        {
            return "";
        }

        public static string Task1399(string input)
        {
            return "";
        }
    }
}
