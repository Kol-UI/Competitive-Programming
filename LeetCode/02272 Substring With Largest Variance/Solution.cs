// Substring With Largest Variance


/*

The variance of a string is defined as the largest difference between the number of occurrences of any 2 characters present in the string. Note the two characters may or may not be the same.

Given a string s consisting of lowercase English letters only, return the largest variance possible among all substrings of s.

A substring is a contiguous sequence of characters within a string.

 

Example 1:

Input: s = "aababbb"
Output: 3
Explanation:
All possible variances along with their respective substrings are listed below:
- Variance 0 for substrings "a", "aa", "ab", "abab", "aababb", "ba", "b", "bb", and "bbb".
- Variance 1 for substrings "aab", "aba", "abb", "aabab", "ababb", "aababbb", and "bab".
- Variance 2 for substrings "aaba", "ababbb", "abbb", and "babb".
- Variance 3 for substring "babbb".
Since the largest possible variance is 3, we return it.

Example 2:

Input: s = "abcde"
Output: 0
Explanation:
No letter occurs more than once in s, so the variance of every substring is 0.

*/


using System;
namespace CompetitiveProgramming.LeetCode.SubstringWithLargestVariance
{
    public class Solution
    {
        public static int LargestVariance(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 1)
            {
                return 0;
            }

            HashSet<char> distinct = new HashSet<char>();
            foreach (char c in s)
            {
                distinct.Add(c);
            }

            int maxVariance = 0;
            foreach (char max in distinct)
            {
                foreach (char min in distinct)
                {
                    if (max == min)
                    {
                        continue;
                    }

                    maxVariance = Math.Max(maxVariance, getVariance(max, min, s));
                }
            }

            return maxVariance;
        }

        private static int getVariance(char max, char min, string s)
        {
            int maxVariance = 0;
            int variance = 0;
            bool hasMin = false;
            bool startsWithMin = false;

            foreach (char c in s)
            {
                if (c != max && c != min)
                {
                    continue;
                }
                else if (c == max)
                {
                    variance++;
                }
                else if (c == min)
                {
                    hasMin = true;
                    if (startsWithMin && variance >= 0)
                    {
                        startsWithMin = false;
                    }
                    else if (variance - 1 < 0)
                    {
                        startsWithMin = true;
                        variance = -1;
                    }
                    else
                    {
                        variance--;
                    }
                }
                
                if (hasMin)
                {
                    maxVariance = Math.Max(maxVariance, variance);
                }
            }

            return maxVariance;
        }
    }
}