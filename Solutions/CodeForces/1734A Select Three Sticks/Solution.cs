// Select Three Sticks
namespace CompetitiveProgramming.CodeForces.SelectThreeSticks;
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
        List<int> results = new List<int>();

        for (int i = 0; i < numberOfTestCases; i++)
        {
            int n = ReadInt();
            int[] a = ReadInts();
            results.Add(Solve(a));
        }

        PrintResults(results);
    }

    static int Solve(int[] a)
    {
        int result = int.MaxValue;
        for (int i = 0; i < a.Length; ++i)
        {
            for (int j = i + 1; j < a.Length; ++j)
            {
                for (int k = j + 1; k < a.Length; ++k)
                {
                    int d1 = Math.Abs(a[j] - a[i]) + Math.Abs(a[k] - a[i]);
                    int d2 = Math.Abs(a[k] - a[j]) + Math.Abs(a[i] - a[j]);
                    int d3 = Math.Abs(a[i] - a[k]) + Math.Abs(a[j] - a[k]);
    
                    result = Math.Min(result, Math.Min(d1, Math.Min(d2, d3)));
                }
            }
        }
        return result;
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
        StyleHelper.Title("Select Three Sticks");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}