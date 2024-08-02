// Maximum Subsequence Score

/*
You are given two 0-indexed integer arrays nums1 and nums2 of equal length n and a positive integer k. You must choose a subsequence of indices from nums1 of length k.

For chosen indices i0, i1, ..., ik - 1, your score is defined as:

The sum of the selected elements from nums1 multiplied with the minimum of the selected elements from nums2.
It can defined simply as: (nums1[i0] + nums1[i1] +...+ nums1[ik - 1]) * min(nums2[i0] , nums2[i1], ... ,nums2[ik - 1]).
Return the maximum possible score.

A subsequence of indices of an array is a set that can be derived from the set {0, 1, ..., n-1} by deleting some or no elements.


Example 1:

Input: nums1 = [1,3,3,2], nums2 = [2,1,3,4], k = 3
Output: 12
Explanation: 
The four possible subsequence scores are:
- We choose the indices 0, 1, and 2 with score = (1+3+3) * min(2,1,3) = 7.
- We choose the indices 0, 1, and 3 with score = (1+3+2) * min(2,1,4) = 6. 
- We choose the indices 0, 2, and 3 with score = (1+3+2) * min(2,3,4) = 12. 
- We choose the indices 1, 2, and 3 with score = (3+3+2) * min(1,3,4) = 8.
Therefore, we return the max score, which is 12.

Example 2:

Input: nums1 = [4,2,3,1,1], nums2 = [7,5,10,9,6], k = 1
Output: 30
Explanation: 
Choosing index 2 is optimal: nums1[2] * nums2[2] = 3 * 10 = 30 is the maximum possible score.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumSubsequenceScore
{
    public class Solution
    {
        public static long MaxScore(int[] nums1, int[] nums2, int k)
        {
            long result = long.MinValue;
            int n = nums1.Length;
            int[][] mat = new int[n][];
            for(int i = 0; i < n; i++) mat[i] = new int[] { nums1[i], nums2[i] };
            
            mat = mat.OrderBy(x => -x[1]).ToArray();

            var pq = new PriorityQueue<int, int>();
            long sum = 0;

            for(int i = 0; i < n; i++)
            {
                sum += mat[i][0];
                pq.Enqueue(mat[i][0], mat[i][0]);

                if (pq.Count >k) sum -= pq.Dequeue();
                if (pq.Count >= k) result = Math.Max(result, sum*mat[i][1]);
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1_1 = {1,3,3,2};
            int[] nums2_1 = {2,1,3,4};
            int k1 = 3;

            int[] nums1_2 = {4,2,3,1,1};
            int[] nums2_2 = {7,5,10,9,6};
            int k2 = 1;

            long result1 = Solution.MaxScore(nums1_1, nums2_1, k1);
            long result2 = Solution.MaxScore(nums1_2, nums2_2, k2);

            long output1 = 12;
            long output2 = 30;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(result1, output1),
                ResultTester.CheckResult<long>(result2, output2)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Maximum Subsequence Score");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}