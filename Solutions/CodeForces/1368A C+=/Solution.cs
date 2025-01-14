// C+=

namespace CompetitiveProgramming.CodeForces.CPlusMinus;
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
            int n = inputs[2];

            results.Add(Solve(a, b, n));
        }

        PrintResults(results);
    }

    private static int Solve(int a, int b, int n)
    {
        if (a > b)
        {
            return Solve(b, a, n);
        }
        if (a > n || b > n)
        {
            return 0;
        }

        return 1 + Solve(a + b, b, n);
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static string[] ReadStrings() => ReadLn().Split(' ');
    private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("C+=");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}