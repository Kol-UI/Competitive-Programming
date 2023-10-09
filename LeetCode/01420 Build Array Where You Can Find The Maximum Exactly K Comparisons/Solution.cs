// Build Array Where You Can Find The Maximum Exactly K Comparisons

/*
You are given three integers n, m and k. Consider the following algorithm to find the maximum element of an array of positive integers:


You should build the array arr which has the following properties:

arr has exactly n integers.
1 <= arr[i] <= m where (0 <= i < n).
After applying the mentioned algorithm to arr, the value search_cost is equal to k.
Return the number of ways to build the array arr under the mentioned conditions. As the answer may grow large, the answer must be computed modulo 109 + 7.

 

Example 1:

Input: n = 2, m = 3, k = 1
Output: 6
Explanation: The possible arrays are [1, 1], [2, 1], [2, 2], [3, 1], [3, 2] [3, 3]

Example 2:

Input: n = 5, m = 2, k = 3
Output: 0
Explanation: There are no possible arrays that satisify the mentioned conditions.

Example 3:

Input: n = 9, m = 1, k = 1
Output: 1
Explanation: The only possible array is [1, 1, 1, 1, 1, 1, 1, 1, 1]

*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BuildArrayWhereYouCanFindTheMaximumExactlyKComparisons
{
    public class Solution
    {
        public static int NumOfArrays(int n, int m, int k)
        {
            var z = 1000000007;
            var dp = new int[n + 1, m + 1, k + 1];

            dp[0, 0, 0] = 1;

            for (var i = 1; i <= n; ++i)
            {
                for (var j = 0; j <= m; ++j)
                {
                    for (var l = 0; l <= k; ++l)
                    {
                        dp[i, j, l] += (int)((long)dp[i - 1, j, l] * j % z);
                        dp[i, j, l] %= z;
                    }
                }

                for (var j = 0; j <= m; ++j)
                {
                    for (var j2 = j - 1; j2 >= 0; --j2)
                    {
                        for (var l = 1; l <= k; ++l)
                        {
                            dp[i, j, l] += dp[i - 1, j2, l - 1];
                            dp[i, j, l] %= z;
                        }
                    }
                }
            }

            var answer = 0;

            for (var j = 0; j <= m; ++j)
            {
                answer += dp[n, j, k];
                answer %= z;
            }

            return answer;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumOfArrays(2, 3, 1), 6),
                ResultTester.CheckResult<int>(Solution.NumOfArrays(5, 2, 3), 0),
                ResultTester.CheckResult<int>(Solution.NumOfArrays(9, 1, 1), 1),
            };
            return results;
        }
    }
}