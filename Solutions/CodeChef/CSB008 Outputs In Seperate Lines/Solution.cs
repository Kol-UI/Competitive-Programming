// CSB008 Outputs In Seperate Lines


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.CSB008OutputsInSeperateLines
{
    class Program
    {
        // static void Main(string[] args)
        public static void Solution()
        {
            Console.Write(3 + 4);
            Console.WriteLine();
            Console.Write(2 + 1);
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Outputs In Seperate lines");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}