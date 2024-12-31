// Ten Words of Wisdom

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.TenWordsofWisdom
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
                int[] a = new int[n];
                int[] b = new int[n];

                for (int j = 0; j < n; j++)
                {
                    int[] pair = ReadInts();
                    a[j] = pair[0];
                    b[j] = pair[1];
                }

                results.Add(Solve(a, b));
            }

            PrintResults(results);
        }

        private static int Solve(int[] a, int[] b)
        {
            return a
                .Select((value, index) => new { Value = value, Index = index })
                .Where(x => x.Value <= 10)
                .OrderByDescending(x => b[x.Index])
                .First()
                .Index + 1;
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
            StyleHelper.Title("Ten Words of Wisdom");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}