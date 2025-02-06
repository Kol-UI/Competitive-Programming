// Make All Equal

namespace CompetitiveProgramming.CodeForces.MakeAllEqual;
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

    private static int Solve(int[] a)
    {
        var valueToCount = new Dictionary<int, int>();
        foreach (var i in a)
        {
            valueToCount[i] = valueToCount.GetValueOrDefault(i, 0) + 1;
        }

        return a.Length - valueToCount.Values.Max();
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
        StyleHelper.Title("Make All Equal");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}