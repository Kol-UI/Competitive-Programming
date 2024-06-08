using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.RemoveExclamationMarks
{
	public class Solution
	{
        // Remove all exclamation marks of a string
        public static string RemoveExclamationMarks(string s)
        {
            return string.IsNullOrEmpty(s) ? s : s.Replace("!", "");
        }
    }

    public class Test
    {
        public static bool[] TestRemoveExclamationMarks()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.RemoveExclamationMarks("Test!"), "Test"),
                ResultTester.CheckResult<string>(Solution.RemoveExclamationMarks("! Test!!"), " Test")
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove Exclamation Marks");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestRemoveExclamationMarks());
        }
    }
}