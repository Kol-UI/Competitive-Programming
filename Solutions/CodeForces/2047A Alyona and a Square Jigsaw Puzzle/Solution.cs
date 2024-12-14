// Alyona and a Square Jigsaw Puzzle
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.AlyonaandaSquareJigsawPuzzle
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
                int n = ReadInt();
                int[] a = ReadInts();

                results.Add(Solve(a));
            }

            PrintResults(results);
        }

        private static int Solve(int[] a)
        {
            int result = 0;
            int sum = 0;

            foreach (int ai in a)
            {
                sum += ai;
                if (IsOddSquare(sum))
                {
                    result++;
                }
            }

            return result;
        }

        private static bool IsOddSquare(int x)
        {
            int root = (int)Math.Round(Math.Sqrt(x));
            return root * root == x && x % 2 == 1;
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
            StyleHelper.Title("Alyona and a Square Jigsaw Puzzle");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}