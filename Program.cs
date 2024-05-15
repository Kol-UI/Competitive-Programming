using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Services;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming
{
    // dotnet run
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            Console.WriteLine("Hello World!");
            // Tests
            CSharpTDD.StartAllTDD();

            // StopWatch
            sw.Stop();
            string stopWatchResult = "Time Elapsed : [" + sw.ElapsedMilliseconds.ToString() + "] ms";
            PrintHelper.HightLight(stopWatchResult, ConsoleColor.Red);
            StyleHelper.Space();

            
        }
    }
}

// Loop Testing => CodeWars 8 Kyu Invert Values

/*
bool[] results = new bool[]
{
    ResultTester.CheckResult<int>(result1, 3),
    ResultTester.CheckResult<int>(result2, 5),
    ResultTester.CheckResult<int>(result3, 2)
};

ResultTester.CheckSolution(source, results);
*/