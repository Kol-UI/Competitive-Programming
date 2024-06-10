// 1669A Division

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.Division
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();
            
            List<string> results = new List<string>();
            
            for (int i = 0; i < numberOfTestCases; i++)
            {
                int rating = ReadInt();
                results.Add(DetermineDivision(rating));
            }
            
            PrintResults(results);
        }

        private static string DetermineDivision(int rating)
        {
            if (rating >= 1900)
            {
                return "Division 1";
            }
            else if (rating >= 1600)
            {
                return "Division 2";
            }
            else if (rating >= 1400)
            {
                return "Division 3";
            }
            else
            {
                return "Division 4";
            }
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static long ReadLong() => long.Parse(ReadLn());
        private static double ReadDouble() => double.Parse(ReadLn());
        private static string[] ReadStrings() => ReadLn().Split(' ');
        private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
        private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
        private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
        private static void PrintResults(List<string> results) => results.ForEach(Console.WriteLine);
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Division");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}