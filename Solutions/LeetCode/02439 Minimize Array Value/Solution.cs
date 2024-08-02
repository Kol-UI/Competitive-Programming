using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimizeMaximumofArray
{
    public class Solution
    {
        public static int MinimizeArrayValue(int[] nums)
        {
            int result = 0;
            int lowest = nums.Min();
            int highest = nums.Max();

            while (lowest <= highest)
            {
                long mid = ((long)lowest + (long)highest) / 2;

                if (isValidMid(nums, mid))
                {
                    result = (int)mid;
                    highest = result - 1;
                }
                else
                {
                    lowest = (int)mid + 1;
                }
            }
            return result;
        }

        private static bool isValidMid(int[] nums, long mid)
        {
            long tempRem = 0;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] <= mid)
                {
                    tempRem -= Math.Min(tempRem, mid - nums[i]);
                }
                else
                {
                    tempRem += nums[i] - mid;
                }
            }
            return tempRem <= 0;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[] nums2439_1 = {3,7,1,6};
            int result2439_1 = Solution.MinimizeArrayValue(nums2439_1);

            // Case 2
            int[] nums2439_2 = {10,1};
            int result2439_2 = Solution.MinimizeArrayValue(nums2439_2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result2439_1, result2439_1),
                ResultTester.CheckResult<int>(result2439_2, result2439_2)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimize Array Value");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}