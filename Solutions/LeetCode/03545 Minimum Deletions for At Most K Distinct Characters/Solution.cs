// Minimum Deletions for At Most K Distinct Characters
namespace CompetitiveProgramming.LeetCode.MinimumDeletionsforAtMostKDistinctCharacters;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public int MinDeletion(string s, int k) => s
        .GroupBy(c => c)
        .Select(c => c.Count())
        .OrderBy(count => -count)
        .Skip(k)
        .Sum();
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Deletions for At Most K Distinct Characters");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}