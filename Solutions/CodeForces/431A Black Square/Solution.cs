// Black Square

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.BlackSquare
{
    public class Solution
    {
        //public static void Main(string[] args)
        public static void MainSolution()
        {
            int[] calories = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            string s = Console.ReadLine()!;

            int totalCalories = 0;

            foreach (char c in s)
            {
                int strip = c - '1';

                totalCalories += calories[strip];
            }

            Console.WriteLine(totalCalories);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Black Square");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}