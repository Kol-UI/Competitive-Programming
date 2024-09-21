// Minimal Square

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.MinimalSquare
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void SolutionProblem()
        {
            int numberOfTestCases = ReadInt();
            
            List<int> results = new List<int>();
            
            for (int i = 0; i < numberOfTestCases; i++)
            {
                int[] dimensions = ReadInts();
                int a = dimensions[0];
                int b = dimensions[1];
                results.Add(CalculateMinimalSquareArea(a, b));
            }
            
            PrintResults(results);
        }

        private static int CalculateMinimalSquareArea(int a, int b)
        {
            int case1 = Math.Max(2 * a, b);
            int case2 = Math.Max(2 * b, a);
            int case3 = Math.Max(a, b) * 2;
            
            int minimalSide = Math.Min(Math.Max(a, 2 * b), Math.Max(b, 2 * a));

            return minimalSide * minimalSide;
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
            StyleHelper.Title("Minimal Square");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}