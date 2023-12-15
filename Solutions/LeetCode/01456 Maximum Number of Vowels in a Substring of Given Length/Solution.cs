// Maximum Number of Vowels in a Substring of Given Length

/*
Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.

Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.

 

Example 1:

Input: s = "abciiidef", k = 3
Output: 3
Explanation: The substring "iii" contains 3 vowel letters.

Example 2:

Input: s = "aeiou", k = 2
Output: 2
Explanation: Any substring of length 2 contains 2 vowels.

Example 3:

Input: s = "leetcode", k = 3
Output: 2
Explanation: "lee", "eet" and "ode" contain 2 vowels.

*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNumberofVowelsinaSubstringofGivenLength
{
    public class Solution
    {
        // Sliding Window
        public static int MaxVowels(string s, int k)
        {
            int result = 0;
            int count = 0;

            for(int i = 0; i < k; i++)
            {
                if(Program.isVowel(s[i])) count++;
            }

            result = count;

            for(int j = k; j < s.Length; j++)
            {
                if(Program.isVowel(s[j-k])) count--;
                if(Program.isVowel(s[j])) count++;
                result = Math.Max(result, count);
            }

            return result;
        }

        // isVowel used in Helpers
        public static bool isVowel(char c)
        {
            return (c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u');
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int result1 = Solution.MaxVowels("abciiidef", 3);
            int result2 = Solution.MaxVowels("aeiou", 2);
            int result3 = Solution.MaxVowels("leetcode", 3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 2),
                ResultTester.CheckResult<int>(result3, 2)
            };
            return results;
        }
    }
}