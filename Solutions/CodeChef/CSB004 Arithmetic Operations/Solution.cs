// CSB004 Arithmetic Operations


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.CSB004ArithmeticOperations
{
    class Program
    {
        //static void Main(string[] args)
        public static void Solution()
        {
            Console.Write(21 + 40);
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("CSB004 Arithmetic Operations");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}