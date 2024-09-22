// Bachgold Problem

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.BachgoldProblem
{
    public class Solution
    {
        public static void ProblemSolution()
        //public static void Main(string[] args)
        {
            int n = ReadInt();

            if (n % 2 == 1)
            {
                n /= 2;
                n--;
                Console.WriteLine(n + 1);
                Console.Write("3 ");
            }
            else
            {
                n /= 2;
                Console.WriteLine(n);
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write("2 ");
            }

            Console.WriteLine();
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
            StyleHelper.Title("Bachgold Problem");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}