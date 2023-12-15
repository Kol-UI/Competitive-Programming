// Maximum Value at a Given Index in a Bounded Array

/*
You are given three positive integers: n, index, and maxSum. You want to construct an array nums (0-indexed) that satisfies the following conditions:

nums.length == n
nums[i] is a positive integer where 0 <= i < n.
abs(nums[i] - nums[i+1]) <= 1 where 0 <= i < n-1.
The sum of all the elements of nums does not exceed maxSum.
nums[index] is maximized.
Return nums[index] of the constructed array.

Note that abs(x) equals x if x >= 0, and -x otherwise.

 

Example 1:

Input: n = 4, index = 2,  maxSum = 6
Output: 2
Explanation: nums = [1,2,2,1] is one array that satisfies all the conditions.
There are no arrays that satisfy all the conditions and have nums[2] == 3, so 2 is the maximum nums[2].

Example 2:

Input: n = 6, index = 1,  maxSum = 10
Output: 3
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumValueataGivenIndexinaBoundedArray
{
    public class Solution
    {
        public static int MaxValue(int n, int index, int maxSum)
        {
            long l = index;
            long r = n - index - 1;
            long low = 1;
            long high = maxSum;
            long res = 0;
            long ls = 0;
            long rs = 0;

            while(low <= high)
            {
                long mid = low + (high-low)/2;
                long sum = mid;
                long m  = mid-1;
                if(r <= m)
                {
                    rs = m*(m+1)/2 - (m-r)*(m-r+1)/2;
                }
                else
                {
                    rs = m*(m+1)/2 + (r-m);
                }
                if(l <= m)
                {
                    ls = m*(m+1)/2 - (m-l)*(m-l+1)/2;
                }
                else
                {
                    ls = m*(m+1)/2 + (l-m);
                }
                sum += ls + rs;
                if(sum <= maxSum)
                {
                    res = mid;
                    low = mid+1;
                }
                else
                {
                    high = mid-1;
                }
            }
            return (int)res;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int n1 = 4;
            int index1 = 2;
            int maxSum1 = 6;
            int output1_1802 = 2;

            int n2 = 6;
            int index2 = 1;
            int maxSum2 = 10;
            int output2_1802 = 3;

            int result1 = Solution.MaxValue(n1, index1, maxSum1);
            int result2 = Solution.MaxValue(n2, index2, maxSum2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1_1802),
                ResultTester.CheckResult<int>(result2, output2_1802)
            };
            return results;
        }
    }
}