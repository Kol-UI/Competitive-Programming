// CSB067 Else If Statement


using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeChef.ElseIfStatement
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            int r = 45;
            int b = 23;
            if(r > b)
            {
                Console.WriteLine("Rob Scored higher marks than Bob.");
            }
            else if(r == b)
            {
                Console.WriteLine("Bob & Rob both scored the same");
            }
            
            r = 15;
            b = 15;
            if(r > b)
            {
                Console.WriteLine("Rob Scored higher marks than Bob.");
            }
            else if(r == b)
            {
                Console.WriteLine("Bob & Rob both scored the same");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Else If Statement");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}