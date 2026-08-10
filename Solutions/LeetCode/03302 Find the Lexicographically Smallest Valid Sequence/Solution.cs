// Find the Lexicographically Smallest Valid Sequence
namespace CompetitiveProgramming.LeetCode.FindtheLexicographicallySmallestValidSequence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] ValidSequence(string text, string pattern)
    {
        int n = text.Length;
        int m = pattern.Length;
        if (m == 1) return [0];

        int[] suffix = new int[n];
        int count = 0;
                   
        for (int i = n - 1, suffixI = m - 1; i > -1; i--)
        {
            suffix[i] = count;

            if (count < m && pattern[suffixI] == text[i])
            {
                count++;
                suffixI--;
            }
        }

        int[] result = new int[m];

        count = 0;
        bool skipped = false;

        for (int i = 0, resultI = 0; i < n; i++)
        {
            if ((count + 1 + suffix[i] >= m && skipped == false) || pattern[resultI] == text[i])
            {
                if (pattern[resultI] != text[i]) skipped = true;
                count++;
                result[resultI] = i;
                resultI++;
            }

            if (count == m) return result;
        }

        return [];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.ValidSequence("vbcca", "abc"), [0,1,2]),
            ResultTester.CheckResult<int[]>(solution.ValidSequence("bacdc", "abc"), [1,2,4]),
            ResultTester.CheckResult<int[]>(solution.ValidSequence("aaaaaa", "aaabc"), []),
            ResultTester.CheckResult<int[]>(solution.ValidSequence("abc", "ab"), [0,1]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Lexicographically Smallest Valid Sequence");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}