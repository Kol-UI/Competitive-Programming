// Generate Parentheses

/*
Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

 

Example 1:

Input: n = 3
Output: ["((()))","(()())","(())()","()(())","()()()"]

Example 2:

Input: n = 1
Output: ["()"]
*/

using System;
namespace CompetitiveProgramming.LeetCode.GenerateParentheses
{
    public class Solution
    {
        List<string> result = new List<string>();
        int maxLen;
        
        public IList<string> GenerateParenthesis(int n)
        {
            maxLen = n;
            GenerateAndCheck("", 0, 0);
            return result;
        }
        
        private void GenerateAndCheck(string str, int opened, int closed)
        {
            if(opened == closed && opened == maxLen)
            {
                result.Add(str);
                return;
            }
            
            if(opened < maxLen) GenerateAndCheck(str + "(", opened + 1, closed);
            if(closed < opened) GenerateAndCheck(str + ")", opened, closed + 1);
        }
    }
}
