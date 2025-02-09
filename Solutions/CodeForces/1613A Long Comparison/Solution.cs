// Long Comparison

namespace CompetitiveProgramming.CodeForces.LongComparison;
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
            int[] values = ReadInts();
            results.Add(Solve(values[0], values[1], values[2], values[3]));
        }

        PrintResults(results);
    }

    private static string Solve(int x1, int p1, int x2, int p2)
    {
        int length1 = x1.ToString().Length + p1;
        int length2 = x2.ToString().Length + p2;
        if (length1 < length2) return "<";
        if (length1 > length2) return ">";

        int minP = Math.Min(p1, p2);
        long prefix1 = long.Parse(x1 + new string('0', p1 - minP));
        long prefix2 = long.Parse(x2 + new string('0', p2 - minP));
        if (prefix1 < prefix2) return "<";
        if (prefix1 > prefix2) return ">";

        return "=";
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
        StyleHelper.Title("Long Comparison");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}