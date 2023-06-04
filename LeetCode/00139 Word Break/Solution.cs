// Word Break

/*
Given a string s and a dictionary of strings wordDict, return true if s can be segmented into a space-separated sequence of one or more dictionary words.

Note that the same word in the dictionary may be reused multiple times in the segmentation.

 

Example 1:

Input: s = "leetcode", wordDict = ["leet","code"]
Output: true
Explanation: Return true because "leetcode" can be segmented as "leet code".

Example 2:

Input: s = "applepenapple", wordDict = ["apple","pen"]
Output: true
Explanation: Return true because "applepenapple" can be segmented as "apple pen apple".
Note that you are allowed to reuse a dictionary word.

Example 3:

Input: s = "catsandog", wordDict = ["cats","dog","sand","and","cat"]
Output: false
*/

using System;
namespace CompetitiveProgramming.LeetCode.WordBreak
{
    public class Solution
    {
        static HashSet<string> wordConsideredMap = new HashSet<string>();
        static int[] dp = new int[]{};

        public static bool WordBreak(string s, IList<string> wordDict)
        {
            wordConsideredMap = new(wordDict);
            dp = new int[s.Length];
            Array.Fill(dp, -1);

            return WordBreak(s, 0);
        }

        private static bool WordBreak(string s, int start)
        {
            if(start >= s.Length)
            {
                return true;
            }

            if(dp[start] != -1)
            {
                return dp[start] == 1; 
            }

            int i = start;
            bool matchFound = false;
            
            while(i++ < s.Length)
            {
                var currentSubstring = s.Substring(start, i-start);

                if(wordConsideredMap.Contains(currentSubstring))
                {
                    matchFound = matchFound || WordBreak(s, i);
                }
            }

            dp[start] = matchFound ? 1 : 0;
            return matchFound;
        }
    }
}