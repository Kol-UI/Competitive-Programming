// Find Longest Special Substring That Occurs Thrice I

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindLongestSpecialSubstringThatOccursThriceI
{
    public class Solution
    {
        public int MaximumLength(string s)
        {
            int[,] counts = new int[26, s.Length + 1];

            char last = '0';
            int repeatCount = 0;
            foreach (char c in s)
            {
                int index = c - 'a';
                if (c == last)
                {
                    repeatCount++;
                }
                else
                {
                    last = c;
                    repeatCount = 1;
                }
                counts[index, repeatCount]++;
            }

            for (int i = 0; i < 26; i++)
            {
                for (int j = s.Length - 1; j >= 0; j--)
                {
                    counts[i, j] += counts[i, j + 1];
                }
            }

            int result = -1;
            for (int i = 0; i < 26; i++)
            {
                int j = 0;
                while (counts[i, j] >= 3) j++;
                result = Math.Max(result, j - 1);
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MaximumLength("aaaa"), 2),
                ResultTester.CheckResult<int>(solution.MaximumLength("abcdef"), -1),
                ResultTester.CheckResult<int>(solution.MaximumLength("abcaba"), 1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Longest Special Substring That Occurs Thrice I");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}