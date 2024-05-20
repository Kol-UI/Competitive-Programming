// Inserting space between outputs



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.Insertingspacebetweenoutputs
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            Console.Write((3 + 4) + " " + (2 + 1));
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Inserting space between outputs");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}