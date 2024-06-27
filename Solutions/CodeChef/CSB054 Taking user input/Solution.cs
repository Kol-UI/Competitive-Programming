// CSB054 Taking user input

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.Takinguserinput
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your number is: " + a);
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Taking user input");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}