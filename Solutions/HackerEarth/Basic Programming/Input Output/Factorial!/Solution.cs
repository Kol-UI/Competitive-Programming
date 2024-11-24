// Factorial!
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.Factorial
{
    class Program
    {
        //static void Main()
        static void MainSolution()
        {
            int n = int.Parse(Console.ReadLine()!);
            long factorial = 1;

            while (n > 0)
            {
                factorial *= n;
                n--;
            }

            Console.WriteLine(factorial);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Factorial!");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}