// To Lower Case

/*
Given a string s, return the string after replacing every uppercase letter with the same lowercase letter.


Example 1:

Input: s = "Hello"
Output: "hello"

Example 2:

Input: s = "here"
Output: "here"

Example 3:

Input: s = "LOVELY"
Output: "lovely"
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ToLowerCase
{
    public class Solution
    {
        public static string ToLowerCase(string s)
        {
            return s.ToLower();
        }
    }

    public class Test
    {
        public static bool[] TestToLowerCase()
        {
            string s1 = "Hello";
            string s2 = "here";
            string s3 = "LOVELY";

            s1 = Solution.ToLowerCase(s1);
            s2 = Solution.ToLowerCase(s2);
            s3 = Solution.ToLowerCase(s3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(s1, "hello"),
                ResultTester.CheckResult<string>(s2, "here"),
                ResultTester.CheckResult<string>(s3, "lovely")
            };

            return results;
        }
    }
}