// File Name

namespace CompetitiveProgramming.CodeForces.FileName;
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
        ReadInt();
        string fileName = ReadLn();
        Console.WriteLine(Solve(fileName));
    }

    private static int Solve(string fileName)
    {
        int result = 0;
        int count = 0;
        for (int i = 0; i <= fileName.Length; ++i)
        {
            if (i >= 1 && i < fileName.Length && fileName[i] == fileName[i - 1])
            {
                ++count;
            }
            else
            {
                if (i >= 1 && fileName[i - 1] == 'x')
                {
                    result += Math.Max(0, count - 2);
                }

                count = 1;
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
        StyleHelper.Title("File Name");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}