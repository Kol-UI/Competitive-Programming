// Print a Pedestal (Codeforces logo?)

namespace CompetitiveProgramming.CodeForces.PrintaPedestalCodeforceslogo;
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
            int n = ReadInt();
            results.Add(Solve(n));
        }

        PrintResults(results);
    }

    private static string Solve(int n)
    {
        int baseValue = (n - 6) / 3;
        int h2 = baseValue + 2;
        int h1 = baseValue + 3;
        int h3 = baseValue + 1;
        int rest = (n - 6) % 3;
        if (rest == 1)
        {
            h1++;
        }
        else if (rest == 2)
        {
            h1++;
            h2++;
        }

        return $"{h2} {h1} {h3}";
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static long ReadLong() => long.Parse(ReadLn());
    private static double ReadDouble() => double.Parse(ReadLn());
    private static string[] ReadStrings() => ReadLn().Split(' ');
    private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
    private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
    private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
    private static void PrintDouble(double value, int decimals) => Console.WriteLine(value.ToString($"F{decimals}"));
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Print a Pedestal (Codeforces logo?)");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}