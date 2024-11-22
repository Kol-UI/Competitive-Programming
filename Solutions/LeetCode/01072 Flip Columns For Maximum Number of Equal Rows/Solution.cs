// Flip Columns For Maximum Number of Equal Rows
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FlipColumnsForMaximumNumberofEqualRows
{
    public class Solution
    {
        public int MaxEqualRowsAfterFlips(int[][] matrix) => matrix
            .GroupBy(r => string.Concat(r.Select(c => c == r[0] ? '1' : '0')))
            .Max(g => g.Count());
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Flip Columns For Maximum Number of Equal Rows");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}