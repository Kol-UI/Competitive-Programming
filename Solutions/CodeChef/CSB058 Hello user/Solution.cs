// CSB058 Hello user

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.Hellouser
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            string x = Console.ReadLine()!;
            Console.Write("Hello " + x);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hello user");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}