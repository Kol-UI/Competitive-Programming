// Cards for Friends
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.CardsforFriends
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
                int[] inputs = ReadInts();
                int w = inputs[0];
                int h = inputs[1];
                int n = inputs[2];
                results.Add(Solve(w, h, n) ? "YES" : "NO");
            }

            PrintResults(results);
        }

        private static bool Solve(int w, int h, int n)
        {
            int totalSheets = 1;

            while (w % 2 == 0)
            {
                w /= 2;
                totalSheets *= 2;
            }

            while (h % 2 == 0)
            {
                h /= 2;
                totalSheets *= 2;
            }

            return totalSheets >= n;
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
            StyleHelper.Title("Cards for Friends");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}