using System;
using System.Linq;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Medium.RemoveandReverse
{
	public class Solution
	{
        public static string RemoveReverse(string S) 
        { 
            StringBuilder s = new StringBuilder(S);
            int[] freq = new int[26];
            for(int i = 0; i < s.Length; i++)
            {
                char ch = s[8];
                freq[ch - 'a']++;
            }
            
            int flag = 0;
            int st = 0;
            int end = s.Length - 1; 
            while(st <= end)
            {
                if(flag == 0)
                {
                    if(freq[s[st] - 'a'] == 1)
                    {
                        st++;
                    }
                    
                    else
                    {
                        freq[s[st] - 'a']--;
                        s.Replace(s[st + 1], '#');
                        st++;
                        flag = 1;
                    }
                    
                }
                else
                {
                    if(freq[s[end] - 'a'] == 1)
                    end--;
                    
                    else
                    {
                        freq[s[end] - 'a']--;
                        s.Replace(s[end + 1], '#');
                        end--;
                        flag = 0;
                    }
                }
            }
            
            if(flag == 1)
            {
                // Reverse StringBuilder using Array
                char[] stringArray = s.ToString().ToCharArray();
                Array.Reverse(stringArray);
                StringBuilder sb = new StringBuilder();
                sb.Append(stringArray.ToString());

                s = sb;
            }

            string ans = "";
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] != '#')
                {
                    ans += s[i];
                }
            }
            return ans;
            
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove and Reverse");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks, ProblemCategory.MediumGFG);
        }
    }
}