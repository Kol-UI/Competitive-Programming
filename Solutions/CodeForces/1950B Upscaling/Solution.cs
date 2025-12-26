// Upscaling

namespace CompetitiveProgramming.CodeForces.Upscaling;
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
            int n = ReadInt();
            results.Add(Solve(n));
        }

        PrintResults(results);
    }

    private static string Solve(int n)
    {
        char[,] result = new char[2 * n, 2 * n];
        for (int r = 0; r < 2 * n; r++)
        {
            for (int c = 0; c < 2 * n; c++)
            {
                result[r, c] = ((r / 2 + c / 2) % 2 == 0) ? '#' : '.';
            }
        }

        return string.Join("\n", Enumerable.Range(0, 2 * n).Select(r =>
            new string(Enumerable.Range(0, 2 * n).Select(c => result[r, c]).ToArray())));
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
        StyleHelper.Title("Upscaling");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}