// Find Minimum Operations

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.FindMinimumOperations
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();
            List<long> results = new List<long>();
            
            for (int i = 0; i < numberOfTestCases; i++)
            {
                long[] nk = ReadLongs();
                long n = nk[0];
                long k = nk[1];
                
                long result = CalculateMinimumOperations(n, k);
                results.Add(result);
            }
            
            PrintResults(results);
        }

        private static long CalculateMinimumOperations(long n, long k)
        {
            if (k == 1)
            {
                return n;
            }

            List<long> powersOfK = GeneratePowersOfK(n, k);
            long operations = 0;

            for (int i = powersOfK.Count - 1; i >= 0; i--)
            {
                if (powersOfK[i] <= n && n > 0)
                {
                    operations += n / powersOfK[i];
                    n %= powersOfK[i];
                }
            }

            return operations;
        }

        private static List<long> GeneratePowersOfK(long n, long k)
        {
            List<long> powers = new List<long>();
            long currentPower = 1;
            
            while (currentPower <= n)
            {
                powers.Add(currentPower);
                currentPower *= k;
            }

            return powers;
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
            StyleHelper.Title("Find Minimum Operations");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}