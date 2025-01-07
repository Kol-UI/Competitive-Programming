// Maximum in Table

namespace CompetitiveProgramming.CodeForces.MaximuminTable;
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
        int n = ReadInt();
        Console.WriteLine(Solve(n));
    }

    private static int Solve(int n)
    {
        return ComputeCombination(2 * (n - 1), n - 1);
    }

    private static int ComputeCombination(int a, int b)
    {
        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result = result * (a - i) / (i + 1);
        }
        return result;
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
        StyleHelper.Title("Maximum in Table");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}