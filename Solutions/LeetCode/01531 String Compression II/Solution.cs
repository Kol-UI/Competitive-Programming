// String Compression II



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.StringCompressionII
{
    public class Solution
    {
        public static int GetLengthOfOptimalCompression(string s, int k)
        {
            var n = s.Length;
            var dp = new int[n + 1][];

            for (var i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[k + 1];
                Array.Fill(dp[i], n);
            }

            dp[0][0] = 0;

            for (var x = 1; x <= n; x++)
            {
                for (var y = 0; y <= k; y++)
                {
                    UpdateDP(dp, s, y, x);
                }
            }

            return dp[n][k];
        }

        private static void UpdateDP(int[][] dp, string s, int y, int x)
        {
            if (y > 0)
            {
                dp[x][y] = Math.Min(dp[x][y], dp[x - 1][y - 1]);
            }

            int same = 0, diff = 0;

            for (var z = x; z >= 1; z--)
            {
                if (s[z - 1] == s[x - 1])
                {
                    same++;
                }
                else
                {
                    diff++;
                }

                if (diff > y)
                {
                    break;
                }

                dp[x][y] = Math.Min(dp[x][y], dp[z - 1][y - diff] + GetLength(same));
            }
        }

        private static int GetLength(int count)
        {
            return count switch
            {
                1 => 1,
                < 10 => 2,
                < 100 => 3,
                _ => 4
            };
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.GetLengthOfOptimalCompression("aaabcccd", 2), 4),
                ResultTester.CheckResult<int>(Solution.GetLengthOfOptimalCompression("aabbaa", 2), 2),
                ResultTester.CheckResult<int>(Solution.GetLengthOfOptimalCompression("aaaaaaaaaaa", 0), 3),
            };
            return results;
        }
    }
}