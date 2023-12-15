// Decoded String at Index

/*
You are given an encoded string s. To decode the string to a tape, the encoded string is read one character at a time and the following steps are taken:

If the character read is a letter, that letter is written onto the tape.
If the character read is a digit d, the entire current tape is repeatedly written d - 1 more times in total.
Given an integer k, return the kth letter (1-indexed) in the decoded string.

 

Example 1:

Input: s = "leet2code3", k = 10
Output: "o"
Explanation: The decoded string is "leetleetcodeleetleetcodeleetleetcode".
The 10th letter in the string is "o".


Example 2:

Input: s = "ha22", k = 5
Output: "h"
Explanation: The decoded string is "hahahaha".
The 5th letter is "h".


Example 3:

Input: s = "a2345678999999999999999", k = 1
Output: "a"
Explanation: The decoded string is "a" repeated 8301530446056247680 times.
The 1st letter is "a".
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DecodedStringatIndex
{
    public class Solution
    {
        public static string DecodeAtIndex(string s, int k)
        {
            long N = 0;
            int i;
            
            for (i = 0; N < k; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    N *= s[i] - '0';
                }
                else
                {
                    N++;
                }
            }
            
            while (i-- > 0)
            {
                if (Char.IsDigit(s[i]))
                {
                    N /= s[i] - '0';
                    k %= (int)N;
                }
                else if (k % (int)N-- == 0)
                {
                    return s[i].ToString();
                }
            }
            
            return string.Empty;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.DecodeAtIndex("leet2code3", 10), "o"),
                ResultTester.CheckResult<string>(Solution.DecodeAtIndex("ha22", 5), "h"),
                ResultTester.CheckResult<string>(Solution.DecodeAtIndex("a2345678999999999999999", 1), "a"),
            };
            return results;
        }
    }
}