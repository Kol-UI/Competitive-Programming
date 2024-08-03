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

using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestPartitionEqualSubsetSum()
        {
            int[] nums1 = {1,5,11,5};
            int[] nums2 = {1,2,3,5};
            bool result1 = Solution.CanPartition(nums1);
            bool result2 = Solution.CanPartition(nums2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, true),
                ResultTester.CheckResult<bool>(result2, false)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Partition Equal Subset Sum");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestPartitionEqualSubsetSum());
        }
    }
}