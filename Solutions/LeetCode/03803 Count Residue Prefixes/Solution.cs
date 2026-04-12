// Count Residue Prefixes
namespace CompetitiveProgramming.LeetCode.CountResiduePrefixes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int ResiduePrefixes(string s) => Enumerable.
        Range(1, s.Length).
        Select(m => s[..m]).
        Count(m => m.Distinct().Count() == m.Length % 3);
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.ResiduePrefixes("abc"), 2),
            ResultTester.CheckResult<int>(solution.ResiduePrefixes("dd"), 1),
            ResultTester.CheckResult<int>(solution.ResiduePrefixes("bob"), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Residue Prefixes");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}