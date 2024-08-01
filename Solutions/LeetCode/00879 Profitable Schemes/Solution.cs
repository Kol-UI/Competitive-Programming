// Profitable Schemes

/*
here is a group of n members, and a list of various crimes they could commit. The ith crime generates a profit[i] and requires group[i] members to participate in it. If a member participates in one crime, that member can't participate in another crime.

Let's call a profitable scheme any subset of these crimes that generates at least minProfit profit, and the total number of members participating in that subset of crimes is at most n.

Return the number of schemes that can be chosen. Since the answer may be very large, return it modulo 109 + 7.

 

Example 1:

Input: n = 5, minProfit = 3, group = [2,2], profit = [2,3]
Output: 2
Explanation: To make a profit of at least 3, the group could either commit crimes 0 and 1, or just crime 1.
In total, there are 2 schemes.

Example 2:

Input: n = 10, minProfit = 5, group = [2,3,5], profit = [6,7,8]
Output: 7
Explanation: To make a profit of at least 5, the group could commit any crimes, as long as they commit one.
There are 7 possible schemes: (0), (1), (2), (0,1), (0,2), (1,2), and (0,1,2).
 

Constraints:

1 <= n <= 100
0 <= minProfit <= 100
1 <= group.length <= 100
1 <= group[i] <= 100
profit.length == group.length
0 <= profit[i] <= 100
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ProfitableSchemes
{
    public class Solution
    {
        public static int ProfitableSchemes(int n, int minProfit, int[] group, int[] profit)
        {
            const int mod = 1_000_000_007;

            var dp = new int[minProfit + 1, n + 1];
            dp[0, 0] = 1;
            
            for (var k = 0; k < group.Length; k++)
            {
                var g = group[k];
                var p = profit[k];
                
                for (var i = minProfit; i >= 0; i--)
                {
                    for (var j = n - g; j >= 0; j--)
                    {
                        dp[Math.Min(i + p, minProfit), j + g] = (dp[Math.Min(i + p, minProfit), j + g] + dp[i, j]) % mod;
                    }
                }
            }

            var res = 0;

            for (var i = 0; i <= n; i++)
            {
                res += dp[minProfit, i];
                res %= mod;
            }

            return res;
        }
    }

    public class Test
    {
        public static bool[] TestProfitableSchemes()
        {
            // Case 1
            int n1 = 5;
            int minProfit1 = 3;
            int[] group1 = {2,2};
            int[] profit1 = {2,3};

            // Case 2
            int n2 = 10;
            int minProfit2 = 5;
            int[] group2 = {2,3,5};
            int[] profit2 = {6,7,8};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.ProfitableSchemes(n2, minProfit2, group2, profit2), 7),
                ResultTester.CheckResult<int>(Solution.ProfitableSchemes(n1, minProfit1, group1, profit1), 2)
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Profitable Schemes");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestProfitableSchemes());
        }
    }
}