// Fafa and his Company
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.FafaandhisCompany
{
    using System;
    using System.Collections.Generic;

    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int n = ReadInt();
            Console.WriteLine(Solve(n));
        }

        private static int Solve(int n)
        {
            int result = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    result++;
                }
            }
            return result;
        }

        private static string ReadLn() => Console.ReadLine()!;
        private static int ReadInt() => int.Parse(ReadLn());
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fafa and his Company");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}