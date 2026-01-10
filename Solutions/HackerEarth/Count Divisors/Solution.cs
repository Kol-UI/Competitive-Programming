// Count Divisors
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.HackerEarth.CountDivisors
{
    class Solution
    {
        //static void Main()
        static void MainSolution()
        {
            string[] input = Console.ReadLine()!.Split();
            int l = int.Parse(input[0]);
            int r = int.Parse(input[1]);
            int k = int.Parse(input[2]);
            int count = 0;

            while (l <= r)
            {
                if (l % k == 0)
                {
                    count++;
                }
                l++;
            }

            Console.WriteLine(count);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Divisors");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}