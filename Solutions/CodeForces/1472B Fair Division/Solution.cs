// Fair Division

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.FairDivision
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void SolutionProblem()
        {
            int numberOfTestCases = ReadInt();
            
            List<string> results = new List<string>();
            
            for (int i = 0; i < numberOfTestCases; i++)
            {
                int n = ReadInt();
                int[] candies = ReadInts();
                results.Add(CanDivideFairly(candies) ? "YES" : "NO");
            }
            
            PrintResults(results);
        }

        private static bool CanDivideFairly(int[] candies)
        {
            int count1 = candies.Count(x => x == 1);
            int count2 = candies.Count(x => x == 2);

            int totalWeight = count1 * 1 + count2 * 2;

            if (totalWeight % 2 != 0) return false;

            int halfWeight = totalWeight / 2;

            if (halfWeight % 2 == 0 || (halfWeight % 2 == 1 && count1 > 0)) return true;

            return false;
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
            StyleHelper.Title("Fair Division");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}