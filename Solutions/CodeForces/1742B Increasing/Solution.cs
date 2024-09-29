// Increasing

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.Increasing
{
    public class Solution
    {
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();

            for (int i = 0; i < numberOfTestCases; i++)
            {
                int arrayLength = ReadInt();
                int[] array = ReadInts();

                HashSet<int> uniqueElements = new HashSet<int>(array);

                if (uniqueElements.Count == arrayLength)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
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
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Increasing");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}