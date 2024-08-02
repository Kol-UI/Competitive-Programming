// Minimum Number of Steps to Make Two Strings Anagram


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofStepstoMakeTwoStringsAnagram
{
    public class Solution
    {
        public static int MinSteps(string s, string t)
        {
            var arr = new int[26];
            for(int i = 0; i < s.Length; i++)
            {
                arr[t[i] - 'a']++;
                arr[s[i] - 'a']--;
            }       

            return arr.Where(x=> x > 0).Sum();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinSteps("bab", "aba"), 1),
                ResultTester.CheckResult<int>(Solution.MinSteps("leetcode", "practice"), 5),
                ResultTester.CheckResult<int>(Solution.MinSteps("anagram", "mangaar"), 0),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1347");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}