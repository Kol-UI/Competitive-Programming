// Borze

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.Borze
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            string input = Console.ReadLine()!;
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.')
                {
                    result += "0";
                }
                else if (input[i] == '-' && input[i + 1] == '.')
                {
                    result += "1";
                    i++;
                }
                else if (input[i] == '-' && input[i + 1] == '-')
                {
                    result += "2";
                    i++;
                }
            }

            Console.WriteLine(result);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Borze");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}