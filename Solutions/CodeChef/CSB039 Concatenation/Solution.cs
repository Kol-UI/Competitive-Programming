// CSB039 Concatenation
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.Concatenation
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            string x = "Hello";
            string y = "World";
            
            Console.WriteLine(x + " " + y);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Concatenation");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}