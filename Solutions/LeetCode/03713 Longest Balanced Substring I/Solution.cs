// Longest Balanced Substring I
namespace CompetitiveProgramming.LeetCode.LongestBalancedSubstringI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LongestBalanced(string s)
    {
        int n = s.Length;
        int maxLen = 0;

        for (int i = 0; i < n; i++)
        {
            int[] freq = new int[26];
            int distinct = 0;
            int maxFreq = 0;

            for (int j = i; j < n; j++)
            {
                int index = s[j] - 'a';

                if (freq[index] == 0)
                    distinct++;

                freq[index]++;
                maxFreq = Math.Max(maxFreq, freq[index]);

                int length = j - i + 1;

                if (length == distinct * maxFreq)
                    maxLen = Math.Max(maxLen, length);
            }
        }

        return maxLen;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.LongestBalanced("abbac"), 4),
            ResultTester.CheckResult<int>(solution.LongestBalanced("zzabccy"), 4),
            ResultTester.CheckResult<int>(solution.LongestBalanced("aba"), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Balanced Substring I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}