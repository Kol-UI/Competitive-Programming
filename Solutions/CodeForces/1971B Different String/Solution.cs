// Different String

namespace CompetitiveProgramming.CodeForces.DifferentString;

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
            results.Add(Solve(s));
        }

        PrintResults(results);
    }

    private static string Solve(string s)
    {
        int index = Enumerable.Range(0, s.Length - 1).FirstOrDefault(i => s[i] != s[i + 1], -1);

        return index != -1
            ? $"YES\n{s.Substring(0, index)}{s[index + 1]}{s[index]}{s.Substring(index + 2)}"
            : "NO";
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
        StyleHelper.Title("Different String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}