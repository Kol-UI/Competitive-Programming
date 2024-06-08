// Beginner Series #2 Clock

/*
Clock shows h hours, m minutes and s seconds after midnight.

Your task is to write a function which returns the time since midnight in milliseconds.

Example:
h = 0
m = 1
s = 1

result = 61000

Input constraints:

0 <= h <= 23
0 <= m <= 59
0 <= s <= 59
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeWars.EightKyu.BeginnerSeries2Clock
{
    public class Solution 
    {
        public static int Past(int h, int m, int s)
        {
            return (h * 60 * 60 + m * 60 + s) * 1000;
        }

        public static bool[] TestBeginnerSeries2Clock()
        {
            int h = 0;
            int m = 1;
            int s = 1;
            int result1 = Past(h, m, s);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 61000),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Clock 1");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Solution.TestBeginnerSeries2Clock());
        }
    }
}