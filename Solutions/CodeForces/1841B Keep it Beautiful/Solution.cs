// Keep it Beautiful

namespace CompetitiveProgramming.CodeForces.KeepitBeautiful;
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
            int q = ReadInt();
            int[] x = ReadInts();
            results.Add(Solve(x));
        }

        PrintResults(results);
    }

    private static string Solve(int[] x)
    {
        char[] result = new char[x.Length];
        bool lessFound = false;
        int left = x[0];
        int right = x[0];
    
        for (int i = 0; i < result.Length; i++)
        {
            if (lessFound)
            {
                if (x[i] <= left && x[i] >= right)
                {
                    result[i] = '1';
                    right = x[i];
                }
                else result[i] = '0';
            }
            else
            {
                if (x[i] >= right || x[i] <= left)
                {
                    if (x[i] < right) lessFound = true;
                    result[i] = '1';
                    right = x[i];
                }
                else result[i] = '0';
            }
        }
    
        return new string(result);
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
        StyleHelper.Title("Keep it Beautiful");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}