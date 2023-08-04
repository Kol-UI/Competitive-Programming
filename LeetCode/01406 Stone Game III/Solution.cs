// Stone Game III

/*
Alice and Bob continue their games with piles of stones. There are several stones arranged in a row, and each stone has an associated value which is an integer given in the array stoneValue.

Alice and Bob take turns, with Alice starting first. On each player's turn, that player can take 1, 2, or 3 stones from the first remaining stones in the row.

The score of each player is the sum of the values of the stones taken. The score of each player is 0 initially.

The objective of the game is to end with the highest score, and the winner is the player with the highest score and there could be a tie. The game continues until all the stones have been taken.

Assume Alice and Bob play optimally.

Return "Alice" if Alice will win, "Bob" if Bob will win, or "Tie" if they will end the game with the same score.

 

Example 1:

Input: values = [1,2,3,7]
Output: "Bob"
Explanation: Alice will always lose. Her best move will be to take three piles and the score become 6. Now the score of Bob is 7 and Bob wins.

Example 2:

Input: values = [1,2,3,-9]
Output: "Alice"
Explanation: Alice must choose all the three piles at the first move to win and leave Bob with negative score.
If Alice chooses one pile her score will be 1 and the next move Bob's score becomes 5. In the next move, Alice will take the pile with value = -9 and lose.
If Alice chooses two piles her score will be 3 and the next move Bob's score becomes 3. In the next move, Alice will take the pile with value = -9 and also lose.
Remember that both play optimally so here Alice will choose the scenario that makes her win.

Example 3:

Input: values = [1,2,3,6]
Output: "Tie"
Explanation: Alice cannot win this game. She can end the game in a draw if she decided to choose all the first three piles, otherwise she will lose.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.StoneGameIII
{
    public class Solution
    {
        public static string StoneGameIII(int[] stoneValue)
        {
            int n = stoneValue.Length;
            int[] dp = new int[3];

            for (int i = n - 1; i >= 0; i--)
            {
                int take1 = stoneValue[i] - dp[(i + 1) % 3];

                int take2 = int.MinValue;
                if ((i + 1) < n)
                {
                    take2 = stoneValue[i] + stoneValue[i + 1] - dp[(i + 2) % 3];
                }

                int take3 = int.MinValue;
                if ((i + 2) < n)
                {
                    take3 = stoneValue[i] + stoneValue[i + 1] + stoneValue[i + 2] - dp[(i + 3) % 3];
                }

                dp[i % 3] = Math.Max(take1, Math.Max(take2, take3));
            }

            if (dp[0] > 0) return "Alice";
            else if (dp[0] < 0) return "Bob";
            else return "Tie";
        }
    }

    public class Test
    {
        public static bool[] TestStoneGameIII()
        {
            int[] nums1 = {1,2,3,7};
            int[] nums2 = {1,2,3,-9};
            int[] nums3 = {1,2,3,6};

            string result1 = Solution.StoneGameIII(nums1);
            string result2 = Solution.StoneGameIII(nums2);
            string result3 = Solution.StoneGameIII(nums3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(result1, "Bob"),
                ResultTester.CheckResult<string>(result2, "Alice"),
                ResultTester.CheckResult<string>(result3, "Tie")
            };
            return results;
        }
    }
}
