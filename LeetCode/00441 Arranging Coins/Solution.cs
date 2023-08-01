// Arranging Coins

/*
You have n coins and you want to build a staircase with these coins. The staircase consists of k rows where the ith row has exactly i coins. The last row of the staircase may be incomplete.

Given the integer n, return the number of complete rows of the staircase you will build.

 

Example 1:

Input: n = 5
Output: 2
Explanation: Because the 3rd row is incomplete, we return 2.

Example 2:

Input: n = 8
Output: 3
Explanation: Because the 4th row is incomplete, we return 3.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ArrangingCoins
{
    public class Solution
    {
        public static int ArrangeCoins(int n)
        {
            int res = 1;
            int left = n;
            while (left >= res)
            {
                left -= res;
                res++;
            }
            return res - 1;
        }
    }

    public class Test
    {
        public static bool[] TestArrangingCoins()
        {
            int case1_441 = 5;
            int case2_441 = 8;
            int result1_441 = Solution.ArrangeCoins(case1_441);
            int result2_441 = Solution.ArrangeCoins(case2_441);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_441, 2),
                ResultTester.CheckResult<int>(result2_441, 3)
            };
            return results;
        }
    }
}