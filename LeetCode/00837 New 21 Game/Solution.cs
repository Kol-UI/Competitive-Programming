// New 21 Game

/*
Alice plays the following game, loosely based on the card game "21".

Alice starts with 0 points and draws numbers while she has less than k points. During each draw, she gains an integer number of points randomly from the range [1, maxPts], where maxPts is an integer. Each draw is independent and the outcomes have equal probabilities.

Alice stops drawing numbers when she gets k or more points.

Return the probability that Alice has n or fewer points.

Answers within 10-5 of the actual answer are considered accepted.

 

Example 1:

Input: n = 10, k = 1, maxPts = 10
Output: 1.00000
Explanation: Alice gets a single card, then stops.

Example 2:

Input: n = 6, k = 1, maxPts = 10
Output: 0.60000
Explanation: Alice gets a single card, then stops.
In 6 out of 10 possibilities, she is at or below 6 points.

Example 3:

Input: n = 21, k = 17, maxPts = 10
Output: 0.73278
*/

using System;
namespace CompetitiveProgramming.LeetCode.New21Game
{
    public class Solution
    {
        // DP
        // Sliding Window
        public static double New21Game(int n, int k, int maxPts)
        {
            var windowSum = 1.0;
            var probability = 0.0;
            var dp = new double[n + 1];
            dp[0] = 1.0;

            if (k == 0 || n >= k + maxPts) return 1.0;
            
            for (var i = 1; i <= n; i++)
            {
                dp[i] = windowSum / maxPts;

                if (i < k) windowSum += dp[i];
                else probability += dp[i];

                if (i >= maxPts) windowSum -= dp[i - maxPts];
            }

            return probability;
        }
    }
}
