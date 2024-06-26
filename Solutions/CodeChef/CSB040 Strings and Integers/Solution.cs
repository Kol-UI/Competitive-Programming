// CSB040 Strings and Integers

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.StringsandIntegers
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            string num1 = "25";
            string num2 = "69";
            Console.Write(num1 + num2);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Strings and Integers");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}