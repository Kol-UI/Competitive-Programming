// Area & Perimeter of Rectangle

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.CSB009AreaPerimeterofRectangle
{
    class Program
    {
        // static void Main(string[] args)
        public static void Solution()
        {
            Console.WriteLine(11 * 13);
            Console.Write(2 * (11 + 13));
        }
    }
    
    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Area & Perimeter of Rectangle");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}