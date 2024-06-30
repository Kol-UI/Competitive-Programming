// CSB064 If & Else Statements

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.IfElseStatements
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            int Age = 25;
            int Vage = 18;
            
            if(Age >= Vage)
            {
                Console.Write("Old enough to vote!");
            }
            else
            {
                Console.Write("Not old enough to vote.");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("If & Else Statements");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}