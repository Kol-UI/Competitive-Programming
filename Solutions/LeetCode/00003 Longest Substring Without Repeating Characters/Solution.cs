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
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
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

    public class Solution2
    {
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int maxLength = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (IsUnique(s, i, j))
                    {
                        maxLength = Math.Max(maxLength, j - i + 1);
                    }
                }
            }

            return maxLength;
        }

        private bool IsUnique(string s, int start, int end)
        {
            var chars = new HashSet<char>();

            for (int k = start; k <= end; k++)
            {
                if (chars.Contains(s[k]))
                {
                    return false;
                }
                chars.Add(s[k]);
            }
            return true;
        }
    }

    public class Solution3
    {
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int maxLength = 0;
            int i = 0, j = 0;
            var charSet = new HashSet<char>();

            while (i < n && j < n)
            {
                if (!charSet.Contains(s[j]))
                {
                    charSet.Add(s[j]);
                    j++;
                    maxLength = Math.Max(maxLength, j - i);
                }
                else
                {
                    charSet.Remove(s[i]);
                    i++;
                }
            }

            return maxLength;
        }
    }
    
    public class Solution4
    {
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int maxLength = 0;
            int i = 0;
            var map = new Dictionary<char, int>();

            for (int j = 0; j < n; j++)
            {
                char c = s[j];
                if (map.ContainsKey(c))
                {
                    i = Math.Max(i, map[c] + 1);
                }
                map[c] = j;
                maxLength = Math.Max(maxLength, j - i + 1);
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
            Solution2 solution2 = new();
            Solution3 solution3 = new();
            Solution4 solution4 = new();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1),
                ResultTester.CheckResult<int>(result2, output2),
                ResultTester.CheckResult<int>(result3, output3),
                ResultTester.CheckResult<int>(solution2.LengthOfLongestSubstring("abcabcbb"), 3),
                ResultTester.CheckResult<int>(solution2.LengthOfLongestSubstring("bbbbb"), 1),
                ResultTester.CheckResult<int>(solution2.LengthOfLongestSubstring("pwwkew"), 3),
                ResultTester.CheckResult<int>(solution3.LengthOfLongestSubstring("abcabcbb"), 3),
                ResultTester.CheckResult<int>(solution3.LengthOfLongestSubstring("bbbbb"), 1),
                ResultTester.CheckResult<int>(solution3.LengthOfLongestSubstring("pwwkew"), 3),
                ResultTester.CheckResult<int>(solution4.LengthOfLongestSubstring("abcabcbb"), 3),
                ResultTester.CheckResult<int>(solution4.LengthOfLongestSubstring("bbbbb"), 1),
                ResultTester.CheckResult<int>(solution4.LengthOfLongestSubstring("pwwkew"), 3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Substring Without Repeating Characters");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestLongestSubstringWithoutRepeatingCharacters());
        }
    }
}