// Hoop Jump


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.HoopJump
{

    public class Test
    {
        //public static void Main()
        public static void Solution()
        {
            int T = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine()!);
                int lastHoop = (N + 1) / 2;
                Console.WriteLine(lastHoop);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Hoop Jump");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.BeginnerCC);
        }
    }

}