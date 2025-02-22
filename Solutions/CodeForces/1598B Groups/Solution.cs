// Groups

namespace CompetitiveProgramming.CodeForces.Groups;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    private const int DAY_NUM = 5;

    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int numberOfTestCases = ReadInt();
        List<string> results = new List<string>();

        for (int i = 0; i < numberOfTestCases; i++)
        {
            int n = ReadInt();
            int[][] survey = new int[n][];
            for (int j = 0; j < n; j++)
            {
                survey[j] = ReadInts();
            }
            results.Add(Solve(survey) ? "YES" : "NO");
        }

        PrintResults(results);
    }

    private static bool Solve(int[][] survey)
    {
        for (int d1 = 0; d1 < DAY_NUM; ++d1)
        {
            for (int d2 = d1 + 1; d2 < DAY_NUM; ++d2)
            {
                int only1 = 0, only2 = 0;
                foreach (var student in survey)
                {
                    if (student[d1] == 0 && student[d2] == 0)
                    {
                        only1 = int.MaxValue;
                        break;
                    }
                    if (student[d1] == 0) only2++;
                    if (student[d2] == 0) only1++;
                }
                if (only1 <= survey.Length / 2 && only2 <= survey.Length / 2)
                {
                    return true;
                }
            }
        }
        return false;
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
        StyleHelper.Title("Groups");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}