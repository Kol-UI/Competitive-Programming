// Fox And Snake




using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.FoxAndSnake
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(new string('#', m));
                }
                else if (i % 4 == 0)
                {
                    Console.Write(new string('.', m - 1));
                    Console.WriteLine('#');
                }
                else
                {
                    Console.Write('#');
                    Console.WriteLine(new string('.', m - 1));
                }
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Fox And Snake");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}