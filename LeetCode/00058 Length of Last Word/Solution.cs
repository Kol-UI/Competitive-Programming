// Length of Last Word

/*
Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal substring consisting of non-space characters only.


Example 1:

Input: s = "Hello World"
Output: 5
Explanation: The last word is "World" with length 5.

Example 2:

Input: s = "   fly me   to   the moon  "
Output: 4
Explanation: The last word is "moon" with length 4.

Example 3:

Input: s = "luffy is still joyboy"
Output: 6
Explanation: The last word is "joyboy" with length 6.
*/

using System;
namespace CompetitiveProgramming.LeetCode.LengthofLastWord
{
    public class Solution
    {
        public static int LengthOfLastWord(string s)
        {
            int len = 0;
            int curlen = 0;
            int startindex = 0;
            int endindex = 0;
            int n = s.Length;

            while(endindex<n)
            {
                if(s[endindex] != ' ')
                {
                    curlen++;
                }
                else
                {
                    curlen = 0;
                    startindex = endindex + 1;
                }

                if(curlen != 0)
                {
                    len = curlen;
                }
                endindex++;
            
            }
        
            return len;
        }
    }
}