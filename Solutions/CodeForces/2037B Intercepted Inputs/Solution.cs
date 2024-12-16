// Intercepted Inputs
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.InterceptedInputs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int numberOfTestCases = ReadInt();
            
            List<string> results = new List<string>();
            
            for (int i = 0; i < numberOfTestCases; i++)
            {
                int k = ReadInt();
                int[] a = ReadInts();

                results.Add(Solve(a));
            }
            
            PrintResults(results);
        }

        private static string Solve(int[] a)
        {
            var valueToCount = new Dictionary<int, int>();
            foreach (int ai in a)
            {
                if (valueToCount.ContainsKey(ai))
                    valueToCount[ai]++;
                else
                    valueToCount[ai] = 1;
            }

            for (int i = 0; ; ++i)
            {
                if ((a.Length - 2) % a[i] == 0)
                {
                    int other = (a.Length - 2) / a[i];
                    if ((other == a[i] && valueToCount.GetValueOrDefault(a[i], 0) >= 2)
                        || (other != a[i]
                            && valueToCount.ContainsKey(a[i])
                            && valueToCount.ContainsKey(other)))
                    {
                        return $"{a[i]} {other}";
                    }
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
            StyleHelper.Title("Intercepted Inputs");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}