// Number of Changing Keys

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofChangingKeys
{
    public class Solution
    {
        public static int CountKeyChanges(string s)
        {
            s = s.ToLower();
            var result = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i - 1] != s[i]) result++;
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
                ResultTester.CheckResult<int>(Solution.CountKeyChanges("aAbBcC"), 2),
                ResultTester.CheckResult<int>(Solution.CountKeyChanges("AaAaAaaA"), 0),
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Changing Keys");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}