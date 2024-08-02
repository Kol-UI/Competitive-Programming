// Check if Array is Good


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CheckifArrayisGood
{
    public class Solution
    {
        public static bool IsGood(int[] nums)
        {
            Array.Sort(nums);

            for(int i = 0; i < nums.Length; i++)
            {
                if(i < nums.Length - 1)
                {
                    if(nums[i] != i + 1)
                    {
                        return false;
                    }
                }
                else
                {
                    if(nums[i] != i)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsGood(new int[] {2, 1, 3}), false),
                ResultTester.CheckResult<bool>(Solution.IsGood(new int[] {1, 3, 3, 2}), true),
                ResultTester.CheckResult<bool>(Solution.IsGood(new int[] {1, 1}), true),
                ResultTester.CheckResult<bool>(Solution.IsGood(new int[] {3, 4, 4, 1, 2, 1}), false),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2784");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}