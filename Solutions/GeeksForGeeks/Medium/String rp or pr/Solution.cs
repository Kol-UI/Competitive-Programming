using System;
using System.Collections;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

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
            for(int i = S.Length-1; i >= 0; i--)
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

    public class Test
    {
        public static bool[] TestStringrporpr()
        {
            // Case 1
            int X_Case1 = 5;
            int Y_Case1 = 4;
	        string S_Case1 = "abppprrr";
            long case1_Result = Stringrporpr.Solution.Solve(X_Case1, Y_Case1, S_Case1);

            // Case 1
            int X_Case2 = 7;
            int Y_Case2 = 7;
	        string S_Case2 = "prpptppr";
            long case2_Result = Stringrporpr.Solution.Solve(X_Case2, Y_Case2, S_Case2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(case1_Result, 15),
                ResultTester.CheckResult<long>(case2_Result, 14)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("String rp or pr");
            ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.MediumGFG, Test.TestStringrporpr());
        }
    }
}