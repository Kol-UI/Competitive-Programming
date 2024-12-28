// Most Unstable Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.MostUnstableArray
{
    using System;
    using System.Collections.Generic;
    public class Solution
    {
        // public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();
            List<int> results = new List<int>();

            for (int i = 0; i < numberOfTestCases; i++)
            {
                int[] nm = ReadInts();
                int n = nm[0];
                int m = nm[1];

                results.Add(Solve(n, m));
            }

            PrintResults(results);
        }

        private static int Solve(int n, int m)
        {
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return m;
            }
            else
            {
                return m * 2;
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
            StyleHelper.Title("Most Unstable Array");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}