// Rearrange Array Elements by Sign


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RearrangeArrayElementsbySign
{
    public class Solution
    {
        public static int[] RearrangeArray(int[] nums)
        {
            int[] rearranged = new int[nums.Length];
            int position = 0;
            int value = 1;

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] > 0)
                {
                    rearranged[position] = nums[i];
                    position += 2;
                }
                else
                {
                    rearranged[value] = nums[i];
                    value += 2;
                }
            }
            return rearranged;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.RearrangeArray(new int[] {3,1,-2,-5,2,-4}), new int[]{3,-2,1,-5,2,-4}),
                ResultTester.CheckResult<int[]>(Solution.RearrangeArray(new int[] {-1,1}), new int[]{1,-1}),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Rearrange Array Elements by Sign");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}