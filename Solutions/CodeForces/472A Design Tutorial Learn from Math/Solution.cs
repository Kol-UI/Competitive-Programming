// Design Tutorial Learn from Math


using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.DesignTutorialLearnfromMath
{
    public class Solution
    {
        private static bool[] mark = new bool[1000001];

        //public static void Main(string[] args)
        public static void MainSolution()
        {
            MarkNonPrimes();
            
            List<(long, long)> results = new List<(long, long)>();
            
            while (true)
            {
                string input = Console.ReadLine()!;
                if (string.IsNullOrEmpty(input)) break;

                long x = long.Parse(input);
                var result = FindNonPrimePair(x);
                results.Add(result);
            }

            foreach (var result in results)
            {
                Console.WriteLine($"{result.Item1} {result.Item2}");
            }
        }

        private static void MarkNonPrimes()
        {
            for (long i = 2; i <= 1000000; i++)
            {
                if (!mark[i])
                {
                    for (long j = 2 * i; j <= 1000000; j += i)
                    {
                        mark[j] = true;
                    }
                }
            }
        }

        private static (long, long) FindNonPrimePair(long x)
        {
            for (long i = 4; i <= x - 4; i++)
            {
                if (mark[i] && mark[x - i])
                {
                    return (i, x - i);
                }
            }

            return (0, 0);
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
            StyleHelper.Title("Design Tutorial: Learn from Math");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}