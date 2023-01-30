﻿using System;
using System.Text.RegularExpressions;

namespace CompetitiveProgramming.LeetCode.DetectCapital
{

    //We define the usage of capitals in a word to be right when one of the following cases holds:

    //All letters in this word are capitals, like "USA".
    //All letters in this word are not capitals, like "leetcode".
    //Only the first letter in this word is capital, like "Google".
    //Given a string word, return true if the usage of capitals in it is right.

    //Example 1:

    //Input: word = "USA"
    //Output: true

    //Example 2:

    //Input: word = "FlaG"
    //Output: false

    public class Solution
    {
        // Regular Expressions
        public static bool DetectCapitalUse(string word)
        {
            return word.All(char.IsUpper) || word.Skip(1).All(char.IsLower);
        }

        // Faster For Condition
        public static bool DetectCapitalUseFor(string word)
        {
            int upperCount = 0, lowerCount = 0, n = word.Length;
            for (int i = 0; i < n; i++)
            {
                if (Char.IsUpper(word[i]))
                    upperCount++;
                else
                    lowerCount++;
            }
            return upperCount == n || lowerCount == n || (Char.IsUpper(word[0]) && lowerCount == n - 1);
        }
    }
}

