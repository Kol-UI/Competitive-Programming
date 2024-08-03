// Smallest Range II

/*
You are given an integer array nums and an integer k.

For each index i where 0 <= i < nums.length, change nums[i] to be either nums[i] + k or nums[i] - k.

The score of nums is the difference between the maximum and minimum elements in nums.

Return the minimum score of nums after changing the values at each index.

 

Example 1:

Input: nums = [1], k = 0
Output: 0
Explanation: The score is max(nums) - min(nums) = 1 - 1 = 0.

Example 2:

Input: nums = [0,10], k = 2
Output: 6
Explanation: Change nums to be [2, 8]. The score is max(nums) - min(nums) = 8 - 2 = 6.

Example 3:

Input: nums = [1,3,6], k = 3
Output: 3
Explanation: Change nums to be [4, 6, 3]. The score is max(nums) - min(nums) = 6 - 3 = 3.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SmallestRangeII
{
    public class Solution
    {
        public static int SmallestRangeII(int[] A, int K)
        {
            int N = A.Length;
            Array.Sort(A);
            int result = A[N-1] - A[0];

            for (int i = 0; i < A.Length - 1; ++i)
            {
                int a = A[i], b = A[i + 1];
                int high = Math.Max(A[N - 1] - K, a + K);
                int low = Math.Min(A[0] + K, b - K);
                result = Math.Min(result, high - low);
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestSmallestRangeII()
        {
            int[] nums1 = {1}; int k1 = 0;
            int[] nums2 = {0, 10}; int k2 = 2;
            int[] nums3 = {1, 3, 6}; int k3 = 3;
            int result1 = Solution.SmallestRangeII(nums1, k1);
            int result2 = Solution.SmallestRangeII(nums2, k2);
            int result3 = Solution.SmallestRangeII(nums3, k3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 0),
                ResultTester.CheckResult<int>(result2, 6),
                ResultTester.CheckResult<int>(result3, 3)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Smallest Range II");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestSmallestRangeII());
        }
    }
}