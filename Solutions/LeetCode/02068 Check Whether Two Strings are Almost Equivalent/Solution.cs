// Check Whether Two Strings are Almost Equivalent
namespace CompetitiveProgramming.LeetCode.CheckWhetherTwoStringsareAlmostEquivalent;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckAlmostEquivalent(string word1, string word2)
    {
        var counters = new int [26];

        foreach(var c in word1) counters[c-'a']++;
        foreach(var c in word2) counters[c-'a']--;

        return counters.All(_ => Math.Abs(_) <= 3);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.CheckAlmostEquivalent("aaaa", "bccb"), false),
            ResultTester.CheckResult<bool>(solution.CheckAlmostEquivalent("abcdeef", "abaaacc"), true),
            ResultTester.CheckResult<bool>(solution.CheckAlmostEquivalent("cccddabba", "babababab"), true),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check Whether Two Strings are Almost Equivalent");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}