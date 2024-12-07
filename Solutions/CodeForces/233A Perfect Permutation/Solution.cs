// Perfect Permutation
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.PerfectPermutation
{
    using System;
    using System.Linq;

    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int n = ReadInt();
            Console.WriteLine(Solve(n));
        }

        private static string Solve(int n)
        {
            if (n % 2 != 0)
            {
                return "-1";
            }

            return string.Join(" ", Enumerable.Range(0, n).Select(i => i + (i % 2 == 0 ? 2 : 0)));
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Perfect Permutation");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}