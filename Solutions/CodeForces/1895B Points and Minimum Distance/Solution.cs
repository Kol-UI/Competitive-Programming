// Points and Minimum Distance
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.PointsandMinimumDistance
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

            for (int tc = 0; tc < numberOfTestCases; ++tc)
            {
                int n = ReadInt();
                int[] a = ReadInts();

                results.Add(Solve(a));
            }

            PrintResults(results);
        }

        private static string Solve(int[] a)
        {
            int n = a.Length / 2;

            Array.Sort(a);

            int differenceSum = (a[n - 1] - a[0]) + (a[2 * n - 1] - a[n]);

            string pairedElements = string.Join("\n", Enumerable.Range(0, n)
                .Select(i => $"{a[i]} {a[i + n]}"));

            return $"{differenceSum}\n{pairedElements}";
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static int[] ReadInts() => ReadLn().Split(' ').Select(int.Parse).ToArray();
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Points and Minimum Distance");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}