// Remove Trailing Zeros From a String



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.RemoveTrailingZerosFromaString
{
    public class Solution
    {
        public static string RemoveTrailingZeros(string num)
        {
            return num.TrimEnd('0'); 
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.RemoveTrailingZeros("51230100"), "512301"),
                ResultTester.CheckResult<string>(Solution.RemoveTrailingZeros("123"), "123"),
            };

            for(int i = 0; i < 200; i++)
            {
                string value = RandomGeneraters.GenerateRandomPositiveNumberAsString();
                string testCase = Solution.RemoveTrailingZeros(value);
                _ = results.Append(ResultTester.CheckResult<string>(testCase, testCase));
            }

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2710");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}