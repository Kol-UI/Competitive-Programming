// Minimum Remove to Make Valid Parentheses

/*
Given a string s of '(' , ')' and lowercase English characters.

Your task is to remove the minimum number of parentheses ( '(' or ')', in any positions ) so that the resulting parentheses string is valid and return any valid string.

Formally, a parentheses string is valid if and only if:

It is the empty string, contains only lowercase characters, or
It can be written as AB (A concatenated with B), where A and B are valid strings, or
It can be written as (A), where A is a valid string.
 

Example 1:

Input: s = "lee(t(c)o)de)"
Output: "lee(t(c)o)de"
Explanation: "lee(t(co)de)" , "lee(t(c)ode)" would also be accepted.

Example 2:

Input: s = "a)b(c)d"
Output: "ab(c)d"

Example 3:

Input: s = "))(("
Output: ""
Explanation: An empty string is also valid.
*/




using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumRemovetoMakeValidParentheses
{
    public class Solution
    {
        public static string MinRemoveToMakeValid(string s)
        {
            Stack<int> stkLookup = new Stack<int>();
            SortedSet<int> sSet = new SortedSet<int>();
            int n = s.Length;
            for(int i = 0; i < n; i++)
            {
                if(s[i] != '('  && s[i] != ')')
                    continue;
                
                if(s[i] == '(')
                {
                    stkLookup.Push(i);
                    continue;
                }
                    
                if(stkLookup.Count == 0)
                    sSet.Add(i);
                else
                    stkLookup.Pop();
            }

            while(stkLookup.Count != 0)
                sSet.Add(stkLookup.Pop());

            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < n; i++)
            {
                if(sSet.Contains(i))
                    continue;
                
                builder.Append(s[i]);
            }

            return builder.ToString();
        }
    }


    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.MinRemoveToMakeValid("lee(t(c)o)de)"), "lee(t(c)o)de"),
                ResultTester.CheckResult<string>(Solution.MinRemoveToMakeValid("))(("), ""),
                ResultTester.CheckResult<string>(Solution.MinRemoveToMakeValid("a)b(c)d"), "ab(c)d"),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Remove to Make Valid Parentheses");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}