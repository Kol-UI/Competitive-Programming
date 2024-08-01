// Maximize Score After N Operations

/*
You are given nums, an array of positive integers of size 2 * n. You must perform n operations on this array.

In the ith operation (1-indexed), you will:

Choose two elements, x and y.
Receive a score of i * gcd(x, y).
Remove x and y from nums.
Return the maximum score you can receive after performing n operations.

The function gcd(x, y) is the greatest common divisor of x and y.


Example 1:

Input: nums = [1,2]
Output: 1
Explanation: The optimal choice of operations is:
(1 * gcd(1, 2)) = 1

Example 2:

Input: nums = [3,4,6,8]
Output: 11
Explanation: The optimal choice of operations is:
(1 * gcd(3, 6)) + (2 * gcd(4, 8)) = 3 + 8 = 11

Example 3:

Input: nums = [1,2,3,4,5,6]
Output: 14
Explanation: The optimal choice of operations is:
(1 * gcd(1, 5)) + (2 * gcd(2, 4)) + (3 * gcd(3, 6)) = 1 + 4 + 9 = 14
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximizeScoreAfterNOperations
{
    public class Solution
    {
        public static int MaxScore(int[] nums)
        {
            int n = nums.Length;
            
            Dictionary<int, int> gcdVal = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int key = (1 << i) + (1 << j);
                    int value = Gcd(nums[i], nums[j]);
                    gcdVal[key] = value;
                }
            }

            // DP array to store the maximum score for each subset of numbers
            int[] dp = new int[1 << n];

            // Loop over all possible subsets of numbers
            for (int i = 0; i < 1 << n; i++)
            {
                int bits = BitCount(i);
                if (bits % 2 != 0)
                {
                    // Skip odd numbers
                    continue;
                }

                // Loop over all possible pairs of numbers and update the DP array
                foreach (KeyValuePair<int, int> pair in gcdVal)
                {
                    int key = pair.Key;
                    int value = pair.Value;
                    if ((key & i) != 0) continue;
                    dp[i ^ key] = Math.Max(dp[i ^ key], dp[i] + value * (bits / 2 + 1));
                }
            }

            return dp[(1 << n) - 1];
        }

        private static int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }

        private static int BitCount(int n)
        {
            // Count the number of set bits in an integer
            int count = 0;
            while (n != 0)
            {
                count++;
                n &= n - 1;
            }
            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] case1_1799 = {1,2};
            int[] case2_1799 = {3,4,6,8};
            int[] case3_1799 = {1,2,3,4,5,6};

            int result1 = Solution.MaxScore(case1_1799);
            int result2 = Solution.MaxScore(case2_1799);
            int result3 = Solution.MaxScore(case3_1799);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 11),
                ResultTester.CheckResult<int>(result3, 14)
            };
            return results;
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximize Score After N Operations");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}