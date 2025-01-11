// Arithmetic Array

namespace CompetitiveProgramming.CodeForces.ArithmeticArray;
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
            int n = ReadInt();
            int[] a = ReadInts();
            results.Add(Solve(a));
        }

        PrintResults(results);
    }

    private static int Solve(int[] a)
    {
        int diff = a.Sum() - a.Length;
        if (diff < 0)
        {
            return 1;
        }
        else if (diff > 0)
        {
            return diff;
        }
        else
        {
            return 0;
        }
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
        StyleHelper.Title("Arithmetic Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}