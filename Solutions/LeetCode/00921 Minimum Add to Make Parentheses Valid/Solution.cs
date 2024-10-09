// Minimum Add to Make Parentheses Valid

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumAddtoMakeParenthesesValid
{
    public class Solution
    {
        public int MinAddToMakeValid(string s)
        {
            int braces = 0;
            int closingBraces = 0;

            foreach(char ch in s) 
                {
                    if(ch == '(') braces++;
                    else braces--;
                    if(braces < 0)
                    {
                        closingBraces++;
                        braces = 0;
                    }
            }
            return closingBraces + braces;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            var solution = new Solution();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MinAddToMakeValid("())"), 1),
                ResultTester.CheckResult<int>(solution.MinAddToMakeValid("((("), 3)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Add to Make Parentheses Valid");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}