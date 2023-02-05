using System;

namespace CompetitiveProgramming.LeetCode.ValidParentheses
{
    // Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    // An input string is valid if:
    // Open brackets must be closed by the same type of brackets.
    // Open brackets must be closed in the correct order.
    // Every close bracket has a corresponding open bracket of the same type.

    // Example 1:

    // Input: s = "()"
    // Output: true

    // Example 2:

    // Input: s = "()[]{}"
    // Output: true

    // Example 3:

    // Input: s = "(]"
    // Output: false
    public class Solution
    {
        public bool IsValid(string s)
            {
            Stack<char> st = new Stack<char>();
            char[] arr = new char[s.Length];
            arr= s.ToCharArray();
            if(s.Length%2 !=0)
                return false;

            for(int i=0; i<arr.Length; i++)
            {
                char ch = arr[i];

                if(ch == '(' || ch == '[' || ch =='{'){
                    st.Push(ch);
                    Console.WriteLine("for "+i+" pushed " + ch);

                }
                if(st.Count<=0){
                    return false;
                }
                
                else if(ch ==')' ){
                    if(st.Peek() == '('){
                        st.Pop();
                    }
                    else
                    return false; 
                    
                }
                else if(ch =='}' ){
                    if(st.Peek() == '{')
                    {
                        st.Pop();
                        
                    }
                    else
                    return false;
                }
                else if(ch ==']'){
                    if(st.Peek() == '[')
                    {
                        st.Pop();
                    }
                    else
                    return false;
                }
            }
            if(st.Count>0)
                return false;
            return true; 
        }
    }
}


