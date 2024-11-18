using System;
using System.Collections.Generic;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.MakeitWhite;
public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int testCaseCount = ReadInt();
        List<int> results = new List<int>();

        for (int t = 0; t < testCaseCount; t++)
        {
            int length = ReadInt();
            string s = ReadLn();

            int firstIndex = -1, lastIndex = -1;

            for (int i = 0; i < length; i++)
            {
                if (s[i] == 'B')
                {
                    firstIndex = i;
                    break;
                }
            }

            for (int i = length - 1; i >= 0; i--)
            {
                if (s[i] == 'B')
                {
                    lastIndex = i;
                    break;
                }
            }

            results.Add(lastIndex - firstIndex + 1);
        }

        PrintResults(results);
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static long ReadLong() => long.Parse(ReadLn());
    private static double ReadDouble() => double.Parse(ReadLn());
    private static string[] ReadStrings() => ReadLn().Split(' ');
    private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
    private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
    private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Make it White");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}