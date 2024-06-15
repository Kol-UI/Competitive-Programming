// Hipp Hipp

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Kattis.HippHipp
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Hipp hipp hurra!");
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hipp Hipp");
            ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
        }
    }
}