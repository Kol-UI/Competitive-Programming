// X Axis
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.XAxis
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
                int[] inputs = ReadInts();
                results.Add(Solve(inputs[0], inputs[1], inputs[2]));
            }

            PrintResults(results);
        }

        private static int Solve(int x1, int x2, int x3)
        {
            return Math.Max(Math.Max(x1, x2), x3) - Math.Min(Math.Min(x1, x2), x3);
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
            StyleHelper.Title("X Axis");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}