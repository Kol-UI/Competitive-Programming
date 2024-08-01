// Maximum Sum With Exactly K Elements 


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumSumWithExactlyKElements
{
    public class Solution
    {
        public static int MaximizeSum(int[] nums, int k) => Enumerable.Range(nums.Max(), k).Sum();
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaximizeSum(new int[]{1,2,3,4,5}, 3), 18),
                ResultTester.CheckResult<int>(Solution.MaximizeSum(new int[]{5,5,5}, 2), 11),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Sum With Exactly K Elements");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}