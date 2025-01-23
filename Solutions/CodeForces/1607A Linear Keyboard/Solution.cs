// Linear Keyboard

namespace CompetitiveProgramming.CodeForces.LinearKeyboard;
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
        List<int> results = new List<int>();

        for (int i = 0; i < numberOfTestCases; i++)
        {
            string keyboard = ReadLn();
            string s = ReadLn();
            results.Add(Solve(keyboard, s));
        }

        PrintResults(results);
    }

    private static int Solve(string keyboard, string s)
    {
        Dictionary<char, int> letterToIndex = keyboard
            .Select((c, i) => new { c, i })
            .ToDictionary(x => x.c, x => x.i);

        return Enumerable.Range(0, s.Length - 1)
            .Select(i => Math.Abs(letterToIndex[s[i]] - letterToIndex[s[i + 1]]))
            .Sum();
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
        StyleHelper.Title("Linear Keyboard");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}