// Sum of All Odd Length Subarrays

/*
Given an array of positive integers arr, return the sum of all possible odd-length subarrays of arr.

A subarray is a contiguous subsequence of the array.

 

Example 1:

Input: arr = [1,4,2,5,3]
Output: 58
Explanation: The odd-length subarrays of arr and their sums are:
[1] = 1
[4] = 4
[2] = 2
[5] = 5
[3] = 3
[1,4,2] = 7
[4,2,5] = 11
[2,5,3] = 10
[1,4,2,5,3] = 15
If we add all these together we get 1 + 4 + 2 + 5 + 3 + 7 + 11 + 10 + 15 = 58

Example 2:

Input: arr = [1,2]
Output: 3
Explanation: There are only 2 subarrays of odd length, [1] and [2]. Their sum is 3.

Example 3:

Input: arr = [10,11,12]
Output: 66
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SumofAllOddLengthSubarrays
{
    public class Solution
    {
        public static int SumOddLengthSubarrays(int[] arr)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if ((j - i + 1) % 2 == 1)
                    {
                        int sum = 0;
                        for (int k = i; k < j + 1; k++)
                            sum += arr[k];
                        res += sum;
                    }
                }
            }
            return res;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] arr1 = {1,4,2,5,3};
            int[] arr2 = {1,2};
            int[] arr3 = {10,11,12};

            int result1 = Solution.SumOddLengthSubarrays(arr1);
            int result2 = Solution.SumOddLengthSubarrays(arr2);
            int result3 = Solution.SumOddLengthSubarrays(arr3);

            int output1_1588 = 58;
            int output2_1588 = 3;
            int output3_1588 = 66;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1_1588),
                ResultTester.CheckResult<int>(result2, output2_1588),
                ResultTester.CheckResult<int>(result3, output3_1588)
            };
            return results;
        }
    }
}