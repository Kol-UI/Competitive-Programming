using System;

namespace CompetitiveProgramming.LeetCode.RansomNote
{
    public class Solution
	{
        //Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

        //Each letter in magazine can only be used once in ransomNote.


        //Example 1:
        //Input: ransomNote = "a", magazine = "b"
        //Output: false
        //Example 2:
        //Input: ransomNote = "aa", magazine = "ab"
        //Output: false
        //Example 3:
        //Input: ransomNote = "aa", magazine = "aab"
        //Output: true

        public static bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length) return false;

            var letterFrequency = new int[26];
            for (int i = 0; i < magazine.Length; i++)
            {
                (letterFrequency[magazine[i] - 'a'])++;
                if (i < ransomNote.Length) (letterFrequency[ransomNote[i] - 'a'])--;
            }

            for (int i = 0; i < 26; i++)
            {
                if (letterFrequency[i] < 0) return false;
            }

            return true;
        }
    }
}

