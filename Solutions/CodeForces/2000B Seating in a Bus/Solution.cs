// Seating in a Bus

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.SeatinginaBus
{
    using System;
    using System.Linq;

    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int t = ReadInt();
            for (int tc = 0; tc < t; tc++)
            {
                int n = ReadInt();
                int[] a = ReadInts();

                Console.WriteLine(Solve(a) ? "YES" : "NO");
            }
        }

        private static bool Solve(int[] a)
        {
            int n = a.Length;
            bool[] occupied = new bool[n];

            for (int i = 0; i < a.Length; ++i)
            {
                if (i != 0 && (a[i] == 1 || !occupied[a[i] - 2]) && (a[i] == n || !occupied[a[i]]))
                {
                    return false;
                }

                occupied[a[i] - 1] = true;
            }

            return true;
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
        private static long ReadLong() => long.Parse(ReadLn());
        private static double ReadDouble() => double.Parse(ReadLn());
        private static string[] ReadStrings() => ReadLn().Split(' ');
        private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
        private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
        private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
        private static void PrintResults<T>(System.Collections.Generic.List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Seating in a Bus");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}