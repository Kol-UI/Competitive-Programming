// Permutation
namespace CompetitiveProgramming.CodeForces.Permutation;
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

    static string Solve(int n)
    {
        int[] permutation = new int[n];
        int index = 0;
        bool[] used = new bool[n + 1];
        
        for (int i = 1; i < used.Length; i++)
        {
            for (int j = i; j < used.Length; j *= 2)
            {
                if (!used[j])
                {
                    used[j] = true;
                    permutation[index++] = j;
                }
            }
        }
        
        return $"2\n{string.Join(" ", permutation)}";
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
        StyleHelper.Title("Permutation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}