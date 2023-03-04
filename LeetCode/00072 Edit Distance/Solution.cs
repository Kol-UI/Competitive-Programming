using System;
namespace CompetitiveProgramming.LeetCode.EditDistance
{
    // Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.
    // You have the following three operations permitted on a word:
    // Insert a character
    // Delete a character
    // Replace a character
    
    // Example 1:

    // Input: word1 = "horse", word2 = "ros"
    // Output: 3
    // Explanation: 
    // horse -> rorse (replace 'h' with 'r')
    // rorse -> rose (remove 'r')
    // rose -> ros (remove 'e')
    // Example 2:

    // Input: word1 = "intention", word2 = "execution"
    // Output: 5
    // Explanation: 
    // intention -> inention (remove 't')
    // inention -> enention (replace 'i' with 'e')
    // enention -> exention (replace 'n' with 'x')
    // exention -> exection (replace 'n' with 'c')
    // exection -> execution (insert 'u')

	public class Solution
	{
        static int Dfs(string word1, string word2, int i, int j, int[][] dp)
        {
            if (i >= word1.Length || j >= word2.Length)
            {
                return Math.Max(word1.Length - i, word2.Length - j);
            }

            if (dp[i][j] != int.MaxValue)
                return dp[i][j];

            if (word1[i] == word2[j])
            {
                dp[i][j] = Dfs(word1, word2, i + 1, j + 1, dp);
                return dp[i][j];
            }

            int result = int.MaxValue;

            result = Math.Min(result, Dfs(word1, word2, i + 1, j, dp) + 1);

            result = Math.Min(result, Dfs(word1, word2, i, j + 1, dp) + 1);

            result = Math.Min(result, Dfs(word1, word2, i + 1, j + 1, dp) + 1);

            dp[i][j] = result;

            return dp[i][j];
        }

        public static int MinDistance(string word1, string word2)
        {
            int[][] dp = new int[word1.Length][];
            for (int i = 0; i < word1.Length; i++)
            {
                dp[i] = new int[word2.Length];
                for (int j = 0; j < word2.Length; j++)
                {
                    dp[i][j] = int.MaxValue;
                }
            }
            
            return Dfs(word1, word2, 0, 0, dp);
        }
    }
}

