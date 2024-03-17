// Remove Outermost Parentheses


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RemoveOutermostParentheses
{
    public class Solution
    {
        public static string RemoveOuterParentheses(string s)
        {
            StringBuilder result = new StringBuilder();
            Stack<char> stack = new Stack<char>();

            foreach(char bracket in s.ToCharArray())
            {
                if(bracket == '(')
                {
                    if(stack.Count > 0)
                    {
                        result.Append(bracket);
                    }
                    stack.Push(bracket);
                }
                else
                {
                    stack.Pop();
                    if(stack.Count > 0)
                    {
                        result.Append(bracket);
                    }
                }
            }

            return result.ToString();
        }
    }
}