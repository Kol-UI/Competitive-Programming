// Stair, Peak, or Neither

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.StairPeakorNeither
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
                int[] digits = ReadInts();
                results.Add(ClassifyDigits(digits[0], digits[1], digits[2]));
            }
            
            PrintResults(results);
        }

        private static string ClassifyDigits(int a, int b, int c)
        {
            if (IsStair(a, b, c)) return "STAIR";
            if (IsPeak(a, b, c)) return "PEAK";
            return "NONE";
        }

        private static bool IsStair(int a, int b, int c) => a < b && b < c;
        
        private static bool IsPeak(int a, int b, int c) => a < b && b > c;

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
            StyleHelper.Title("Stair, Peak, or Neither");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}