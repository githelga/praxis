using System.Linq;

namespace Praxis.Main.Tasks
{
    public static partial class TaskBlock
    {
        public static string Task2100(string input)
        {
            const string addGuest = "+one";
            var guests = input.GetArrayString().Skip(1).Select(x => x.EndsWith(addGuest) ? 2 : 1).Sum() + 2;
            return guests == 13 ? "1400" : $"{guests * 100}";
        }

        public static string Task2101(string input)
        {
            return "";
        }

        public static string Task2102(string input)
        {
            return "";
        }

        public static string Task2103(string input)
        {
            return "";
        }

        public static string Task2104(string input)
        {
            return "";
        }

        public static string Task2105(string input)
        {
            return "";
        }

        public static string Task2106(string input)
        {
            return "";
        }

        public static string Task2107(string input)
        {
            return "";
        }

        public static string Task2108(string input)
        {
            return "";
        }

        public static string Task2109(string input)
        {
            return "";
        }

        public static string Task2110(string input)
        {
            return "";
        }
    }
}
