// Decode String

/*
Given an encoded string, return its decoded string.

The encoding rule is: k[encoded_string], where the encoded_string inside the square brackets is being repeated exactly k times. Note that k is guaranteed to be a positive integer.

You may assume that the input string is always valid; there are no extra white spaces, square brackets are well-formed, etc. Furthermore, you may assume that the original data does not contain any digits and that digits are only for those repeat numbers, k. For example, there will not be input like 3a or 2[4].

The test cases are generated so that the length of the output will never exceed 105.

 

Example 1:

Input: s = "3[a]2[bc]"
Output: "aaabcbc"

Example 2:

Input: s = "3[a2[c]]"
Output: "accaccacc"

Example 3:

Input: s = "2[abc]3[cd]ef"
Output: "abcabccdcdcdef"
*/

using System;
using System.Text;

namespace CompetitiveProgramming.LeetCode.DecodeString
{
    public class Solution
    {
        public static string DecodeString(string s)
        {
            bool findHead = false;
            int numIndex = -1;
            int head = int.MaxValue;
            int tail = 0;
            var count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9' && numIndex == -1)
                {
                    numIndex = i;
                }
                else if (s[i] == '[')
                {
                    findHead = true;
                    head = Math.Min(head, i);
                    count++;
                }
                else if (s[i] == ']')
                {
                    count--;
                    tail = i;
                    if (count == 0) break;
                }
            }

            if (findHead)
            {
                StringBuilder result = new StringBuilder();

                if(numIndex>0) result.Append(s.Substring(0, numIndex));

                int time = int.Parse(s.Substring(numIndex, head - numIndex));
                var temp = DecodeString(s.Substring(head + 1, tail - head - 1));

                for (int i = 0; i < time; i++) result.Append(temp);

                if (tail != s.Length - 1) result.Append(DecodeString(s.Substring(tail + 1)));

                return result.ToString();
            }
            else return s;
        }
    }
}