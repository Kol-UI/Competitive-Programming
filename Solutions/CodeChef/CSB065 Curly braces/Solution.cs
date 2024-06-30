// CSB065 Curly braces

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.Curlybraces
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            int Age = 25;
            int Vage = 18;
            
            if(Age < Vage)
            {
                Console.WriteLine("Not old enough to vote.");
                Console.Write("Wait for " + (Vage - Age) + " years");
            }
            else
            {
                Console.Write("Old enough to vote!");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Curly braces");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}