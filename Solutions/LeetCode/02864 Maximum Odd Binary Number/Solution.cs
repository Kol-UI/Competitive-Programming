// Maximum Odd Binary Number



using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumOddBinaryNumber
{
    public class Solution
    {
        public static string MaximumOddBinaryNumber(string s) 
        {
            var odds = s.Count(_ => _ == '1');

            var stringbuilder = new StringBuilder(s.Length);

            stringbuilder.Append('1', odds - 1);
            stringbuilder.Append('0', s.Length - odds);
            stringbuilder.Append('1');

            return stringbuilder.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.MaximumOddBinaryNumber("010"), "001"),
                ResultTester.CheckResult<string>(Solution.MaximumOddBinaryNumber("0101"), "1001"),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2864");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}