using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Praxis.Main.Tasks;

namespace Praxis.Main
{
    class Program
    {
        static int birthdayCakeCandles(int n, int[] arr)
        {
            var max = arr.Max();
            return arr.Count(a => a == max);
        }
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
            Console.WriteLine(TaskBlock.Task1700(Constants.Tasks[1700].Item1));
            Console.WriteLine(TaskBlock.Task1243(Constants.Tasks[1243].Item1));
            var time = new Stopwatch();
            var input = Console.In.ReadToEnd();

            time.Start();
            Console.WriteLine($"\nResult - {TaskBlock.Task1000(input)}");
            time.Stop();

            Console.WriteLine($"Time of decision, ms - {time.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}
