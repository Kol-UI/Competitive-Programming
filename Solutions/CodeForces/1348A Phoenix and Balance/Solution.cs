// Phoenix and Balance

namespace CompetitiveProgramming.CodeForces.PhoenixandBalance;
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
        List<long> results = new List<long>();

        for (int t = 0; t < numberOfTestCases; t++)
        {
            int n = ReadInt();
            long[] a = new long[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = (long)Math.Pow(2, i + 1);
            }

            int div = n / 2;
            long sum1 = a[n - 1];
            for (int i = 0; i <= div - 2; i++)
            {
                sum1 += a[i];
            }

            long sum2 = 0;
            for (int i = div - 1; i < n - 1; i++)
            {
                sum2 += a[i];
            }

            results.Add(Math.Abs(sum1 - sum2));
        }

        PrintResults(results);
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}


public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Phoenix and Balance");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}