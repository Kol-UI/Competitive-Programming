// Two Arrays And Swaps

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.TwoArraysAndSwaps
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void ProblemSolution()
        {
            int numberOfTestCases = ReadInt();
            List<int> results = new List<int>();

            for (int i = 0; i < numberOfTestCases; i++)
            {
                ProcessTestCase(results);
            }

            PrintResults(results);
        }

        private static void ProcessTestCase(List<int> results)
        {
            int[] testCaseParameters = ReadInts();
            int n = testCaseParameters[0];
            int maxSwaps = testCaseParameters[1];

            int[] arrayA = ReadInts();
            int[] arrayB = ReadInts();

            int maxSumAfterSwaps = GetMaxSumAfterSwaps(arrayA, arrayB, n, maxSwaps);
            results.Add(maxSumAfterSwaps);
        }

        private static int GetMaxSumAfterSwaps(int[] arrayA, int[] arrayB, int n, int maxSwaps)
        {
            Array.Sort(arrayA);
            Array.Sort(arrayB);
            Array.Reverse(arrayB);

            for (int i = 0; i < Math.Min(maxSwaps, n); i++)
            {
                if (arrayA[i] < arrayB[i])
                {
                    SwapElements(arrayA, arrayB, i);
                }
                else
                {
                    break;
                }
            }

            return arrayA.Sum();
        }

        private static void SwapElements(int[] arrayA, int[] arrayB, int index)
        {
            int temp = arrayA[index];
            arrayA[index] = arrayB[index];
            arrayB[index] = temp;
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
            StyleHelper.Title("Two Arrays And Swaps");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}