// Reverse String II

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ReverseStringII
{
    public class Solution
    {
        public string ReverseStr(string s, int k)
        {
            char[] result = new char[s.Length];
            int i = 0;

            while (i < s.Length)
            {
                int end = Math.Min(i + 2 * k, s.Length);
                int reverseEnd = Math.Min(i + k, s.Length);

                for (int j = 0; j < reverseEnd - i; j++)
                {
                    result[i + j] = s[reverseEnd - 1 - j];
                }

                for (int j = reverseEnd; j < end; j++)
                {
                    result[j] = s[j];
                }

                i += 2 * k;
            }

            return new string(result);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(solution.ReverseStr("abcdefg", 2), "bacdfeg"),
                ResultTester.CheckResult<string>(solution.ReverseStr("abcd", 2), "bacd"),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse String II");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}