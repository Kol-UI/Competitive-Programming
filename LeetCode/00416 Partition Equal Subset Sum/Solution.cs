// Partition Equal Subset Sum

/*
Given an integer array nums, return true if you can partition the array into two subsets such that the sum of the elements in both subsets is equal or false otherwise.

 

Example 1:

Input: nums = [1,5,11,5]
Output: true
Explanation: The array can be partitioned as [1, 5, 5] and [11].

Example 2:

Input: nums = [1,2,3,5]
Output: false
Explanation: The array cannot be partitioned into equal sum subsets.
*/

namespace CompetitiveProgramming.LeetCode.PartitionEqualSubsetSum
{
    public class Solution
    {
        public static bool CanPartition(int[] nums)
        {
            int sum = nums.Sum();
            if(sum % 2 == 1)
            {
                return false;
            }
            int needsum = sum / 2;

            bool[] dp = new bool[needsum + 1];

            dp[0] = true;

            foreach(int num in nums)
            {
                for (int i = needsum; i > 0; i--)
                {
                    if (i >= num)
                    {
                        dp[i] = dp[i] || dp[i - num];
                    }
                }
            }

            return dp[needsum];    
        }
    }
}