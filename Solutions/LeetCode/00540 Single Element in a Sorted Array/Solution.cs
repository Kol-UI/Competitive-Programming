using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SingleElementinaSortedArray
{
    // You are given a sorted array consisting of only integers where every element appears exactly twice, except for one element which appears exactly once.
    // Return the single element that appears only once.
    // Your solution must run in O(log n) time and O(1) space.

    // Example 1:
    // Input: nums = [1,1,2,3,3,4,4,8,8]
    // Output: 2
    
    // Example 2:
    // Input: nums = [3,3,7,7,10,11,11]
    // Output: 10

    public class Solution
    {
        public static int SingleNonDuplicate(int[] nums) => nums.Aggregate((x, y) => x ^ y);
    }

    public class Test
    {
        public static bool[] TestSingleElementinaSortedArray()
        {
            // Case 1
            int[] Case1_540 = { 1, 1, 2, 3, 3, 4, 4, 8, 8 };
            int resultCase1_540 = Solution.SingleNonDuplicate(Case1_540);

            // Case 2
            int[] Case2_540 = { 3, 3, 7, 7, 10, 11, 11 };
            int resultCase2_540 = Solution.SingleNonDuplicate(Case2_540);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(resultCase1_540, 2),
                ResultTester.CheckResult<int>(resultCase2_540, 10)
            };
            return results;
        }
    }
}


