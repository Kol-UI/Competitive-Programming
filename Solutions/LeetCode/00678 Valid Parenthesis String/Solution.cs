// Valid Parenthesis String


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ValidParenthesisString
{
    public class Solution
    {
        public static bool CheckValidString(string s)
        {
            int minOpen = 0;
            int maxOpen = 0;

            char p1 = '(';
            char p2 = ')';
            
            foreach (char c in s)
            {
                if (c == p1)
                {
                    minOpen++;
                    maxOpen++;
                }
                else if (c == p2)
                {
                    minOpen = Math.Max(minOpen - 1, 0);
                    maxOpen--;
                    if (maxOpen < 0) 
                        return false;
                }
                else
                {
                    minOpen = Math.Max(minOpen - 1, 0);
                    maxOpen++;
                }
            }
            
            return minOpen == 0;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.CheckValidString("()"), true),
                ResultTester.CheckResult<bool>(Solution.CheckValidString("(*)"), true),
                ResultTester.CheckResult<bool>(Solution.CheckValidString("(*))"), true),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Valid Parenthesis String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}