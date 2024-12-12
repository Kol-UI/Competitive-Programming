// Greedy Monocarp
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.GreedyMonocarp
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

            for (int tc = 0; tc < numberOfTestCases; tc++)
            {
                int[] input = ReadInts();
                int n = input[0];
                int k = input[1];
                int[] a = ReadInts();

                results.Add(Solve(a, k));
            }

            PrintResults(results);
        }

        private static int Solve(int[] a, int k)
        {
            int[] sorted = a.OrderByDescending(x => x).ToArray();

            int sum = 0;
            for (int i = 0; i < sorted.Length && sum + sorted[i] <= k; i++)
            {
                sum += sorted[i];
            }

            return k - sum;
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
            StyleHelper.Title("Greedy Monocarp");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}