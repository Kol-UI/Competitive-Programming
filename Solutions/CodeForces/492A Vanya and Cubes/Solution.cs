// Vanya and Cubes

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.VanyaandCubes
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void ProblemSolution()
        {
            int n = ReadInt();
            int maxHeight = CalculateMaxHeight(n);
            Console.WriteLine(maxHeight);
        }

        private static int CalculateMaxHeight(int n)
        {
            int currentHeight = 0;
            int totalCubesUsed = 0;
            int level = 1;

            while (true)
            {
                int cubesForLevel = CalculateCubesForLevel(level);
                if (totalCubesUsed + cubesForLevel > n)
                    break;

                totalCubesUsed += cubesForLevel;
                currentHeight++;
                level++;
            }

            return currentHeight;
        }

        private static int CalculateCubesForLevel(int level)
        {
            return level * (level + 1) / 2;
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
            StyleHelper.Title("Vanya and Cubes");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}