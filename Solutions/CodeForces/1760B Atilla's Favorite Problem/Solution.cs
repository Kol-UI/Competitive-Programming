// Atilla's Favorite Problem

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.AtillasFavoriteProblem
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = ReadInt();

            var results = new List<int>();
            for (int i = 0; i < t; i++)
            {
                int n = ReadInt();
                string s = ReadLn();
                int maxValue = s.Max(c => c) - 96;
                results.Add(maxValue);
            }

            PrintResults(results);
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Atilla's Favorite Problem");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}