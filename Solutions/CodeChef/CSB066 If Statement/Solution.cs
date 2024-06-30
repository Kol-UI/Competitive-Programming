// CSB066 If Statement

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.IfStatement
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if(a > b)
            {
                Console.Write("Coding is Fun!");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("If Statement");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}