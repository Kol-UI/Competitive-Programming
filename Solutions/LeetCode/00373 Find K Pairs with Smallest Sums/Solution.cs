// Find K Pairs with Smallest Sums

/*
You are given two integer arrays nums1 and nums2 sorted in non-decreasing order and an integer k.

Define a pair (u, v) which consists of one element from the first array and one element from the second array.

Return the k pairs (u1, v1), (u2, v2), ..., (uk, vk) with the smallest sums.

 

Example 1:

Input: nums1 = [1,7,11], nums2 = [2,4,6], k = 3
Output: [[1,2],[1,4],[1,6]]
Explanation: The first 3 pairs are returned from the sequence: [1,2],[1,4],[1,6],[7,2],[7,4],[11,2],[7,6],[11,4],[11,6]

Example 2:

Input: nums1 = [1,1,2], nums2 = [1,2,3], k = 2
Output: [[1,1],[1,1]]
Explanation: The first 2 pairs are returned from the sequence: [1,1],[1,1],[1,2],[2,1],[1,2],[2,2],[1,3],[1,3],[2,3]

Example 3:

Input: nums1 = [1,2], nums2 = [3], k = 3
Output: [[1,3],[2,3]]
Explanation: All possible pairs are returned from the sequence: [1,3],[2,3]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindKPairswithSmallestSums
{
    public class Solution
    {
        public static IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            int n = nums1.Length;
            int m = nums2.Length;

            var prio = new PriorityQueue<(int, int), int>();
            prio.Enqueue((0, 0), nums1[0] + nums2[0]);

            var visited = new HashSet<(int, int)>();
            var retList = new List<IList<int>>();

            while (prio.Count > 0 && retList.Count < k)
            {
                var cur = prio.Dequeue();

                int x = cur.Item1;
                int y = cur.Item2;

                retList.Add(new List<int>{nums1[x], nums2[y]});
                visited.Add((x, y));

                if (x + 1 < n && y < m && !visited.Contains((x + 1, y)))
                {
                    prio.Enqueue((x + 1, y), nums1[x + 1] + nums2[y]);
                    visited.Add((x + 1, y));
                }   

                if (x < n && y + 1 < m && !visited.Contains((x, y + 1)))
                {
                    prio.Enqueue((x, y + 1), nums1[x] + nums2[y + 1]);
                    visited.Add((x, y + 1));
                } 
            }

            return retList;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1_1 = {1,7,11}; int[] nums2_1 = {2,4,6}; int k_1 = 3;
            int[] nums1_2 = {1,1,2}; int[] nums2_2 = {1,2,3}; int k_2 = 2;
            int[] nums1_3 = {1,2}; int[] nums2_3 = {3}; int k_3 = 3;

            IList<IList<int>> result1 = new List<IList<int>>
            {
                new List<int> { 1, 2 },
                new List<int> { 1, 4 },
                new List<int> { 1, 6 }
            };

            IList<IList<int>> result2 = new List<IList<int>>
            {
                new List<int> { 1, 1 },
                new List<int> { 1, 1 }
            };

            IList<IList<int>> result3 = new List<IList<int>>
            {
                new List<int> { 1, 3 },
                new List<int> { 2, 3 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(Solution.KSmallestPairs(nums1_1, nums2_1, k_1), result1),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.KSmallestPairs(nums1_2, nums2_2, k_2), result2),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.KSmallestPairs(nums1_3, nums2_3, k_3), result3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Removable Characters");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}