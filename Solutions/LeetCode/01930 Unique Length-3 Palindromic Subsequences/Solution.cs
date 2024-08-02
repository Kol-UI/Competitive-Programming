// Unique Length-3 Palindromic Subsequences

/*
Given a string s, return the number of unique palindromes of length three that are a subsequence of s.

Note that even if there are multiple ways to obtain the same subsequence, it is still only counted once.

A palindrome is a string that reads the same forwards and backwards.

A subsequence of a string is a new string generated from the original string with some characters (can be none) deleted without changing the relative order of the remaining characters.

For example, "ace" is a subsequence of "abcde".
 

Example 1:

Input: s = "aabca"
Output: 3
Explanation: The 3 palindromic subsequences of length 3 are:
- "aba" (subsequence of "aabca")
- "aaa" (subsequence of "aabca")
- "aca" (subsequence of "aabca")

Example 2:

Input: s = "adc"
Output: 0
Explanation: There are no palindromic subsequences of length 3 in "adc".

Example 3:

Input: s = "bbcbaba"
Output: 4
Explanation: The 4 palindromic subsequences of length 3 are:
- "bbb" (subsequence of "bbcbaba")
- "bcb" (subsequence of "bbcbaba")
- "bab" (subsequence of "bbcbaba")
- "aba" (subsequence of "bbcbaba")
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.UniqueLength3PalindromicSubsequences
{
    public class Solution
    {
        public static int CountPalindromicSubsequence(string s)
        {
            var result = 0;
            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                var index0 = s.IndexOf(ch);
                if (index0 != -1)
                {
                    var index1 = s.LastIndexOf(ch);
                    if (index1 - index0 > 1)
                    {
                        var set = new HashSet<char>();
                        for (int i = index0 + 1; i < index1; i++)
                        {
                            if (!set.Contains(s[i]))
                            {
                                set.Add(s[i]);
                            }
                            if (set.Count == 26) 
                            { 
                                break;
                            }
                        }
                        result += set.Count;
                    }
                }
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountPalindromicSubsequence("aabca"), 3),
                ResultTester.CheckResult<int>(Solution.CountPalindromicSubsequence("abc"), 0),
                ResultTester.CheckResult<int>(Solution.CountPalindromicSubsequence("bbcbaba"), 4),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1930");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}