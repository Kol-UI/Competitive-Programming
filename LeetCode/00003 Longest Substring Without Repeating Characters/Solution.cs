// Longest Substring Without Repeating Characters

/*
Given a string s, find the length of the longest substring without repeating characters.


Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.

Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.

Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
*/

using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            StringBuilder subStr = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (subStr.Length > 0)
                    {
                        if (!subStr.ToString().Contains(s[j]))
                        {
                            subStr.Append(s[j]);
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        subStr.Append(s[j]);
                    }
                }

                if (subStr.Length > maxLength)
                    maxLength = subStr.Length;

                subStr = new StringBuilder();
            }

            return maxLength;
        }
    }

    public class Test
    {
        public static bool[] TestLongestSubstringWithoutRepeatingCharacters()
        {
            string case1_3 = "abcabcbb";
            string case2_3 = "bbbbb";
            string case3_3 = "pwwkew";
            int output1 = 3;
            int output2 = 1;
            int output3 = 3;

            int result1 = LeetCode.LongestSubstringWithoutRepeatingCharacters.Solution.LengthOfLongestSubstring(case1_3);
            int result2 = LeetCode.LongestSubstringWithoutRepeatingCharacters.Solution.LengthOfLongestSubstring(case2_3);
            int result3 = LeetCode.LongestSubstringWithoutRepeatingCharacters.Solution.LengthOfLongestSubstring(case3_3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1),
                ResultTester.CheckResult<int>(result2, output2),
                ResultTester.CheckResult<int>(result3, output3)
            };
            return results;
        }
    }
}