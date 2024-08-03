// Longest Ideal Subsequence

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestIdealSubsequence
{
    public class Solution
    {
        public static int LongestIdealString(string s, int k)
        {
            int max = 0;
            int[] array = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                int tempo = 0;
                int value = current - 'a';
                for (int j = 0; j < 26; j++)
                    if (Math.Abs(current - 'a' - j) <= k)
                        tempo = Math.Max(tempo, array[j]);
                array[value] = tempo + 1;
                max = Math.Max(max, array[value]);
            }

            return max;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.LongestIdealString("acfgbd", 2), 4),
                ResultTester.CheckResult<int>(Solution.LongestIdealString("abcd", 3), 4),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Longest Ideal Subsequence");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}