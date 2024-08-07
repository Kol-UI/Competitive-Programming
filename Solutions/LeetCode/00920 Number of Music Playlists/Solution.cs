// Number of Music Playlists

/*
Your music player contains n different songs. You want to listen to goal songs (not necessarily different) during your trip. To avoid boredom, you will create a playlist so that:

Every song is played at least once.
A song can only be played again only if k other songs have been played.
Given n, goal, and k, return the number of possible playlists that you can create. Since the answer can be very large, return it modulo 109 + 7.

 

Example 1:

Input: n = 3, goal = 3, k = 1
Output: 6
Explanation: There are 6 possible playlists: [1, 2, 3], [1, 3, 2], [2, 1, 3], [2, 3, 1], [3, 1, 2], and [3, 2, 1].

Example 2:

Input: n = 2, goal = 3, k = 0
Output: 6
Explanation: There are 6 possible playlists: [1, 1, 2], [1, 2, 1], [2, 1, 1], [2, 2, 1], [2, 1, 2], and [1, 2, 2].

Example 3:

Input: n = 2, goal = 3, k = 1
Output: 2
Explanation: There are 2 possible playlists: [1, 2, 1] and [2, 1, 2].

*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofMusicPlaylists
{
    public class Solution
    {
        public static int NumMusicPlaylists(int n, int goal, int k)
        {
            const int mod = 1_000_000_007;
            var dp = new long[2, n + 1];

            dp[0, 0] = 1;

            for (var i = 1; i <= goal; i++)
            {
                dp[i % 2, 0] = 0;
                for (var j = 1; j <= Math.Min(i, n); j++)
                {
                    dp[i % 2, j] = dp[(i - 1) % 2, j - 1] * (n - (j - 1)) % mod;
                    if (j > k)
                    {
                        dp[i % 2, j] = (dp[i % 2, j] + dp[(i - 1) % 2, j] * (j - k)) % mod;
                    }
                }
            }

            return (int) dp[goal % 2, n];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumMusicPlaylists(3, 3, 1), 6),
                ResultTester.CheckResult<int>(Solution.NumMusicPlaylists(3, 3, 1), 6),
                ResultTester.CheckResult<int>(Solution.NumMusicPlaylists(2, 3, 1), 2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Music Playlists");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}
