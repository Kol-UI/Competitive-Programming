// Yogurt Sale

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.YogurtSale
{
    class Solution
    {
        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static long ReadLong() => long.Parse(ReadLn());
        private static double ReadDouble() => double.Parse(ReadLn());
        private static string[] ReadStrings() => ReadLn().Split(' ');
        private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
        private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
        private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));

        static void MainSolution()
        {
            int t = ReadInt();
            List<int> results = new List<int>();

            for (int tcase = 0; tcase < t; tcase++)
            {
                int[] input = ReadInts();
                int n = input[0];
                int a = input[1];
                int b = input[2];

                if (b < 2 * a)
                {
                    results.Add((n / 2) * b + (n % 2) * a);
                }
                else
                {
                    results.Add(a * n);
                }
            }

            PrintResults(results);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Yogurt Sale");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}