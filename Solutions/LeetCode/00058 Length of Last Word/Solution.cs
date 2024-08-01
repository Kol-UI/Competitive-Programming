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
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestLengthofLastWord()
        {
            // Case 1
            string s1 = "Hello World";
            int result1 = Solution.LengthOfLastWord(s1);

            // Case 2
            string s2 = "   fly me   to   the moon  ";
            int result2 = Solution.LengthOfLastWord(s2);

            // Case 3
            string s3 = "luffy is still joyboy";
            int result3 = Solution.LengthOfLastWord(s3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 5),
                ResultTester.CheckResult<int>(result2, 4),
                ResultTester.CheckResult<int>(result3, 6)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Length of Last Word");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestLengthofLastWord());
        }
    }
}