// Combination Sum IV


/*
Given an array of distinct integers nums and a target integer target, return the number of possible combinations that add up to target.

The test cases are generated so that the answer can fit in a 32-bit integer.

 

Example 1:

Input: nums = [1,2,3], target = 4
Output: 7
Explanation:
The possible combination ways are:
(1, 1, 1, 1)
(1, 1, 2)
(1, 2, 1)
(1, 3)
(2, 1, 1)
(2, 2)
(3, 1)
Note that different sequences are counted as different combinations.
Example 2:

Input: nums = [9], target = 3
Output: 0
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CombinationSumIV
{
    public class Solution
    {
        public static int CombinationSum4(int[] nums, int target)
        {
            int[] dp = new int[target + 1];
            Array.Fill(dp,-1);
            
            int solve(int sum)
            {
                if(target == sum) return 1;

                if(sum > target) return 0;
                
                if(dp[sum] != -1) return dp[sum];
                
                int res = 0;
                
                for(int i = 0; i < nums.Length;i++)
                    res+= solve(sum + nums[i]);
                
                return dp[sum] = res;
            }

            return solve(0);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] nums1 = {1,2,3};
            int target1 = 4;
            int[] nums2 = {9};
            int target2 = 3;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CombinationSum4(nums1, target1), 7),
                ResultTester.CheckResult<int>(Solution.CombinationSum4(nums2, target2), 0),
            };
            return results;
        }
    }
}