using System;
using System.Linq;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestCounttheSubstrings()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountSubstring("gEEk"), 3),
                ResultTester.CheckResult<int>(Solution.CountSubstring("WomensDAY"), 4)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count the Substrings");
            ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.EasyGFG, Test.TestCounttheSubstrings());
        }
    }
}