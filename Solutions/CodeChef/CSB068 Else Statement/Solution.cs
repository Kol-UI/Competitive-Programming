// CSB068 Else Statement
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.ElseStatement
{
    class Program
    {
        //static void Main(string[] args)
        static void MainSolution()
        {
            int r = 24;
            int k = 32;
            if(r > k)
            {
                Console.WriteLine("Ram is heavier than Karan.");
            }
            else if(r < k)
            {
                Console.WriteLine("Karan is heavier than Ram");
            }
            else
            {
                Console.WriteLine("Ram & Karan have the same weight!");
            }
            
            r = 78;
            k = 78;
            if(r > k)
            {
                Console.WriteLine("Ram is heavier than Karan.");
            }
            else if(r < k)
            {
                Console.WriteLine("Karan is heavier than Ram");
            }
            else
            {
                Console.WriteLine("Ram & Karan have the same weight!");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Else Statement");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.LearnCC);
        }
    }
}