// Basic Calculator II

/*
Given a string s which represents an expression, evaluate this expression and return its value. 

The integer division should truncate toward zero.

You may assume that the given expression is always valid. All intermediate results will be in the range of [-231, 231 - 1].

Note: You are not allowed to use any built-in function which evaluates strings as mathematical expressions, such as eval().

 

Example 1:

Input: s = "3+2*2"
Output: 7

Example 2:

Input: s = " 3/2 "
Output: 1

Example 3:

Input: s = " 3+5 / 2 "
Output: 5
*/

namespace CompetitiveProgramming.LeetCode.BasicCalculatorII
{
    using System.Text.RegularExpressions;
    public class Solution
    {
        public static int Calculate(string s)
        {
            Stack<int> st = new Stack<int>();
            int curNumber = 0;
            int op = 1;
            s = Regex.Replace(s, @"\s", "");

            for(int i = 0; i < s.Length; i++)
            {
                int digit = s[i] - '0';
                if(digit >= 0 && digit <= 9)
                    curNumber = curNumber * 10 + digit;
                else if(s[i] == '*' || s[i] == '/')
                {
                        int j = i + 1;
                        int num2 = 0;
                        while(j < s.Length && s[j] >= '0' && s[j] <= '9' )
                        {
                            num2 = num2 * 10 + (s[j] - '0');
                            j++;
                        }

                        if(s[i] == '*')
                            curNumber*= num2;
                        else curNumber /= num2;
                        
                        i = j - 1;    
                }
                else
                {
                    st.Push(curNumber * op);
                    if(s[i] == '-') op = -1;
                    else op = 1;
                    curNumber = 0;
                }
            }

            curNumber *= op;
            
            while(st.Count > 0)
                curNumber+= st.Pop();
            return curNumber;
        }
    }
}