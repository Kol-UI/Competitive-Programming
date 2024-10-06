// Collecting Coins

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.CollectingCoins
{
    public class Program
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = ReadInt();
            var results = new List<string>();

            while (t-- > 0)
            {
                long[] values = ReadLongs();
                long a = values[0];
                long b = values[1];
                long c = values[2];
                long n = values[3];
                
                long sum = a + b + c + n;
                
                if (sum % 3 != 0 || sum / 3 < a || sum / 3 < b || sum / 3 < c)
                {
                    results.Add("NO");
                }
                else
                {
                    results.Add("YES");
                }
            }

            PrintResults(results);
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
            StyleHelper.Title("Collecting Coins");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}