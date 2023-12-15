// Is Subsequence

/*
Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

 

Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true

Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.IsSubsequence
{
    public class Solution
    {
        public static bool IsSubsequence(string s, string t)
        {
            int index =- 1;
            int count = 0;
            for(int i = 0; i < s.Length;i++)
            {
                for(int j = index + 1; j < t.Length; j++)
                {
                    if(t[j] == s[i])
                    {
                        count++;
                        index = j;
                        break;
                    }
                }
            } 
            if(count == s.Length) return true;
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestIsSubsequence()
        {
            string s1 = "abc";
            string t1 = "ahbgdc";
            string s2 = "axc";
            string t2 = "ahbgdc";

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsSubsequence(s1,t1), true),
                ResultTester.CheckResult<bool>(Solution.IsSubsequence(s2,t2), false)
            };
            return results;
        }
    }
}