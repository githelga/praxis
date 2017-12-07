using System;
using System.Diagnostics;
using Praxis.Main.Tasks;

namespace Praxis.Main
{
    class Program
    {
        static void Main()
        {
            var time = new Stopwatch();
            var input = Console.In.ReadToEnd();

            time.Start();
            Console.WriteLine($"\nResult - {FirstBlock.Task1000(input)}");
            time.Stop();

            Console.WriteLine($"Time of decision, ms - {time.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}
