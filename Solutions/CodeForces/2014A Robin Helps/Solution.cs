// Robin Helps

namespace CompetitiveProgramming.CodeForces.RobinHelps;
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
            int[] nk = ReadInts();
            int n = nk[0], k = nk[1];
            int[] a = ReadInts();
            results.Add(Solve(a, k));
        }

        PrintResults(results);
    }

    private static int Solve(int[] a, int k)
    {
        int result = 0;
        int rest = 0;

        foreach (int ai in a)
        {
            if (ai >= k)
            {
                rest += ai;
            }
            else if (ai == 0 && rest != 0)
            {
                --rest;
                ++result;
            }
        }

        return result;
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static int[] ReadInts() => ReadLn().Split(' ').Select(int.Parse).ToArray();
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result));
}



public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Robin Helps");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}