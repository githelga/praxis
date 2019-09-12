using System;
using System.Collections.Generic;
using System.Linq;

namespace Praxis.Main.Tasks
{
    public static partial class TaskBlock
    {
        public static string Task1700(string input)
        {
            var rn = input.GetArrayStringWithoutSpace().ToArray();
            var dict = new Dictionary<string, string[]>();
            var i = int.Parse(rn[0]);
            var k = 1;
            while (k <= i)
            {
                var parts = rn[k].Split(':');
                dict.Add(parts[0], parts[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                k++;
            }
            var j = int.Parse(rn[k]);
            const string no = "No solution.";
            var str = new string[j];
            while (j != 0)
            {
                var lists = rn[j + k].Split(' ').Select(x => dict[x]);
                var union = lists.Skip(1).Aggregate(new HashSet<string>(lists.First()),
                    (h, e) =>
                    {
                        h.IntersectWith(e);
                        return h;
                    }
                ).OrderBy(x => x).ToArray();
                str[j - 1] = union.Length == 0 ? no : string.Join(" ", union);
                j--;
            }
            return string.Join("\r\n", str);
        }

        public static string Task1701(string input)
        {
            return "";
        }

        public static string Task1702(string input)
        {
            return "";
        }

        public static string Task1703(string input)
        {
            return "";
        }

        public static string Task1704(string input)
        {
            return "";
        }

        public static string Task1705(string input)
        {
            return "";
        }

        public static string Task1706(string input)
        {
            return "";
        }

        public static string Task1707(string input)
        {
            return "";
        }

        public static string Task1708(string input)
        {
            return "";
        }

        public static string Task1709(string input)
        {
            return "";
        }

        public static string Task1710(string input)
        {
            return "";
        }

        public static string Task1711(string input)
        {
            return "";
        }

        public static string Task1712(string input)
        {
            return "";
        }

        public static string Task1713(string input)
        {
            return "";
        }

        public static string Task1714(string input)
        {
            return "";
        }

        public static string Task1715(string input)
        {
            return "";
        }

        public static string Task1716(string input)
        {
            return "";
        }

        public static string Task1717(string input)
        {
            return "";
        }

        public static string Task1718(string input)
        {
            return "";
        }

        public static string Task1719(string input)
        {
            return "";
        }

        public static string Task1720(string input)
        {
            return "";
        }

        public static string Task1721(string input)
        {
            return "";
        }

        public static string Task1722(string input)
        {
            return "";
        }

        public static string Task1723(string input)
        {
            return "";
        }

        public static string Task1724(string input)
        {
            return "";
        }

        public static string Task1725(string input)
        {
            return "";
        }

        public static string Task1726(string input)
        {
            return "";
        }

        public static string Task1727(string input)
        {
            return "";
        }

        public static string Task1728(string input)
        {
            return "";
        }

        public static string Task1729(string input)
        {
            return "";
        }

        public static string Task1730(string input)
        {
            return "";
        }

        public static string Task1731(string input)
        {
            return "";
        }

        public static string Task1732(string input)
        {
            return "";
        }

        public static string Task1733(string input)
        {
            return "";
        }

        public static string Task1734(string input)
        {
            return "";
        }

        public static string Task1735(string input)
        {
            return "";
        }

        public static string Task1736(string input)
        {
            return "";
        }

        public static string Task1737(string input)
        {
            return "";
        }

        public static string Task1738(string input)
        {
            return "";
        }

        public static string Task1739(string input)
        {
            return "";
        }

        public static string Task1740(string input)
        {
            return "";
        }

        public static string Task1741(string input)
        {
            return "";
        }

        public static string Task1742(string input)
        {
            return "";
        }

        public static string Task1743(string input)
        {
            return "";
        }

        public static string Task1744(string input)
        {
            return "";
        }

        public static string Task1745(string input)
        {
            return "";
        }

        public static string Task1746(string input)
        {
            return "";
        }

        public static string Task1747(string input)
        {
            return "";
        }

        public static string Task1748(string input)
        {
            return "";
        }

        public static string Task1749(string input)
        {
            return "";
        }

        public static string Task1750(string input)
        {
            return "";
        }

        public static string Task1751(string input)
        {
            return "";
        }

        public static string Task1752(string input)
        {
            return "";
        }

        public static string Task1753(string input)
        {
            return "";
        }

        public static string Task1754(string input)
        {
            return "";
        }

        public static string Task1755(string input)
        {
            return "";
        }

        public static string Task1756(string input)
        {
            return "";
        }

        public static string Task1757(string input)
        {
            return "";
        }

        public static string Task1758(string input)
        {
            return "";
        }

        public static string Task1759(string input)
        {
            return "";
        }

        public static string Task1760(string input)
        {
            return "";
        }

        public static string Task1761(string input)
        {
            return "";
        }

        public static string Task1762(string input)
        {
            return "";
        }

        public static string Task1763(string input)
        {
            return "";
        }

        public static string Task1764(string input)
        {
            return "";
        }

        public static string Task1765(string input)
        {
            return "";
        }

        public static string Task1766(string input)
        {
            return "";
        }

        public static string Task1767(string input)
        {
            return "";
        }

        public static string Task1768(string input)
        {
            return "";
        }

        public static string Task1769(string input)
        {
            return "";
        }

        public static string Task1770(string input)
        {
            return "";
        }

        public static string Task1771(string input)
        {
            return "";
        }

        public static string Task1772(string input)
        {
            return "";
        }

        public static string Task1773(string input)
        {
            return "";
        }

        public static string Task1774(string input)
        {
            return "";
        }

        public static string Task1775(string input)
        {
            return "";
        }

        public static string Task1776(string input)
        {
            return "";
        }

        public static string Task1777(string input)
        {
            return "";
        }

        public static string Task1778(string input)
        {
            return "";
        }

        public static string Task1779(string input)
        {
            return "";
        }

        public static string Task1780(string input)
        {
            return "";
        }

        public static string Task1781(string input)
        {
            return "";
        }

        public static string Task1782(string input)
        {
            return "";
        }

        public static string Task1783(string input)
        {
            return "";
        }

        public static string Task1784(string input)
        {
            return "";
        }

        public static string Task1785(string input)
        {
            var numer = int.Parse(input);
            if (numer < 5)
                return "few";
            else if (numer < 10)
                return "several";
            else if (numer < 20)
                return "pack";
            else if (numer < 50)
                return "lots";
            else if (numer < 100)
                return "horde";
            else if (numer < 250)
                return "throng";
            else if (numer < 500)
                return "swarm";
            else if (numer < 1000)
                return "zounds";
            return "legion";
        }

        public static string Task1786(string input)
        {
            return "";
        }

        public static string Task1787(string input)
        {
            return "";
        }

        public static string Task1788(string input)
        {
            return "";
        }

        public static string Task1789(string input)
        {
            return "";
        }

        public static string Task1790(string input)
        {
            return "";
        }

        public static string Task1791(string input)
        {
            return "";
        }

        public static string Task1792(string input)
        {
            return "";
        }

        public static string Task1793(string input)
        {
            return "";
        }

        public static string Task1794(string input)
        {
            return "";
        }

        public static string Task1795(string input)
        {
            return "";
        }

        public static string Task1796(string input)
        {
            return "";
        }

        public static string Task1797(string input)
        {
            return "";
        }

        public static string Task1798(string input)
        {
            return "";
        }

        public static string Task1799(string input)
        {
            return "";
        }
    }
}