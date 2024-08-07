// Longest Subarray of 1's After Deleting One Element

/*

Given a binary array nums, you should delete one element from it.

Return the size of the longest non-empty subarray containing only 1's in the resulting array. Return 0 if there is no such subarray.

 

Example 1:

Input: nums = [1,1,0,1]
Output: 3
Explanation: After deleting the number in position 2, [1,1,1] contains 3 numbers with value of 1's.

Example 2:

Input: nums = [0,1,1,1,0,1,1,0,1]
Output: 5
Explanation: After deleting the number in position 4, [0,1,1,1,1,1,0,1] longest subarray with value of 1's is [1,1,1,1,1].

Example 3:

Input: nums = [1,1,1]
Output: 2
Explanation: You must delete one element.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestSubarrayof1sAfterDeletingOneElement
{
    public class Solution
    {
        // Sliding Window
        public static int LongestSubarray(int[] nums)
        {
            int deleteCount = 0;
            int left = 0;
            int right = 0;
            int maxLength = 0;

            while(right < nums.Length)
            {
                while(deleteCount <= 1 && right < nums.Length)
                {
                    if(nums[right++] == 0)
                    {
                        deleteCount++;
                    }
                }

                maxLength = Math.Max(right - left - 2, maxLength);

                while(deleteCount > 1 && left <= right)
                {
                    if(nums[left++] == 0)
                    {
                        deleteCount--;
                    }
                }

                maxLength = Math.Max(right - left - 1, maxLength);
            }

            return maxLength;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {1,1,0,1};
            int[] nums2 = {0,1,1,1,0,1,1,0,1};
            int[] nums3 = {1,1,1};

            int result1 = Solution.LongestSubarray(nums1);
            int result2 = Solution.LongestSubarray(nums2);
            int result3 = Solution.LongestSubarray(nums3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 5),
                ResultTester.CheckResult<int>(result3, 2)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1493");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}