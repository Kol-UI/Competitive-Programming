// Don't Try to Count

namespace CompetitiveProgramming.CodeForces.DontTrytoCount;
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

        for (int i = 0; i < numberOfTestCases; i++)
        {
            ReadInts();
            string x = ReadLn();
            string s = ReadLn();

            Console.WriteLine(Solve(x, s));
        }
    }

    private static int Solve(string x, string s)
    {
        int result = 0;

        while (true)
        {
            if (x.Contains(s)) return result;

            if (x.Length >= s.Length * 2 && result != 0) return -1;

            x += x;
            result++;
        }
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static int[] ReadInts() => ReadLn().Split(' ').Select(int.Parse).ToArray();
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Don't Try to Count");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}