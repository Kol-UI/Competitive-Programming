// Remove Duplicate Letters

/*
Given a string s, remove duplicate letters so that every letter appears once and only once. You must make sure your result is the smallest in lexicographical order among all possible results.

 

Example 1:

Input: s = "bcabc"
Output: "abc"


Example 2:

Input: s = "cbacdcbc"
Output: "acdb"
 

Constraints:

1 <= s.length <= 104
s consists of lowercase English letters.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RemoveDuplicateLetters
{
    public class Solution
    {
        public static string RemoveDuplicateLetters(string s)
        {
            Dictionary<char, int> lastIndex = new Dictionary<char, int>();
            Dictionary<char, bool> isincluded = new Dictionary<char, bool>();
            for(int i = 0; i < s.Length; i++)
            {
                if(!lastIndex.ContainsKey(s[i]))
                {
                    lastIndex.Add(s[i], i);
                }
                else
                {
                    lastIndex[s[i]] = i;
                }
                if(!isincluded.ContainsKey(s[i]))
                {
                    isincluded.Add(s[i], false);
                }
            }

            Stack<char> stack = new Stack<char>();

            for(int i = 0; i < s.Length; i++)
            {
                while(stack.Count > 0 && stack.Peek() > s[i] && isincluded[s[i]] == false && i < lastIndex[stack.Peek()])
                {
                    isincluded[stack.Peek()] = false;
                    stack.Pop();
                }

                if(isincluded[s[i]] == false)
                {
                    stack.Push(s[i]);
                    isincluded[s[i]] = true;
                }
            }

            string result = "";

            while(stack.Count > 0)
            {
                result += stack.Peek() ;
                stack.Pop();
            }

            char[] stringArray = result.ToCharArray();
            Array.Reverse(stringArray);
            string reverseString = new string(stringArray);
            return reverseString;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.RemoveDuplicateLetters("bcabc"), "abc"),
                ResultTester.CheckResult<string>(Solution.RemoveDuplicateLetters("cbacdcbc"), "acdb"),
            };
            return results;
        }
    }
}