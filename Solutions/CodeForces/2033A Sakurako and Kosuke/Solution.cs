// Sakurako and Kosuke

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.SakurakoandKosuke
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();
            
            for (int i = 0; i < numberOfTestCases; i++)
            {
                int n = ReadInt();
                int p = 1;
                int x = 0;

                while (x >= -n && x <= n)
                {
                    if (p % 2 == 1)
                    {
                        x -= (2 * p - 1);
                    }
                    else
                    {
                        x += (2 * p - 1);
                    }
                    p++;
                }

                if (p % 2 == 0)
                {
                    Console.WriteLine("Sakurako");
                }
                else
                {
                    Console.WriteLine("Kosuke");
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
            StyleHelper.Title("Sakurako and Kosuke");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}