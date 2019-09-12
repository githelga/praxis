using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Praxis.Main.Tasks
{
    public static partial class TaskBlock
    {
        public static string Task1500(string input)
        {
            return "";
        }

        public static string Task1501(string input)
        {
            return "";
        }

        public static string Task1502(string input)
        {
            return "";
        }

        public static string Task1503(string input)
        {
            return "";
        }

        public static string Task1504(string input)
        {
            return "";
        }

        public static string Task1505(string input)
        {
            return "";
        }

        public static string Task1506(string input)
        {
            return "";
        }

        public static string Task1507(string input)
        {
            return "";
        }

        public static string Task1508(string input)
        {
            return "";
        }

        public static string Task1509(string input)
        {
            return "";
        }

        public static string Task1510(string input)
        {
            return "";
        }

        public static string Task1511(string input)
        {
            return "";
        }

        public static string Task1512(string input)
        {
            return "";
        }

        public static string Task1513(string input)
        {
            return "";
        }

        public static string Task1514(string input)
        {
            return "";
        }

        public static string Task1515(string input)
        {
            return "";
        }

        public static string Task1516(string input)
        {
            return "";
        }

        public static string Task1517(string input)
        {
            return "";
        }

        public static string Task1518(string input)
        {
            return "";
        }

        public static string Task1519(string input)
        {
            return "";
        }

        public static string Task1520(string input)
        {
            return "";
        }

        public static string Task1521(string input)
        {
            return "";
        }

        public static string Task1522(string input)
        {
            return "";
        }

        public static string Task1523(string input)
        {
            return "";
        }

        public static string Task1524(string input)
        {
            return "";
        }

        public static string Task1525(string input)
        {
            return "";
        }

        public static string Task1526(string input)
        {
            return "";
        }

        public static string Task1527(string input)
        {
            return "";
        }

        public static string Task1528(string input)
        {
            return "";
        }

        public static string Task1529(string input)
        {
            return "";
        }

        public static string Task1530(string input)
        {
            return "";
        }

        public static string Task1531(string input)
        {
            return "";
        }

        public static string Task1532(string input)
        {
            return "";
        }

        public static string Task1533(string input)
        {
            return "";
        }

        public static string Task1534(string input)
        {
            return "";
        }

        public static string Task1535(string input)
        {
            return "";
        }

        public static string Task1536(string input)
        {
            return "";
        }

        public static string Task1537(string input)
        {
            return "";
        }

        public static string Task1538(string input)
        {
            return "";
        }

        public static string Task1539(string input)
        {
            return "";
        }

        public static string Task1540(string input)
        {
            return "";
        }

        public static string Task1541(string input)
        {
            return "";
        }

        public static string Task1542(string input)
        {
            return "";
        }

        public static string Task1543(string input)
        {
            return "";
        }

        public static string Task1544(string input)
        {
            return "";
        }

        public static string Task1545(string input)
        {
            var arr = input.GetArrayString().ToArray();
            var count = int.Parse(arr[0]);
            var lastSymbol = arr[arr.Length - 1];
            var dict = arr.Skip(1).Take(count).GroupBy(x => x.Substring(0, 1)).ToDictionary(x => x.Key, x => x);
            return dict.ContainsKey(lastSymbol) ? string.Join("\r\n", dict[lastSymbol]) : "";
        }

        public static string Task1546(string input)
        {
            return "";
        }

        public static string Task1547(string input)
        {
            return "";
        }

        public static string Task1548(string input)
        {
            return "";
        }

        public static string Task1549(string input)
        {
            return "";
        }

        public static string Task1550(string input)
        {
            return "";
        }

        public static string Task1551(string input)
        {
            return "";
        }

        public static string Task1552(string input)
        {
            return "";
        }

        public static string Task1553(string input)
        {
            return "";
        }

        public static string Task1554(string input)
        {
            return "";
        }

        public static string Task1555(string input)
        {
            return "";
        }

        public static string Task1556(string input)
        {
            return "";
        }

        public static string Task1557(string input)
        {
            return "";
        }

        public static string Task1558(string input)
        {
            return "";
        }

        public static string Task1559(string input)
        {
            return "";
        }

        public static string Task1560(string input)
        {
            return "";
        }

        public static string Task1561(string input)
        {
            return "";
        }

        public static string Task1562(string input)
        {
            return "";
        }

        public static string Task1563(string input)
        {
            var arr = input.GetArrayStringWithoutSpace().Skip(1).GroupBy(x => x).ToDictionary(x => x.Key, y => y.Count()).ToArray();
            return $"{arr.Select(x => x.Value - 1).Sum()}";
        }

        public static string Task1564(string input)
        {
            return "";
        }

        public static string Task1565(string input)
        {
            return "";
        }

        public static string Task1566(string input)
        {
            return "";
        }

        public static string Task1567(string input)
        {
            var dict = new Dictionary<char, int>()
            {
                {'a', 1},{'d', 1},{'g', 1},{'j', 1},{'m', 1},{'p', 1},{'s', 1},{'v', 1},{'y', 1},{'.', 1},{' ', 1},
                {'b', 2},{'e', 2},{'h', 2},{'k', 2},{'n', 2},{'q', 2},{'t', 2},{'w', 2},{'z', 2},{',', 2},
                {'c', 3},{'f', 3},{'i', 3},{'l', 3},{'o', 3},{'r', 3},{'u', 3},{'x', 3},{'!', 3}
            };
            return input.AsParallel().Select(x => dict[x]).Sum().ToString();
        }

        public static string Task1568(string input)
        {
            return "";
        }

        public static string Task1569(string input)
        {
            return "";
        }

        public static string Task1570(string input)
        {
            return "";
        }

        public static string Task1571(string input)
        {
            return "";
        }

        public static string Task1572(string input)
        {
            return "";
        }

        public static string Task1573(string input)
        {
            return "";
        }

        public static string Task1574(string input)
        {
            return "";
        }

        public static string Task1575(string input)
        {
            return "";
        }

        public static string Task1576(string input)
        {
            return "";
        }

        public static string Task1577(string input)
        {
            return "";
        }

        public static string Task1578(string input)
        {
            return "";
        }

        public static string Task1579(string input)
        {
            return "";
        }

        public static string Task1580(string input)
        {
            return "";
        }

        public static string Task1581(string input)
        {
            var numbers = input.GetArrayFromString<int>().Skip(1).ToArray();
            var str = new StringBuilder();
            var len = numbers.Length;
            var n = numbers[0];
            var count = 0;
            for (var i = 0; i <= len; i++)
            {
                if (i < len && n == numbers[i])
                    count++;
                else
                {
                    if(str.Length != 0)
                        str.Append(" ");

                    str.Append($"{count} {n}");
                    if (i >= len) continue;
                    n = numbers[i];
                    count = 1;
                }
            }
            return str.ToString();
        }

        public static string Task1582(string input)
        {
            return "";
        }

        public static string Task1583(string input)
        {
            return "";
        }

        public static string Task1584(string input)
        {
            return "";
        }

        public static string Task1585(string input)
        {
            var penguins = input.GetArrayStringWithoutSpace().Skip(1).ToList();
            var dict = new Dictionary<string, int>()
            {
                { "Emperor Penguin", 0},
                { "Little Penguin", 0},
                { "Macaroni Penguin", 0},
            };
            foreach (var penguin in penguins)
            {
                dict[penguin]++;
            }
            var max = dict.Values.Max();
            return $"{dict.First(x => x.Value == max).Key}";
        }

        public static string Task1586(string input)
        {
            return "";
        }

        public static string Task1587(string input)
        {
            return "";
        }

        public static string Task1588(string input)
        {
            return "";
        }

        public static string Task1589(string input)
        {
            return "";
        }

        public static string Task1590(string input)
        {
            return "";
        }

        public static string Task1591(string input)
        {
            return "";
        }

        public static string Task1592(string input)
        {
            return "";
        }

        public static string Task1593(string input)
        {
            return "";
        }

        public static string Task1594(string input)
        {
            return "";
        }

        public static string Task1595(string input)
        {
            return "";
        }

        public static string Task1596(string input)
        {
            return "";
        }

        public static string Task1597(string input)
        {
            return "";
        }

        public static string Task1598(string input)
        {
            return "";
        }

        public static string Task1599(string input)
        {
            return "";
        }
    }
}
