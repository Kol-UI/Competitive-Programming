using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestEditDistance()
        {
            // Case 1
            string word1 = "horse", word2 = "ros";
            int result1_72 = Solution.MinDistance(word1, word2);

            // Case 2
            string word3 = "intention", word4 = "execution";
            int result2_72 = Solution.MinDistance(word3, word4);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_72, 3),
                ResultTester.CheckResult<int>(result2_72, 5),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Edit Distance");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestEditDistance());
        }
    }
}