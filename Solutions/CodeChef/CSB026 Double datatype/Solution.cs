// Double datatype


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.Doubledatatype
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            double pi = 3.14;
            double radius = 8.9;
            double area = pi * radius * radius;
            Console.Write("The Area of the given Circle is " + area);
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Double datatype");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}