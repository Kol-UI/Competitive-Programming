using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.RemoveFirstandLastCharacter
{
	public class Solution
	{
        // RemoveFirstandLastCharacter
        public static string Remove_char(string s)
        {
            if (s == null || s.Length == 0)
            {
                return s = " ";
            }
            else
            {
                return s.Substring(1, s.Length - 2);
                // return string starting at position 1 to length -2
                // result => first and last characters are removed
            }
        }
    }

    public class Test
    {
        public static bool[] TestRemoveFirstandLastCharacter()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.Remove_char("test"), "es")
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Remove First and Last Character");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestRemoveFirstandLastCharacter());
        }
    }
}