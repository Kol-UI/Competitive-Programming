// Favorite Sequence
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FavoriteSequence
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
                int[] b = ReadInts();
                results.Add(Solve(b));
            }

            PrintResults(results);
        }

        private static string Solve(int[] b)
        {
            int[] result = new int[b.Length];
            int leftIndex = 0;
            int rightIndex = b.Length - 1;

            for (int i = 0; i < result.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result[i] = b[leftIndex];
                    leftIndex++;
                }
                else
                {
                    result[i] = b[rightIndex];
                    rightIndex--;
                }
            }

            return string.Join(" ", result);
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
            StyleHelper.Title("Favorite Sequence");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}