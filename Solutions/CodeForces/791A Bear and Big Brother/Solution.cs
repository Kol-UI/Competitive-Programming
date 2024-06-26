// Bear and Big Brother


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.BearandBigBrother
{
    class Program
    {
        // static void Main()
        static void Solution()
        {
            string[] input = Console.ReadLine()!.Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);

            int years = 0;

            while (a <= b)
            {
                a *= 3;
                b *= 2;
                years++;
            }

            Console.WriteLine(years);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bear and Big Brother");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}