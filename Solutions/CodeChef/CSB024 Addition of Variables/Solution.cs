// Addition of Variables



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.AdditionofVariables
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            int a = 23;
            int b = 20;
            Console.WriteLine(a + b);
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Addition of variables");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}