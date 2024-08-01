// Longest Valid Parentheses


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestValidParentheses
{
    public class Solution
    {
        public static int LongestValidParentheses(string s)
        {
            var longestParentheses = 0;
            var left = 0;
            var right = 0;

            foreach (var c in s)
            {
                if (c == '(')
                    left++;
                else
                    right++;

                if (right > left)
                {
                    left = 0;
                    right = 0;
                    continue;
                }
                else if(right == left)
                    longestParentheses = Math.Max(longestParentheses, left * 2);
            }

            left = 0;
            right = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ')')
                    right++;
                else                
                    left++;

                if (left > right)
                {
                    left = 0;
                    right = 0;
                    continue;
                }
                else if (left == right)
                    longestParentheses = Math.Max(longestParentheses, right * 2);                
            }

            return longestParentheses;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.LongestValidParentheses("(()"), 2),
                ResultTester.CheckResult<int>(Solution.LongestValidParentheses(")()())"), 4),
                ResultTester.CheckResult<int>(Solution.LongestValidParentheses(""), 0),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Valid Parentheses");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}