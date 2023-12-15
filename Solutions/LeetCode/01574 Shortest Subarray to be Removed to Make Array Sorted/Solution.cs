// Shortest Subarray to be Removed to Make Array Sorted

/*
Given an integer array arr, remove a subarray (can be empty) from arr such that the remaining elements in arr are non-decreasing.

Return the length of the shortest subarray to remove.

A subarray is a contiguous subsequence of the array.

 

Example 1:

Input: arr = [1,2,3,10,4,2,3,5]
Output: 3
Explanation: The shortest subarray we can remove is [10,4,2] of length 3. The remaining elements after that will be [1,2,3,3,5] which are sorted.
Another correct solution is to remove the subarray [3,10,4].

Example 2:

Input: arr = [5,4,3,2,1]
Output: 4
Explanation: Since the array is strictly decreasing, we can only keep a single element. Therefore we need to remove a subarray of length 4, either [5,4,3,2] or [4,3,2,1].

Example 3:

Input: arr = [1,2,3]
Output: 0
Explanation: The array is already non-decreasing. We do not need to remove any elements.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShortestSubarraytobeRemovedtoMakeArraySorted
{
    public class Solution
    {
        public static int FindLengthOfShortestSubarray(int[] arr)
        {
            int n = arr.Length;
            if (n < 2) return 0;
            int result = 0;

            if (arr[0] == arr[n-1])
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] != arr[0]) result++;
                }
                return result;
            }
            
            int l = 0;
            int r = n - 1;
            for (;r > 0 && arr[r - 1] <= arr[r]; r--);
            result = r;

            for (; l < r && (l == 0 || arr[l - 1] <= arr[l]); l++)
            {
                while (r < n && arr[r] < arr[l]) r++;
                result = Math.Min(result, r-l-1);
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] arr1 = {1,2,3,10,4,2,3,5};
            int[] arr2 = {5,4,3,2,1};
            int[] arr3 = {1,2,3};
            int result1 = Solution.FindLengthOfShortestSubarray(arr1);
            int result2 = Solution.FindLengthOfShortestSubarray(arr2);
            int result3 = Solution.FindLengthOfShortestSubarray(arr3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 4),
                ResultTester.CheckResult<int>(result3, 0)
            };
            return results;
        }
    }
}