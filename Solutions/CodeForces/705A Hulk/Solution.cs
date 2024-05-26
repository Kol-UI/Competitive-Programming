// 705A - Hulk



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.Hulk
{
    class Solution
    {
        //static void Main(string[] args)
        static void Problem()
        {
            int n = int.Parse(Console.ReadLine()!);
            string result = "";

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    result += "I hate";
                }
                else
                {
                    result += "I love";
                }

                if (i != n)
                {
                    result += " that ";
                }
            }

            result += " it";

            Console.WriteLine(result);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hulk");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}