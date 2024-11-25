// Find Product
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.FindProduct
{
    class Program
    {
        //static void Main()
        static void MainSolution()
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            long answer = 1;
            const int MOD = 1000000007;

            for (int i = 0; i < n; i++)
            {
                answer = (answer * numbers[i]) % MOD;
            }

            Console.WriteLine(answer);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Product");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}