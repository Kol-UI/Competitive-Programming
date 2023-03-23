using System;
using System.Collections;
using System.Text;

namespace CompetitiveProgramming.GeeksForGeeks.Medium.Stringrporpr
{
	public class Solution
	{
        public static long Solve(int X, int Y, String S)
        {    
            String s1 = "pr";
            String s2 = "rp";
            if(X < Y)
            {
                int temp = X; X = Y; Y = temp;
            
                String t = s1; s1 = s2; s2 = t;
            }
            long ans = 0;
            
            Stack<char> st = new Stack<char>();
            for(int i = S.Length-1; i>=0; i--)
            {
                char curr= S[i], first=s1[0], second = s1[1];
                if(st.Count > 0 && curr == first && st.Peek() == second)
                {
                    st.Pop();
                    ans+=X;
                }
                else
                {
                    st.Push(curr);
                }
            }
            
            StringBuilder rem = new StringBuilder();
            while(st.Count > 0)
            rem.Append(st.Pop());
            
            S = rem.ToString();

            for(int i = S.Length-1; i >= 0; i--)
            {
                char curr = S[i], first = s2[0], second = s2[1];
                if(st.Count > 0 && curr == first && st.Peek() == second)
                {
                    st.Pop();
                    ans += Y;
                }
                else
                {
                    st.Push(curr);
                }
            }
            return ans;
        }
    }
}