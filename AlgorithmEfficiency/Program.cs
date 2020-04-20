using System;
using System.Diagnostics;
using System.Threading;
using AlgoithmEfficiencyClassLib;
class Program
{


    static void Main(string[] args)
    {
        decimal n = 10000;

        void method1()
        {
            AlgoTesting.methodtotestA(n);
        }

        void method2()
        {
            AlgoTesting.methodtotestB(n);
        }

        Thread thread1 = new Thread(new ThreadStart(method1));
        Thread thread2 = new Thread(new ThreadStart(method2));

        thread2.Start();
        thread1.Start();


        Console.ReadLine();

    }
}
