// Staircase

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.Staircase
{
    class Result
    {

        /*
        * Complete the 'staircase' function below.
        *
        * The function accepts INTEGER n as parameter.
        */

        public static void Staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                string spaces = new(' ', n - i);
                string hashes = new('#', i);
                Console.WriteLine(spaces + hashes);
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = {};
            for(int i = 3; i < 25; i++)
            {
                Result.Staircase(i);
                ResultTester.CheckResult<bool>(true, true);
            }
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Staircase");
            ResultTester.CheckCurrentSolution(ProblemOrigin.HackerRank, ProblemCategory.EasyHR, Test.TestCases());
        }
    }
}