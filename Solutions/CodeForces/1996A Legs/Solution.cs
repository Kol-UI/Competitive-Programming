// Legs
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;


namespace CompetitiveProgramming.CodeForces.Legs
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

            List<int> results = new List<int>();

            for (int i = 0; i < numberOfTestCases; i++)
            {
                int n = ReadInt();
                results.Add(Solve(n));
            }

            PrintResults(results);
        }

        static int Solve(int n)
        {
            int result = int.MaxValue;
            for (int chicken = 0; chicken * 2 <= n; chicken++)
            {
                if ((n - chicken * 2) % 4 == 0)
                {
                    result = Math.Min(result, chicken + (n - chicken * 2) / 4);
                }
            }

            return result;
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
            StyleHelper.Title("Legs");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}