// Largest Odd Number in String



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LargestOddNumberinString
{
    public class Solution
    {
        public static string LargestOddNumber(string num)
        {
            for (int i = num.Length - 1; i >= 0; i--) 
            {
                if (int.Parse(num[i].ToString()) % 2 != 0) 
                {
                    return num.Substring(0, i + 1);
                }
            }
            return "";
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.LargestOddNumber("52"), "5"),
                ResultTester.CheckResult<string>(Solution.LargestOddNumber("35427"), "35427"),
                ResultTester.CheckResult<string>(Solution.LargestOddNumber("4206"), ""),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1903");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}