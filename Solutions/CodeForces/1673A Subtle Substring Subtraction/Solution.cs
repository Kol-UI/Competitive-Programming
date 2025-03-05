// Subtle Substring Subtraction
namespace CompetitiveProgramming.CodeForces.SubtleSubstringSubtraction;
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
            string s = ReadLn();
            results.Add(solve(s));
        }
        PrintResults(results);
    }

    static string solve(string s)
    {
        if (s.Length % 2 == 0)
        {
            return compare(s, "");
        }
        return (s[0] <= s[s.Length - 1])
            ? compare(s.Substring(1), s[0].ToString())
            : compare(s.Substring(0, s.Length - 1), s[s.Length - 1].ToString());
    }

    static string compare(string alice, string bob)
    {
        int aliceScore = alice.Sum(c => c - 'a' + 1);
        int bobScore = bob.Sum(c => c - 'a' + 1);
        return (aliceScore > bobScore)
            ? $"Alice {aliceScore - bobScore}"
            : $"Bob {bobScore - aliceScore}";
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
        StyleHelper.Title("Subtle Substring Subtraction");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}