using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoithmEfficiencyClassLib
{
    public class AlgoTesting
    {

        public static void methodtotestA(decimal n) // Example of O(n)
        {
            decimal sum = 0;
            TimeSpan ts;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (decimal i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    sum = sum + i;
                }
                
            }

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.Write("RunTime of algorithm A ");
            Console.WriteLine($"{ts} seconds");
            Console.WriteLine($"{sum} operations.");

        }

        public static void methodtotestB(decimal n) // example of O(n2)
        {

            decimal sum = 0;
            TimeSpan ts;
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (decimal i = 1; i < n; i++)
            {
                for (int j = 1; j < 10000; j++)
                {
                    sum = sum + i;
                }
                
            }

            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            Console.Write("RunTime of algorithm B ");
            Console.WriteLine($"{ts} seconds");
            Console.WriteLine($"{sum} operations.");

        }

    }
}
