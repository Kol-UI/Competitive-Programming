// Repeated Substring Pattern

/*
Given a string s, check if it can be constructed by taking a substring of it and appending multiple copies of the substring together.

 

Example 1:

Input: s = "abab"
Output: true
Explanation: It is the substring "ab" twice.

Example 2:

Input: s = "aba"
Output: false

Example 3:

Input: s = "abcabcabcabc"
Output: true
Explanation: It is the substring "abc" four times or the substring "abcabc" twice.
 

Constraints:

1 <= s.length <= 104
s consists of lowercase English letters.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RepeatedSubstringPattern
{
    public class Solution
    {
        /*
            The function iterates over all possible substrings of s that are at most half of its length.
            For each substring sub, it calls a helper function IsDuplicated that checks whether sub can be repeated to construct the entire string s.
            If it finds such a substring, it returns true.
            If no such substring is found, the function returns false.

            The IsDuplicated function checks if sub can be repeated to construct s by replacing all occurrences of sub in s with an empty string,
            and checking if the resulting string is empty.
            If it is empty, it means that s can be constructed by repeating sub, and the function returns true.
            If not, it returns false.
        */
        public static bool RepeatedSubstringPattern(string s)
        {
            for (int i = 1; i <= s.Length / 2; i++)
            {
                if (IsDuplicated(s, s.Substring(0, i))) return true;
            }
            return false;
            bool IsDuplicated(string s, string sub) => s.Replace(sub, "") == "";
        }
    }

    public class Test
    {
        public static bool[] TestRepeatedSubstringPattern()
        {
            // Case 1
            bool Case1_459 = Solution.RepeatedSubstringPattern("abab");

            // Case 2
            bool Case2_459 = Solution.RepeatedSubstringPattern("aba");

            // Case 3
            bool Case3_459 = Solution.RepeatedSubstringPattern("abcabcabcabc");

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Case1_459, true),
                ResultTester.CheckResult<bool>(Case2_459, false),
                ResultTester.CheckResult<bool>(Case3_459, true)
            };
            return results;
        }
    }
}