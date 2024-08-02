// Removing Stars From a String

/*
You are given a string s, which contains stars *.

In one operation, you can:

Choose a star in s.
Remove the closest non-star character to its left, as well as remove the star itself.
Return the string after all stars have been removed.

Note:

The input will be generated such that the operation is always possible.
It can be shown that the resulting string will always be unique.
 

Example 1:

Input: s = "leet**cod*e"
Output: "lecoe"
Explanation: Performing the removals from left to right:
- The closest character to the 1st star is 't' in "leet**cod*e". s becomes "lee*cod*e".
- The closest character to the 2nd star is 'e' in "lee*cod*e". s becomes "lecod*e".
- The closest character to the 3rd star is 'd' in "lecod*e". s becomes "lecoe".
There are no more stars, so we return "lecoe".
Example 2:

Input: s = "erase*****"
Output: ""
Explanation: The entire string is removed, so we return an empty string.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RemovingStarsFromaString
{
    public class Solution
    {
        public static string RemoveStars(string s) 
        {
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
            return string.Concat(stack.Reverse());
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            string output2390_1 = Solution.RemoveStars("leet**cod*e");

            // Case 2
            string output2390_2 = Solution.RemoveStars("erase*****");

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(output2390_1, "lecoe"),
                ResultTester.CheckResult<string>(output2390_2, "")
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Removing Stars From a String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}