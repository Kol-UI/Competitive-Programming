// Next Greater Element II

/*
Given a circular integer array nums (i.e., the next element of nums[nums.length - 1] is nums[0]), return the next greater number for every element in nums.

The next greater number of a number x is the first greater number to its traversing-order next in the array, which means you could search circularly to find its next greater number. If it doesn't exist, return -1 for this number.

 

Example 1:

Input: nums = [1,2,1]
Output: [2,-1,2]
Explanation: The first 1's next greater number is 2; 
The number 2 can't find next greater number. 
The second 1's next greater number needs to search circularly, which is also 2.

Example 2:

Input: nums = [1,2,3,4,3]
Output: [2,3,4,-1,4]
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NextGreaterElementII
{
    public class Solution
    {
        public static int[] NextGreaterElements(int[] nums)
        {
            var result = new int[nums.Length];
            Array.Fill(result, -1);
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < 2 * nums.Length; i++)
            {
                while (stack.Any() && nums[stack.Peek()] < nums[i % nums.Length])
                {
                    result[stack.Pop()] = nums[i % nums.Length];
                }
                if (i < nums.Length)
                {
                    stack.Push(i);
                }
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestNextGreaterElementII()
        {
            int[] nums1 = {1,2,1};
            int[] nums2 = {1,2,3,4,3};
            int[] result1 = Solution.NextGreaterElements(nums1);
            int[] result2 = Solution.NextGreaterElements(nums2);
            int[] expected1 = {2,-1,2};
            int[] expected2 = {2,3,4,-1,4};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2)
            };
            return results;
        }
    }
}