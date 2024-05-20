// Storing Boxes


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.StoringBoxes
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            int length = 11;
            int width = 13;
            Console.WriteLine(length * width);
            Console.WriteLine(2 * (length + width));
            width = 15;
            Console.WriteLine(length * width);
            Console.WriteLine(2 * (length + width));
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Storing Boxes");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}