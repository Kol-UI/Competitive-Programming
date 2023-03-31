using System;
using System.Linq;
using System.Text;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.CounttheSubstrings
{
	public class Solution
	{
        public static int CountSubstring(String S) 
        { 
            int countofSubstrings = 0;
            int result = 0;
            for(int i = 0; i < S.Length; i++)
            {
                countofSubstrings = 0;
                for(int j = i ; j < S.Length; j++)
                {
                    if(S[j] >= 'a' && S[j] <= 'z')
                    countofSubstrings++;
                    
                    else countofSubstrings--;
                    
                    if(countofSubstrings == 0)
                    result++;
                }
            }
            return result;
        }
    }
}