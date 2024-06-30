// CSB055 Calculator

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.Calculator
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int diff = a - b;
            Console.WriteLine("Sum is: " + sum);
            Console.Write("Difference is: " + diff);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculator");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}