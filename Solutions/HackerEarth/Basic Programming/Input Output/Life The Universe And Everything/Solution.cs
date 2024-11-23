// Life The Universe And Everything
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.LifeTheUniverseAndEverything
{
    class Solution
    {
        //static void Main()
        static void MainSolution()
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine()!);
                int magicNumber = 42;

                if (n == magicNumber)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(n);
                }
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Life The Universe And Everything");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}