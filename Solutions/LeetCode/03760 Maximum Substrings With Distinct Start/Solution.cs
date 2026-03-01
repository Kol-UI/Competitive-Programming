// Maximum Substrings With Distinct Start
namespace CompetitiveProgramming.LeetCode.MaximumSubstringsWithDistinctStart;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxDistinct(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        HashSet<char> distinctChars = new HashSet<char>();
        foreach (char c in s)
        {
            distinctChars.Add(c);
        }
        return distinctChars.Count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxDistinct("abab"), 2),
            ResultTester.CheckResult<int>(solution.MaxDistinct("abcd"), 4),
            ResultTester.CheckResult<int>(solution.MaxDistinct("aaaa"), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Substrings With Distinct Start");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}