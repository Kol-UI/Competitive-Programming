// Extra Characters in a String

/*
You are given a 0-indexed string s and a dictionary of words dictionary. You have to break s into one or more non-overlapping substrings such that each substring is present in dictionary. There may be some extra characters in s which are not present in any of the substrings.

Return the minimum number of extra characters left over if you break up s optimally.

 

Example 1:

Input: s = "leetscode", dictionary = ["leet","code","leetcode"]
Output: 1
Explanation: We can break s in two substrings: "leet" from index 0 to 3 and "code" from index 5 to 8. There is only 1 unused character (at index 4), so we return 1.

Example 2:

Input: s = "sayhelloworld", dictionary = ["hello","world"]
Output: 3
Explanation: We can break s in two substrings: "hello" from index 3 to 7 and "world" from index 8 to 12. The characters at indices 0, 1, 2 are not used in any substring and thus are considered as extra characters. Hence, we return 3.

*/
using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ExtraCharactersinaString
{
    public class Solution
    {
        public static int MinExtraChar(string s, string[] dictionary)
        {
            int n = s.Length;
            var dictionarySet = new HashSet<string>(dictionary);
            var dp = new int[n + 1];

            for (int start = n - 1; start >= 0; start--)
            {
                dp[start] = dp[start + 1] + 1;
                for (int end = start; end < n; end++)
                {
                    var curr = s.Substring(start, end - start + 1);
                    if (dictionarySet.Contains(curr))
                    {
                        dp[start] = Math.Min(dp[start], dp[end + 1]);
                    }
                }
            }

            return dp[0];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string s1 = "leetscode";
            string[] dictionary1 = {"leet","code","leetcode"};
            string s2 = "sayhelloworld";
            string[] dictionary2 = {"hello","world"};
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinExtraChar(s1, dictionary1), 1),
                ResultTester.CheckResult<int>(Solution.MinExtraChar(s2, dictionary2), 3),
            };
            return results;
        }
    }
}
