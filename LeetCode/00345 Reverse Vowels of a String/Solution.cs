// Reverse Vowels of a String

/*
Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.


Example 1:

Input: s = "hello"
Output: "holle"

Example 2:

Input: s = "leetcode"
Output: "leotcede"
*/

using System;
namespace CompetitiveProgramming.LeetCode.ReverseVowelsofaString
{
    public class Solution
    {
        public static string ReverseVowels(string s)
        {
            var vowels = "aeiouAEIOU";
            var extract = s.Where(c => vowels.Contains(c)).Reverse().ToArray();
            var res = s.ToCharArray();
            int v = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    res[i] = extract[v++];
                }
            }

            return new string(res);
        }
    }
}