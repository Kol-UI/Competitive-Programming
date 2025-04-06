// Showering

namespace CompetitiveProgramming.CodeForces.Showering;
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
            int[] nsm = ReadInts();
            int n = nsm[0];
            int s = nsm[1];
            int m = nsm[2];

            int[] l = new int[n];
            int[] r = new int[n];
            for (int j = 0; j < n; j++)
            {
                int[] lr = ReadInts();
                l[j] = lr[0];
                r[j] = lr[1];
            }

            results.Add(Solve(l, r, s, m) ? "YES" : "NO");
        }

        PrintResults(results);
    }

    private static bool Solve(int[] l, int[] r, int s, int m)
    {
        return Enumerable.Range(0, l.Length + 1)
            .Any(i => ((i == l.Length ? m : l[i]) - (i == 0 ? 0 : r[i - 1])) >= s);
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
        StyleHelper.Title("Showering");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}