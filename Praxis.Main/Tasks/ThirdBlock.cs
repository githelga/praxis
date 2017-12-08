using System.Linq;

namespace Praxis.Main.Tasks
{
    public static class ThirdBlock
    {
        public static string Task1293(string input)
        {
            var tokens = input.GetIntArrayFromString().ToArray();
            return $"{2 * tokens[0] * tokens[1] * tokens[2]}";
        }
    }
}