// Multiple outputs using a single line


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.Multipleoutputsusingasingleline
{
    class Program
    {
        //static void Main(string[] args)
        static void Solution()
        {
            Console.Write((3 + 4) + "\n" + (2 + 1));
        }
    }

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Multiple outputs using a single line");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}