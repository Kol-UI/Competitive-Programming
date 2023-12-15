using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using CompetitiveProgramming.Helpers.Outputs;
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

            // ResultTester Stats
            ResultTester.GetAllStats();

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