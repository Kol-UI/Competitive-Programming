// Minimum Cost to Make Array Equal

/*
You are given two 0-indexed arrays nums and cost consisting each of n positive integers.

You can do the following operation any number of times:

Increase or decrease any element of the array nums by 1.
The cost of doing one operation on the ith element is cost[i].

Return the minimum total cost such that all the elements of the array nums become equal.

 

Example 1:

Input: nums = [1,3,5,2], cost = [2,3,1,14]
Output: 8
Explanation: We can make all the elements equal to 2 in the following way:
- Increase the 0th element one time. The cost is 2.
- Decrease the 1st element one time. The cost is 3.
- Decrease the 2nd element three times. The cost is 1 + 1 + 1 = 3.
The total cost is 2 + 3 + 3 = 8.
It can be shown that we cannot make the array equal with a smaller cost.

Example 2:

Input: nums = [2,2,2,2,2], cost = [4,2,8,1,3]
Output: 0
Explanation: All the elements are already equal, so no operations are needed.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumCosttoMakeArrayEqual
{
    public class Solution 
    {
        public static long MinCost(int[] nums, int[] cost)
        {
            int l = nums.Min();
            int r = nums.Max();
            long minsum = long.MaxValue;
            
            while(r - l > 2)
            {
                int mediuml = l + (r - l) / 3;
                int mediumr = r - (r - l) / 3;
                if(CountCost(nums, cost, mediuml) > CountCost(nums, cost, mediumr))
                {
                    l = mediuml;
                }
                else
                {
                    r = mediumr;
                }
            }
            for(int i = l; i <= r; i++)
            {
                minsum = Math.Min(minsum, CountCost(nums, cost, i));
            }
            
            return minsum;
        }
        
        public static long CountCost(int[] nums, int[] cost, long dest)
        {
            long sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += (long) Math.Abs(dest-nums[i]) * cost[i]; 
            }
            
            return sum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {1,3,5,2}; int[] cost1 = {2,3,1,14};
            int[] nums2 = {2,2,2,2,2}; int[] cost2 = {4,2,8,1,3};
            double result1 = Solution.MinCost(nums1, cost1);
            double result2 = Solution.MinCost(nums2, cost2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(result1, 8),
                ResultTester.CheckResult<double>(result2, 0)
            };
            return results;
        }
    }
}