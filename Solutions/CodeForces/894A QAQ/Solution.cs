// QAQ

namespace CompetitiveProgramming.CodeForces.QAQ;
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
        string s = ReadLn();
        Console.WriteLine(Solve(s));
    }

    private static int Solve(string s)
    {
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'Q')
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[j] == 'A')
                    {
                        for (int k = j + 1; k < s.Length; k++)
                        {
                            if (s[k] == 'Q')
                            {
                                result++;
                            }
                        }
                    }
                }
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
        StyleHelper.Title("QAQ");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}