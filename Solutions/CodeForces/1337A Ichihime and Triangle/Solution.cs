// Ichihime and Triangle

namespace CompetitiveProgramming.CodeForces.IchihimeandTriangle;
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
            int[] inputs = ReadInts();
            results.Add(Solve(inputs[0], inputs[1], inputs[2], inputs[3]));
        }

        PrintResults(results);
    }

    private static string Solve(int a, int b, int c, int d)
    {
        return $"{b} {c} {c}";
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
        StyleHelper.Title("Ichihime and Triangle");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}