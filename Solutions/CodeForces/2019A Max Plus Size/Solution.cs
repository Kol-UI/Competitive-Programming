// Max Plus Size
namespace CompetitiveProgramming.CodeForces.MaxPlusSize;
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
            int n = ReadInt();
            int[] a = ReadInts(n);
            Console.WriteLine(Solve(a));
        }
    }

    private static int Solve(int[] a)
    {
        return Math.Max(
            ComputeScore(Enumerable.Range(0, a.Length).Where(i => i % 2 == 0).Select(i => a[i]).ToArray()),
            ComputeScore(Enumerable.Range(0, a.Length).Where(i => i % 2 == 1).Select(i => a[i]).ToArray()));
    }

    private static int ComputeScore(int[] values)
    {
        return values.Length > 0 ? values.Max() + values.Length : values.Length;
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static long ReadLong() => long.Parse(ReadLn());
    private static double ReadDouble() => double.Parse(ReadLn());
    private static string[] ReadStrings() => ReadLn().Split(' ');
    private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
    private static int[] ReadInts(int n)
    {
        string[] inputs = ReadLn().Split(' ');
        int[] result = new int[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = int.Parse(inputs[i]);
        }
        return result;
    }
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
        StyleHelper.Title("Max Plus Size");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}