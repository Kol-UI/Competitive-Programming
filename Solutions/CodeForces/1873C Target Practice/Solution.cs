// Target Practice
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.TargetPractice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        private const int SIZE = 10;

        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();

            List<int> results = new List<int>();

            for (int i = 0; i < numberOfTestCases; i++)
            {
                char[][] grid = new char[SIZE][];
                for (int r = 0; r < SIZE; r++)
                {
                    string line = ReadLn();
                    grid[r] = line.ToCharArray();
                }

                results.Add(Solve(grid));
            }

            PrintResults(results);
        }

        private static int Solve(char[][] grid)
        {
            int result = 0;

            for (int r = 0; r < SIZE; r++)
            {
                for (int c = 0; c < SIZE; c++)
                {
                    if (grid[r][c] == 'X')
                    {
                        result += Math.Min(Math.Min(r, SIZE - 1 - r), Math.Min(c, SIZE - 1 - c)) + 1;
                    }
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
            StyleHelper.Title("Target Practice");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}