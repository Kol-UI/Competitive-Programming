// Restore the Weather
namespace CompetitiveProgramming.CodeForces.RestoretheWeather;
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

        for (int i = 0; i < numberOfTestCases; i++)
        {
            Solve();
        }
    }

    private static void Solve()
    {
        int[] nk = ReadInts();
        int n = nk[0];
        int k = nk[1];
        int[] a = ReadInts();
        int[] b = ReadInts();

        int[] sortedIndices = Enumerable.Range(0, n)
            .OrderBy(i => a[i])
            .ToArray();

        int[] sortedValues = b.OrderBy(x => x).ToArray();

        int[] result = new int[n];
        for (int i = 0; i < n; ++i)
        {
            result[sortedIndices[i]] = sortedValues[i];
        }

        Console.WriteLine(string.Join(" ", result));
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
        StyleHelper.Title("Restore the Weather");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}