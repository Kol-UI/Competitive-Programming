// Maximum Nesting Depth of the Parentheses


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNestingDepthoftheParentheses
{
    public class Solution
    {
        public static int MaxDepth(string s)
        {
            Stack<char> tempo = new Stack<char>();
            int max = 0;

            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == '(')
                tempo.Push('(');
                else if(s[i] == ')')
                {
                    if(max < tempo.Count)
                    max = tempo.Count;
                    tempo.Pop();
                }
            }
            
            return max;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxDepth("(1+(2*3)+((8)/4))+1"), 3),
                ResultTester.CheckResult<int>(Solution.MaxDepth("(1)+((2))+(((3)))"), 3),
            };
            return results;
        }
    }
}