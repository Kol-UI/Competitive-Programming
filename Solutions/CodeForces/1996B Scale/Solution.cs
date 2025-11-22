// Scale

namespace CompetitiveProgramming.CodeForces.Scale;
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
            int[] nk = ReadInts();
            int n = nk[0], k = nk[1];
            char[][] grid = new char[n][];
            
            for (int r = 0; r < n; r++)
            {
                grid[r] = ReadLn().ToCharArray();
            }

            results.Add(Solve(grid, k));
        }

        PrintResults(results);
    }

    private static string Solve(char[][] grid, int k)
    {
        int n = grid.Length;
        char[][] result = new char[n / k][];
        
        for (int r = 0; r < n / k; r++)
        {
            result[r] = new char[n / k];
            for (int c = 0; c < n / k; c++)
            {
                result[r][c] = grid[r * k][c * k];
            }
        }
        
        return string.Join("\n", result.Select(row => new string(row)));
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
        StyleHelper.Title("Scale");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}