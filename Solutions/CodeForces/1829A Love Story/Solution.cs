// Love Story

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.LoveStory
{
    public class Solution
    {
        private const string Target = "codeforces";

        //public static void Main(string[] args)
        public static void SolutionProblem()
        {
            int numberOfTestCases = ReadInt();
            
            List<int> results = new List<int>();
            
            for (int i = 0; i < numberOfTestCases; i++)
            {
                string input = ReadLn();
                results.Add(CountDifferences(input));
            }
            
            PrintResults(results);
        }

        private static int CountDifferences(string input)
        {
            int differences = 0;

            for (int i = 0; i < Target.Length; i++)
            {
                if (input[i] != Target[i])
                {
                    differences++;
                }
            }

            return differences;
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
            StyleHelper.Title("Love Story");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}