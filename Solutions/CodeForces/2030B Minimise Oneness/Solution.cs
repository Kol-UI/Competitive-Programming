// Minimise Oneness
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.MinimiseOneness
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int testCases = ReadInt();
            
            while (testCases-- > 0)
            {
                Solve();
            }
        }

        private static void Solve()
        {
            int n = ReadInt();
            if (n == 1)
            {
                Console.WriteLine(0);
                return;
            }

            Console.Write(1);

            for (int i = 1; i < n; i++)
            {
                Console.Write(0);
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
            StyleHelper.Title("Minimise Oneness");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}