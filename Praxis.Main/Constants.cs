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
            {1000, new Tuple<string, string>("1 5", "6")},
            {1001, new Tuple<string, string>(" 1427  0   \r\n\r\n   876652098643267843 \r\n5276538", "2297.0716\r\n936297014.1164\r\n0.0000\r\n37.7757")},
            {1002, new Tuple<string, string>("7325189087\r\n5\r\nit\r\nyour\r\nreality\r\nreal\r\nour\r\n4294967296\r\n5\r\nit\r\nyour\r\nreality\r\nreal\r\nour\r\n-1", "reality our\r\nNo solution.")},
            {1003, new Tuple<string, string>("10\r\n5\r\n1 2 even\r\n3 4 odd\r\n5 6 even\r\n1 6 even\r\n7 10 odd\r\n-1", "3")},
            {1004, new Tuple<string, string>("5 7\r\n1 4 1\r\n1 3 300\r\n3 1 10\r\n1 2 16\r\n2 3 100\r\n2 5 15\r\n5 3 20\r\n4 3\r\n1 2 10\r\n1 3 20\r\n1 4 30\r\n-1", "1 3 5 2\r\nNo solution.")},
            {1005, new Tuple<string, string>("5\r\n            5 8 13 27 14", "3")},
            {1014, new Tuple<string, string>("10", "25")},
            {1025, new Tuple<string, string>("3\r\n5 7 5", "6")},
            {1068, new Tuple<string, string>("-3", "-5")},
            {1079, new Tuple<string, string>("5\r\n10\r\n0", "3\r\n4")},
            {1086, new Tuple<string, string>("4\r\n3\r\n2\r\n5\r\n7", "5\r\n3\r\n11\r\n17")},
            {1100, new Tuple<string, string>("8\r\n1 2\r\n16 3\r\n11 2\r\n20 3\r\n3 5\r\n26 4\r\n7 1\r\n22 4", "3 5\r\n26 4\r\n22 4\r\n16 3\r\n20 3\r\n1 2\r\n11 2\r\n7 1")},
            {1149, new Tuple<string, string>("3", "((sin(1)+3)sin(1–sin(2))+2)sin(1–sin(2+sin(3)))+1")},
            {1209, new Tuple<string, string>("4\r\n3\r\n14\r\n7\r\n6", "0 0 1 0")},
            {1225, new Tuple<string, string>("3", "4")},
            {1226, new Tuple<string, string>("This is an example of a simple test. If you did not \r\nunderstand the ciphering algorithm yet, then write the\r\nletters of each word in the reverse order. By the way,\r\n\"reversing\" the text twice restores the original text.","sihT si na elpmaxe fo a elpmis tset. fI uoy did ton \r\ndnatsrednu eht gnirehpic mhtirogla tey, neht etirw eht\r\nsrettel fo hcae drow ni eht esrever redro. yB eht yaw,\r\n\"gnisrever\" eht txet eciwt serotser eht lanigiro txet.") },
            {1243, new Tuple<string, string>("123456123456", "1")},
            {1263, new Tuple<string, string>("3 6\r\n2\r\n1\r\n3\r\n2\r\n1\r\n1", "50.00%\r\n33.33%\r\n16.67%")},
            {1264, new Tuple<string, string>("3 1", "6")},
            {1293, new Tuple<string, string>("5 2 3", "60")},
            {1313, new Tuple<string, string>("4\r\n1 3 6 10\r\n2 5 9 13\r\n4 8 12 15\r\n7 11 14 16", "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16")},
            {1319, new Tuple<string, string>("3", "4 2 1\r\n7 5 3\r\n9 8 6")},
            {1409, new Tuple<string, string>("4 7", "6 3")},
            {1493, new Tuple<string, string>("715068", "Yes")},
            {1545, new Tuple<string, string>("6\r\nna\r\nno\r\nni\r\nki\r\nka\r\nku\r\nk", "ki\r\nka\r\nku")},
            {1563, new Tuple<string, string>("12\r\nESPRIT\r\nNice Connection\r\nCamelot\r\nAdilisik\r\nLady and Gentleman City\r\nMEXX\r\nCamelot\r\nSultanna Frantsuzova\r\nCamaieu\r\nMEXX\r\nAxara\r\nCamelot\r\n", "3")},
            {1567, new Tuple<string, string>("pokupaite gvozdi tolko v kompanii gvozdederov i tovarischi!", "114")},
            {1581, new Tuple<string, string>("8\r\n1 1 2 3 3 3 10 10", "2 1 1 2 3 3 2 10")},
            {1585, new Tuple<string, string>("7\r\nEmperor Penguin\r\nMacaroni Penguin\r\nLittle Penguin\r\nEmperor Penguin\r\nMacaroni Penguin\r\nMacaroni Penguin\r\nLittle Penguin", "Macaroni Penguin")},
            {1700, new Tuple<string, string>("6\r\nwhale: big black water animal\r\npenguin: black white ice beak\r\npiano: keyboard black white wire\r\njackboot: leather heel black\r\ntrain: rail wheel black\r\nrose: red green thorn\r\n3\r\nwhale penguin piano jackboot train\r\npenguin piano\r\njackboot rose\r\n", "black\r\nblack white\r\nNo solution.")},
            {1785, new Tuple<string, string>("40", "lots")},
            {1876, new Tuple<string, string>("40 40", "120")},
            {2001, new Tuple<string, string>("1 2\r\n2 1\r\n0 3", "1 1")},
            {2012, new Tuple<string, string>("7", "YES")},
            {2023, new Tuple<string, string>("4\r\nAurora\r\nTiana\r\nAriel\r\nMulan", "5")},
            {2033, new Tuple<string, string>("oleg\r\nnexus4\r\n13000\r\nkirill\r\nkurtka\r\n20000\r\nden\r\nnexus4\r\n12000\r\nnikita\r\nhtc\r\n10000\r\nmikhail\r\nnexus4\r\n14000\r\nalexey\r\nhtc\r\n9500", "nexus4")},
            {2056, new Tuple<string, string>("3\r\n5\r\n5\r\n4", "High")},
            {2066, new Tuple<string, string>("1\r\n2\r\n3", "-5")},
            {2100, new Tuple<string, string>("6\r\nAlice+one\r\nBob+one\r\ncarl\r\nDebora+one\r\nEnrique+one\r\nFRED+one", "1400")},
        };
    }
}
