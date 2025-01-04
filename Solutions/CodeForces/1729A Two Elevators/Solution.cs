// Two Elevators

namespace CompetitiveProgramming.CodeForces.TwoElevators;
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
            int[] inputs = ReadInts();
            int a = inputs[0];
            int b = inputs[1];
            int c = inputs[2];

            results.Add(Solve(a, b, c));
        }

        PrintResults(results);
    }

    private static int Solve(int a, int b, int c)
    {
        int time1 = Math.Abs(a - 1);
        int time2 = Math.Abs(b - c) + Math.Abs(c - 1);

        if (time1 < time2) return 1;
        if (time1 > time2) return 2;

        return 3;
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
        StyleHelper.Title("Two Elevators");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}