// Remove K Digits


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RemoveKDigits
{
    public class Solution
    {
        public static string RemoveKdigits(string num, int k) {
            if (num.Length == k) return "0";
            
            StringBuilder result = new StringBuilder();
            int digitsToRemove = k;
            
            foreach (char digit in num) {
                while (digitsToRemove > 0 && result.Length > 0 && result[result.Length - 1] > digit) {
                    result.Remove(result.Length - 1, 1);
                    digitsToRemove--;
                }
                result.Append(digit);
            }
            
            while (digitsToRemove > 0) {
                result.Remove(result.Length - 1, 1);
                digitsToRemove--;
            }
            
            while (result.Length > 1 && result[0] == '0') {
                result.Remove(0, 1);
            }
            
            return result.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.RemoveKdigits("1432219", 3), "1219"),
                ResultTester.CheckResult<string>(Solution.RemoveKdigits("10200", 1), "200"),
                ResultTester.CheckResult<string>(Solution.RemoveKdigits("10", 2), "0"),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Remove K Digits");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}