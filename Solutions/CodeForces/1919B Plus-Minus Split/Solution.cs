// Plus-Minus Split


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.PlusMinusSplit
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            for (int t = 0; t < T; t++)
            {
                Solve();
            }
        }
        */

        static void Solve()
        {
            long n = long.Parse(Console.ReadLine()!);
            string s = Console.ReadLine()!;

            long sum = 0;
            foreach (char ch in s)
            {
                if (ch == '+')
                    sum++;
                else
                    sum--;
            }

            Console.WriteLine(Math.Abs(sum));
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Plus-Minus Split");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}