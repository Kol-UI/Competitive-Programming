using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TopKFrequentElements
{
    public class Solution
    {
        //Given an integer array nums and an integer k, return the k most frequent elements.
        //You may return the answer in any order.

        //Example 1:

        //Input: nums = [1, 1, 1, 2, 2, 3], k = 2
        //Output: [1,2]
        //Example 2:

        //Input: nums = [1], k = 1
        //Output: [1]

        public static int[] TopKFrequent(int[] nums, int k)
        {
            return nums.GroupBy(g => g).OrderByDescending(g => g.Count()).Select(g => g.Key).Take(k).ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestTopKFrequentElements()
        {
            int[] nums1 = {1, 1, 1, 2, 2, 3};
            int k1 = 2;
            int[] nums2 = {1};
            int k2 = 1;

            int[] expected1 = {1, 2};
            int[] expected2 = {1};

            int[] result1 = Solution.TopKFrequent(nums1, k1);
            int[] result2 = Solution.TopKFrequent(nums2, k2); 

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Top K Frequent Elements");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestTopKFrequentElements());
        }
    }
}