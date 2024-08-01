// Number of Ways to Form a Target String Given a Dictionary

/*
You are given a list of strings of the same length words and a string target.

Your task is to form target using the given words under the following rules:

target should be formed from left to right.
To form the ith character (0-indexed) of target, you can choose the kth character of the jth string in words if target[i] = words[j][k].
Once you use the kth character of the jth string of words, you can no longer use the xth character of any string in words where x <= k. In other words, all characters to the left of or at index k become unusuable for every string.
Repeat the process until you form the string target.
Notice that you can use multiple characters from the same string in words provided the conditions above are met.

Return the number of ways to form target from words. Since the answer may be too large, return it modulo 109 + 7.

 

Example 1:

Input: words = ["acca","bbbb","caca"], target = "aba"
Output: 6
Explanation: There are 6 ways to form target.
"aba" -> index 0 ("acca"), index 1 ("bbbb"), index 3 ("caca")
"aba" -> index 0 ("acca"), index 2 ("bbbb"), index 3 ("caca")
"aba" -> index 0 ("acca"), index 1 ("bbbb"), index 3 ("acca")
"aba" -> index 0 ("acca"), index 2 ("bbbb"), index 3 ("acca")
"aba" -> index 1 ("caca"), index 2 ("bbbb"), index 3 ("acca")
"aba" -> index 1 ("caca"), index 2 ("bbbb"), index 3 ("caca")

Example 2:

Input: words = ["abba","baab"], target = "bab"
Output: 4
Explanation: There are 4 ways to form target.
"bab" -> index 0 ("baab"), index 1 ("baab"), index 2 ("abba")
"bab" -> index 0 ("baab"), index 1 ("baab"), index 3 ("baab")
"bab" -> index 0 ("baab"), index 2 ("baab"), index 3 ("baab")
"bab" -> index 1 ("abba"), index 2 ("baab"), index 3 ("baab")
*/

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofWaystoFormaTargetStringGivenaDictionary
{
    public class Solution
    {
        public static int NumWays(string[] words, string target)
        {
            const long mod = 1_000_000_007;
            int m = target.Length;
            int n = words[0].Length;

            if (m > n)
            {
                return 0;
            }

            long[,] count = new long[26, n];

            foreach (string word in words)
            {
                for (int j = 0; j < n; j++)
                {
                    count[word[j] - 'a', j]++;
                }
            }

            long[,] dp = new long[m + 1, n + 1];

            for (int j = 0; j <= n; j++)
            {
                dp[0, j] = 1;
            }

            for (int i = 1; i <= m; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    dp[i, j] = (dp[i, j - 1] + count[target[i - 1] - 'a', j - 1] * dp[i - 1, j - 1]) % mod;
                }
            }

            return (int)dp[m, n];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            string[] words1_1639 = {"acca","bbbb","caca"};
            string target1_1639 = "aba";
            int result1_1639 = Solution.NumWays(words1_1639, target1_1639);

            // Case 2
            string[] words2_1639 = {"abba","baab"};
            string target2_1639 = "bab";
            int result2_1639 = Solution.NumWays(words2_1639, target2_1639);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_1639, 6),
                ResultTester.CheckResult<int>(result2_1639, 4)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Ways to Form a Target Strinng Given a Dictionary");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}