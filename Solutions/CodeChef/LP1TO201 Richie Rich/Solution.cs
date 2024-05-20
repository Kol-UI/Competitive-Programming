// Richie Rich


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.RichieRich
{
    public class Solution
    {
        //public static void Main()
        public static void MySolution()
        {
            int T = int.Parse(Console.ReadLine()!);

            for (int t = 0; t < T; t++)
            {
                string[] input = Console.ReadLine()!.Split();
                long A = long.Parse(input[0]);
                long B = long.Parse(input[1]);
                long X = long.Parse(input[2]);

                long years = (B - A) / X;
                Console.WriteLine(years);
            }
        }
    }

    public class Test
    {
        public static long Solution(long A, long B, long X)
        {
            long years = (B - A) / X;
            return years;
        }
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Test.Solution(1, 5, 2), 2),
                ResultTester.CheckResult<long>(Test.Solution(2, 10, 3), 2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Richie Rich");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeChef, ProblemCategory.BeginnerCC, Test.TestCases());
        }
    }
}