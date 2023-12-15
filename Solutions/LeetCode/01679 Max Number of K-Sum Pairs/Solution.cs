// Max Number of K-Sum Pairs

/*
You are given an integer array nums and an integer k.

In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.

Return the maximum number of operations you can perform on the array.

 

Example 1:

Input: nums = [1,2,3,4], k = 5
Output: 2
Explanation: Starting with nums = [1,2,3,4]:
- Remove numbers 1 and 4, then nums = [2,3]
- Remove numbers 2 and 3, then nums = []
There are no more pairs that sum up to 5, hence a total of 2 operations.

Example 2:

Input: nums = [3,1,3,4,3], k = 6
Output: 1
Explanation: Starting with nums = [3,1,3,4,3]:
- Remove the first two 3's, then nums = [1,4,3]
There are no more pairs that sum up to 6, hence a total of 1 operation.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaxNumberofKSumPairs
{
    public class Solution
    {
        public static int MaxOperations(int[] nums, int k)
        {
            int n = nums.Length;
            int count = 0;
            int start = 0;
            int end = n - 1;
            
            Array.Sort(nums);

            while(start < end)
            {
                if(nums[start] + nums[end] == k)
                {
                    count++;
                    start++;
                    end--;
                }
                else if(nums[start] + nums[end] < k) start++;
                else end--;
            }

            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[] nums1 = {1,2,3,4};
            int k1 = 5;
            int result1 = Solution.MaxOperations(nums1, k1);

            // Case 2
            int[] nums2 = {3,1,3,4,3};
            int k2 = 6;
            int result2 = Solution.MaxOperations(nums2, k2);

            int output1 = 2;
            int output2 = 1;
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1),
                ResultTester.CheckResult<int>(result2, output2)
            };
            return results;
        }
    }
}