// Backspace String Compare

/*
Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.

Note that after backspacing an empty text, the text will continue empty.

 

Example 1:

Input: s = "ab#c", t = "ad#c"
Output: true
Explanation: Both s and t become "ac".

Example 2:

Input: s = "ab##", t = "c#d#"
Output: true
Explanation: Both s and t become "".

Example 3:

Input: s = "a#c", t = "b"
Output: false
Explanation: s becomes "c" while t becomes "b".
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BackspaceStringCompare
{
    public class Solution
    {
        public static bool BackspaceCompare(string s, string t)
        {
            var sSt = new Stack<char>();
            var tSt = new Stack<char>();

            foreach(char c in s)
            {
                if (c != '#')
                {
                    sSt.Push(c);
                    continue;
                }

                if (!sSt.Any())
                    continue;
                
                sSt.Pop();
            }

            foreach(char c in t)
            {
                if (c != '#')
                {
                    tSt.Push(c);
                    continue;
                }

                if (!tSt.Any())
                    continue;
                
                tSt.Pop();
            }

            return sSt.ToArray().SequenceEqual(tSt.ToArray());
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            string s1 = "ab#c";
            string t1 = "ad#c";
            string s2 = "ab##";
            string t2 = "c#d#";
            string s3 = "a#c";
            string t3 = "b";
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.BackspaceCompare(s1, t1), true),
                ResultTester.CheckResult<bool>(Solution.BackspaceCompare(s2, t2), true),
                ResultTester.CheckResult<bool>(Solution.BackspaceCompare(s3, t3), false),
            };
            return results;
        }
    }
}