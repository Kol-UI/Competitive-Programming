// Partition String Into Minimum Beautiful Substrings
namespace CompetitiveProgramming.LeetCode.PartitionStringIntoMinimumBeautifulSubstrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumBeautifulSubstrings(string input)
    {
        List<string> valid = new List<string> { "1", "101", "11001", "1111101", "1001110001", "110000110101", "11110100001001" };
        return FindMin(0, input, valid);
    }

    private int FindMin(int start, string text, List<string> patterns)
    {
        int best = int.MaxValue;
        string remaining = text.Substring(start);

        foreach (string pattern in patterns)
        {
            if (remaining.StartsWith(pattern))
            {
                if (remaining == pattern)
                {
                    return 1;
                }
                int next = FindMin(pattern.Length, remaining, patterns);
                if (next != -1)
                {
                    best = Math.Min(best, next + 1);
                }
            }
        }

        return best == int.MaxValue ? -1 : best;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinimumBeautifulSubstrings("1011"), 2),
            ResultTester.CheckResult<int>(solution.MinimumBeautifulSubstrings("111"), 3),
            ResultTester.CheckResult<int>(solution.MinimumBeautifulSubstrings("0"), -1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Partition String Into Minimum Beautiful Substrings");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}