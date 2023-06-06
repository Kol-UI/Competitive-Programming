// Reverse Words in a String III

/*
Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

 

Example 1:

Input: s = "Let's take LeetCode contest"
Output: "s'teL ekat edoCteeL tsetnoc"

Example 2:

Input: s = "God Ding"
Output: "doG gniD"
*/

using System;
namespace CompetitiveProgramming.LeetCode.ReverseWordsinaStringIII
{
    public class Solution
    {
        // Two Pointers
        public static string ReverseWords(string s)
        {
            string[] words = s.Split(" ");
        
            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToCharArray();
                int l = 0, h = chars.Length - 1;
                while (l < h)
                {
                    (chars[l], chars[h]) = (chars[h], chars[l]);
                    l++;
                    h--;
                }

                words[i] = new string(chars);
            }

            return String.Join(" ", words);
        }
    }
}