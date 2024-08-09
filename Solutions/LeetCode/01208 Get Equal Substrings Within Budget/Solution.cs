// Get Equal Substrings Within Budget

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.GetEqualSubstringsWithinBudget
{
    public class Solution
    {
        public static int EqualSubstring(string s, string t, int maxCost)
        {
            int result = 0;
            var window = new int[s.Length];

            for(int j = 0; j < s.Length; j++)
            {
                window[j] = Math.Abs((s[j]-'a') - (t[j]-'a'));
            }

            int i = 0;

            for(int j = 0;j < s.Length; j++)
            {
                maxCost -= window[j];
                if(maxCost >= 0)
                {
                    result = Math.Max(result, j - i + 1);
                }
                else
                {
                    while(i <= j && maxCost < 0)
                    {
                        maxCost += window[i];
                        i++;
                    }
                }            
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.EqualSubstring("abcd", "bcdf", 3), 3),
                ResultTester.CheckResult<int>(Solution.EqualSubstring("abcd", "cdef", 3), 1),
                ResultTester.CheckResult<int>(Solution.EqualSubstring("abcd", "acde", 0), 1),
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Get Equal Substrings With Budget");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}