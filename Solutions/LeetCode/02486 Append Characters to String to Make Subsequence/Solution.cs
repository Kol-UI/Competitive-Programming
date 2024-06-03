// Append Characters to String to Make Subsequence


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.AppendCharacterstoStringtoMakeSubsequence
{
    public class Solution
    {
        public static int AppendCharacters(string s, string t) 
        {
            int index = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(index < t.Length && s[i] == t[index])
                {
                    index++;
                }
            }
            return t.Length - index;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.AppendCharacters("coaching", "coding"), 4),
                ResultTester.CheckResult<int>(Solution.AppendCharacters("abcde", "a"), 0),
                ResultTester.CheckResult<int>(Solution.AppendCharacters("z", "abcde"), 5),
            };
            return results;
        }
    }
}