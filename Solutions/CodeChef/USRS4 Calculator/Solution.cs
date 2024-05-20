// Calculator

/*
Write a program for the following

Create a calculator.
Declare 2 integer variables a and b.
Initialize the variables a and b based on two user inputs.
Output sum and difference to the console on separate lines.
*/
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.Calculator
{
    /*
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum is: " + (a + b));
            Console.WriteLine("Difference is: " + (a - b));
        }
    }
  */

    public class Test : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Calculator");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}