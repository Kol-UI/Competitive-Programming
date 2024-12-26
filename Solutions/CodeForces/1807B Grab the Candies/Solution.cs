// Grab the Candies
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.GrabtheCandies
{
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
                int n = ReadInt();
                int[] a = ReadInts();
                results.Add(Solve(a) ? "YES" : "NO");
            }

            PrintResults(results);
        }

        private static bool Solve(int[] a)
        {
            int evenSum = 0;
            int oddSum = 0;

            foreach (int ai in a)
            {
                if (ai % 2 == 0)
                {
                    evenSum += ai;
                }
                else
                {
                    oddSum += ai;
                }
            }

            return evenSum > oddSum;
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static long ReadLong() => long.Parse(ReadLn());
        private static double ReadDouble() => double.Parse(ReadLn());
        private static string[] ReadStrings() => ReadLn().Split(' ');
        private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
        private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
        private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Grab the Candies");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}