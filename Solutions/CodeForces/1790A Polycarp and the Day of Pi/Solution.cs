// Polycarp and the Day of Pi

namespace CompetitiveProgramming.CodeForces.PolycarpandtheDayofPi;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    private const string PI = "314159265358979323846264338327";

    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int numberOfTestCases = ReadInt();
        List<int> results = new List<int>();

        for (int i = 0; i < numberOfTestCases; i++)
        {
            string n = ReadLn();
            results.Add(Solve(n));
        }

        PrintResults(results);
    }

    private static int Solve(string n)
    {
        int result = 0;
        while (result != Math.Min(n.Length, PI.Length) && n[result] == PI[result])
        {
            result++;
        }

        return result;
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
        StyleHelper.Title("Polycarp and the Day of Pi");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}