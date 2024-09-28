// Equal Candies

namespace CompetitiveProgramming.CodeForces.EqualCandies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CompetitiveProgramming.Helpers;
    using CompetitiveProgramming.Models;
    using CompetitiveProgramming.TestDrivenDevelopment;

    public class ProblemSolution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();
            List<int> results = new List<int>();

            for (int i = 0; i < numberOfTestCases; i++)
            {
                int n = ReadInt();
                int[] candies = ReadInts();

                int minCandies = CalculateMinRemovals(candies);
                results.Add(minCandies);
            }

            PrintResults(results);
        }

        public static int CalculateMinRemovals(int[] candies)
        {
            int minCandies = candies.Min();

            int totalRemovals = candies.Sum(c => c - minCandies);

            return totalRemovals;
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static int[] ReadInts() => ReadLn().Split().Select(int.Parse).ToArray();
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Equal Candies");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}