// Maximum Total Importance of Roads

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumTotalImportanceofRoads
{
    public class Solution
    {
        public long MaximumImportance(int n, int[][] roads) => roads
        .SelectMany(r => r)
        .GroupBy(c => c)
        .OrderByDescending(g => g.Count())
        .Select((g, i) => (long)g.Count() * (n - i))
        .Sum();
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Total Importance of Roads");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}