using System;
using System.Collections.Generic;
using System.Globalization;

namespace Praxis.Main
{
    public static class Constants
    {
        public static NumberFormatInfo Nfi = NumberFormatInfo.InvariantInfo;

        public static Dictionary<int, Tuple<string, string>> Tasks = new Dictionary<int, Tuple<string, string>>()
        {
            { 1000, new Tuple<string, string>("1 5", "6")},
            { 1001, new Tuple<string, string>(@" 1427  0   

   876652098643267843 
5276538", @"2297.0716
936297014.1164
0.0000
37.7757")},
            { 1002, new Tuple<string, string>(@"7325189087
5
it
your
reality
real
our
4294967296
5
it
your
reality
real
our
-1", @"reality our
No solution.")},
            { 1003, new Tuple<string, string>(@"10
5
1 2 even
3 4 odd
5 6 even
1 6 even
7 10 odd
-1", "3")},
            { 1004, new Tuple<string, string>(@"5 7
1 4 1
1 3 300
3 1 10
1 2 16
2 3 100
2 5 15
5 3 20
4 3
1 2 10
1 3 20
1 4 30
-1", @"1 3 5 2
No solution.")},
            { 1005, new Tuple<string, string>(@"5
            5 8 13 27 14", "3")},
            { 1014, new Tuple<string, string>("10", "25")},
            { 1068, new Tuple<string, string>("-3", "-5")},
            { 1079, new Tuple<string, string>(@"5
10
0", @"3
4")},
            { 1293, new Tuple<string, string>("5 2 3", "60")},
            { 2001, new Tuple<string, string>(@"1 2
2 1
0 3", @"1 1")},
            { 2012, new Tuple<string, string>("7", "YES")},
            { 2056, new Tuple<string, string>(@"3
5
5
4", "High")},
            { 2066, new Tuple<string, string>(@"1
2
3", "-5")},
        };
    }
}
