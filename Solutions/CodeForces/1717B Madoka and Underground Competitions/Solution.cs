// Madoka and Underground Competitions
namespace CompetitiveProgramming.CodeForces.MadokaandUndergroundCompetitions;
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
            results.AddRange(Solve());
        }

        PrintResults(results);
    }

    private static List<string> Solve()
    {
        int[] data = ReadInts();
        int n = data[0], k = data[1], r = data[2] - 1, c = data[3] - 1;
        char[,] grid = new char[n, n];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                grid[i, j] = ((i + j) % k == (r + c) % k) ? 'X' : '.';

        List<string> result = new List<string>();
        for (int i = 0; i < n; i++)
        {
            char[] row = new char[n];
            for (int j = 0; j < n; j++) row[j] = grid[i, j];
            result.Add(new string(row));
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
        StyleHelper.Title("Madoka and Underground Competitions");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}