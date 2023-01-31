﻿using System;
namespace CompetitiveProgramming.LeetCode.LongestPalindrome
{
    public class Solution
    {
        //Given a string s which consists of lowercase or uppercase letters, return the length of the longest palindrome that can be built with those letters.
        //Letters are case sensitive, for example, "Aa" is not considered a palindrome here.

        //Example 1:

        //Input: s = "abccccdd"
        //Output: 7
        //Explanation: One longest palindrome that can be built is "dccaccd", whose length is 7.

        //Example 2:

        //Input: s = "a"
        //Output: 1
        //Explanation: The longest palindrome that can be built is "a", whose length is 1.

        public static int LongestPalindrome(string s)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();
            int length = 0;
            bool foundOdd = false;

            foreach (char c in s)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }
            foreach (int count in charCounts.Values)
            {
                length += count;
                if (count % 2 == 1)
                {
                    foundOdd = true;
                    length--;
                }
            }
            if (foundOdd)
            {
                length++;
            }

            return length;
        }
    }
}

