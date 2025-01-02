// Clock Conversion

namespace CompetitiveProgramming.CodeForces.ClockConversion;

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int numberOfTestCases = ReadInt();
        List<string> results = new List<string>();

        for (int i = 0; i < numberOfTestCases; i++)
        {
            string time = ReadLn();
            results.Add(Solve(time));
        }

        PrintResults(results);
    }

    private static string Solve(string time)
    {
        int hour = int.Parse(time.Substring(0, 2));
        int minute = int.Parse(time.Substring(3, 2));

        int hour12 = (hour % 12 == 0) ? 12 : (hour % 12);
        string period = (hour < 12) ? "AM" : "PM";

        return $"{hour12:D2}:{minute:D2} {period}";
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Clock Conversion");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}