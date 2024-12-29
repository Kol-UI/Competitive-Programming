// Problem Generator
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.ProblemGenerator
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
            List<long> results = new List<long>();

            for (int i = 0; i < numberOfTestCases; i++)
            {
                int[] nm = ReadInts();
                int n = nm[0], m = nm[1];
                string s = ReadLn();

                results.Add(Solve(s, m));
            }

            PrintResults(results);
        }

        private static long Solve(string s, int m)
        {
            long[] frequencies = new long[7];

            foreach (char c in s)
            {
                if (c >= 'A' && c <= 'G') 
                {
                    frequencies[c - 'A']++;
                }
            }

            long deficitSum = 0;
            for (int i = 0; i < 7; i++)
            {
                long deficit = m - frequencies[i];
                if (deficit > 0)
                {
                    deficitSum += deficit;
                }
            }

            return deficitSum;
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
            StyleHelper.Title("Problem Generator");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}