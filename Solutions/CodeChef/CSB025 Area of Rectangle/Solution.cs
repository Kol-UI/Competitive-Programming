// Area of Rectangle


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.AreaofRectangle
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            int length = 45;
            int width = 76;
            int area = length * width;
            Console.Write("The Area of the given rectangle is " + area);
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Area of Rectangle");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}