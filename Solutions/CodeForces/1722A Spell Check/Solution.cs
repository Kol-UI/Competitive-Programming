// Spell Check

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.SpellCheck
{
    public class Solution
    {
        private const string CorrectName = "Timur";

        //public static void Main(string[] args)
        public static void SolutionProblem()
        {
            int numberOfTestCases = ReadInt();
            
            List<string> results = new List<string>();
            
            for (int i = 0; i < numberOfTestCases; i++)
            {
                int n = ReadInt();
                string input = ReadLn();
                results.Add(IsCorrectSpelling(input, n) ? "YES" : "NO");
            }
            
            PrintResults(results);
        }

        private static bool IsCorrectSpelling(string input, int n)
        {
            if (n != 5) return false;

            char[] inputChars = input.ToCharArray();
            Array.Sort(inputChars);
            
            char[] correctChars = CorrectName.ToCharArray();
            Array.Sort(correctChars);

            return new string(inputChars) == new string(correctChars);
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
            StyleHelper.Title("Spell Check");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}