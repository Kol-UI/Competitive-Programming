// Honest Coach

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.HonestCoach
{
    public class Solution
    {
        public static void MainSolution()
        {
            int testCases = ReadInt();
            
            while (testCases-- > 0)
            {
                int arrayLength = ReadInt();
                int[] array = ReadInts(arrayLength);
                Array.Sort(array);

                List<int> differences = CalculateDifferences(array);
                Console.WriteLine(differences.Min());
            }
        }

        private static List<int> CalculateDifferences(int[] sortedArray)
        {
            List<int> differences = new List<int>();
            
            for (int i = 1; i < sortedArray.Length; i++)
            {
                int difference = sortedArray[i] - sortedArray[i - 1];
                differences.Add(difference);
            }

            return differences;
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static long ReadLong() => long.Parse(ReadLn());
        private static double ReadDouble() => double.Parse(ReadLn());
        private static string[] ReadStrings() => ReadLn().Split(' ');
        private static int[] ReadInts(int length) => ReadLn().Split(' ').Select(int.Parse).ToArray();
        private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
        private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
        private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Honest Coach");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}