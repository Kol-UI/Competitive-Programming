// How Much Does Daytona Cost?

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.HowMuchDoesDaytonaCost
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int T = ReadInt();
            var results = new List<string>();

            for (int tc = 1; tc <= T; tc++)
            {
                int[] nk = ReadInts();
                int n = nk[0], k = nk[1];
                int[] a = ReadInts();

                bool exists = Array.Exists(a, x => x == k);
                results.Add(exists ? "YES" : "NO");
            }

            PrintResults(results);
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static string[] ReadStrings() => ReadLn().Split(' ');
        private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("How Much Does Daytona Cost?");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}