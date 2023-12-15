// Sliding Window Maximum

/*
You are given an array of integers nums, there is a sliding window of size k which is moving from the very left of the array to the very right. You can only see the k numbers in the window. Each time the sliding window moves right by one position.

Return the max sliding window.

 

Example 1:

Input: nums = [1,3,-1,-3,5,3,6,7], k = 3
Output: [3,3,5,5,6,7]
Explanation: 
Window position                Max
---------------               -----
[1  3  -1] -3  5  3  6  7       3
 1 [3  -1  -3] 5  3  6  7       3
 1  3 [-1  -3  5] 3  6  7       5
 1  3  -1 [-3  5  3] 6  7       5
 1  3  -1  -3 [5  3  6] 7       6
 1  3  -1  -3  5 [3  6  7]      7
Example 2:

Input: nums = [1], k = 1
Output: [1]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SlidingWindowMaximum
{
    public class Solution
    {
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0)
            {
                return new int[0];
            }
        
            int n = nums.Length;
            int[] result = new int[n - k + 1];
            int ri = 0; 
            LinkedList<int> deque = new();
            
            for (int i = 0; i < n; i++)
            {
                while (deque.Count > 0 && deque.First!.Value < i - k + 1)
                {
                    deque.RemoveFirst();
                }
                
                while (deque.Count > 0 && nums[deque.Last!.Value] < nums[i])
                {
                    deque.RemoveLast();
                }
                
                deque.AddLast(i);
                
                if (i >= k - 1)
                {
                    result[ri++] = nums[deque.First!.Value];
                }
            }
            
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums = {1,3,-1,-3,5,3,6,7};
            int k = 3;
            int[] expected = {3,3,5,5,6,7};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.MaxSlidingWindow(nums, k), expected),
            };
            return results;
        }
    }
}
