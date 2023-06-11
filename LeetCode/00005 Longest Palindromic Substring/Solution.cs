// Longest Palindromic Substring

/*
Given a string s, return the longest palindromic substring in s.


Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.

Example 2:

Input: s = "cbbd"
Output: "bb"
*/

using System;
using System.Text;

namespace CompetitiveProgramming.LeetCode.LongestPalindromicSubstring
{
    public class Solution
    {
        public static string LongestPalindrome(string s)
        {
            string ans = s[0] + "";
            bool[,] dp = new bool[s.Length,s.Length];

            for(int i = 0; i < s.Length; i++)
            {
                for(int j = 0; j < s.Length; j++)
                {
                    dp[i,j] = true;
                }
            }
            
            for(int i = s.Length - 1; i >= 0; i--)
            {
                StringBuilder temp = new StringBuilder();
                for(int j = i; j < s.Length; j++)
                {
                    temp.Append(s[j]);
                    if(i != j)
                    {
                        if(dp[i + 1, j - 1] && s[i] == s[j])
                        {
                                if(temp.Length > ans.Length)
                                {
                                    ans = temp.ToString();
                                }
                        }
                        else dp[i,j] = false;
                    }
                }
            }

            return ans;
        }
    }
}