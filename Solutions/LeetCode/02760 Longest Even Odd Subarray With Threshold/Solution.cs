// Longest Even Odd Subarray With Threshold


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LongestEvenOddSubarrayWithThreshold
{
    public class Solution
    {
        public static int LongestAlternatingSubarray(int[] nums, int threshold) 
        {
            int longest = 0;

            for(int l = 0; l < nums.Length; l++)
            {
                if(nums[l] % 2 != 0 || nums[l] > threshold) continue;

                int len = 1;

                for(int r = l+1; r < nums.Length; r++)
                {
                    if(nums[r] > threshold || nums[r]%2 == nums[r-1]%2)
                    {
                        l = r-1;
                        break;
                    }
                    len++;
                }
                longest = Math.Max(longest, len);
            }

            return longest;
        }
    }
    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.LongestAlternatingSubarray(new int[] {3,2,5,4}, 5), 3),
                ResultTester.CheckResult<int>(Solution.LongestAlternatingSubarray(new int[] {1,2}, 2), 1),
                ResultTester.CheckResult<int>(Solution.LongestAlternatingSubarray(new int[] {2,3,4,5}, 4), 3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2760");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}