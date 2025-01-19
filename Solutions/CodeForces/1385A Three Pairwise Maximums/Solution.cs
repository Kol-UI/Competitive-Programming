// Three Pairwise Maximums

namespace CompetitiveProgramming.CodeForces.ThreePairwiseMaximums;
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
            int[] xyz = ReadInts();
            results.Add(Solve(xyz[0], xyz[1], xyz[2]));
        }

        PrintResults(results);
    }

    private static string Solve(int x, int y, int z)
    {
        int[] sorted = new[] { x, y, z }.OrderBy(n => n).ToArray();

        return (sorted[1] != sorted[2]) ? "NO" : $"YES\n1 {sorted[0]} {sorted[1]}";
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static int[] ReadInts() => ReadLn().Split(' ').Select(int.Parse).ToArray();
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Three Pairwise Maximums");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}