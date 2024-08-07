// Number of Subsequences That Satisfy the Given Sum Condition

/*
You are given an array of integers nums and an integer target.

Return the number of non-empty subsequences of nums such that the sum of the minimum and maximum element on it is less or equal to target. Since the answer may be too large, return it modulo 109 + 7.

Example 1:

Input: nums = [3,5,6,7], target = 9
Output: 4
Explanation: There are 4 subsequences that satisfy the condition.
[3] -> Min value + max value <= target (3 + 3 <= 9)
[3,5] -> (3 + 5 <= 9)
[3,5,6] -> (3 + 6 <= 9)
[3,6] -> (3 + 6 <= 9)

Example 2:

Input: nums = [3,3,6,8], target = 10
Output: 6
Explanation: There are 6 subsequences that satisfy the condition. (nums can have repeated numbers).
[3] , [3] , [3,3], [3,6] , [3,6] , [3,3,6]

Example 3:

Input: nums = [2,3,3,4,6,7], target = 12
Output: 61
Explanation: There are 63 non-empty subsequences, two of them do not satisfy the condition ([6,7], [7]).
Number of valid subsequences (63 - 2 = 61).
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofSubsequencesThatSatisfytheGivenSumCondition
{
    public class Solution
    {
        public static int NumSubseq(int[] nums, int target)
        {
            Array.Sort(nums);

            int mod = 1000000007;
            int n = nums.Length;
            int result = 0;

            int[] pow2 = new int[n];
            pow2[0] = 1;

            for (int i = 1; i < n; i++)
            {
                pow2[i] = (pow2[i - 1] * 2) % mod;
            }

            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
        
                if (nums[left] + nums[right] <= target)
                {
                    result = (result + pow2[right - left]) % mod;
                    left++;
                }

                else
                {
                    right--;
                }
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {3,5,6,7};
            int target1 = 9;
            int[] nums2 = {3,3,6,8};
            int target2 = 10;
            int[] nums3 = {2,3,3,4,6,7};
            int target3 = 12;

            int result1 = Solution.NumSubseq(nums1, target1);
            int result2 = Solution.NumSubseq(nums2, target2);
            int result3 = Solution.NumSubseq(nums3, target3);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 4),
                ResultTester.CheckResult<int>(result2, 6),
                ResultTester.CheckResult<int>(result3, 61)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1498");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}