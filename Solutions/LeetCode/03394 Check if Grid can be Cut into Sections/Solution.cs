// Check if Grid can be Cut into Sections
namespace CompetitiveProgramming.LeetCode.CheckifGridcanbeCutintoSections;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public bool CheckValidCuts(int n, int[][] rectangles) {
        return CheckCuts(rectangles, 0) || CheckCuts(rectangles, 1);
    }
    private bool CheckCuts(int[][] rectangles, int dim) {
        Array.Sort(rectangles, (a, b) => a[dim].CompareTo(b[dim]));

        int gapCount = 0;
        int furthestEnd = rectangles[0][dim + 2];

        for (int i = 1; i < rectangles.Length; i++) {
            int[] rect = rectangles[i];

            if (furthestEnd <= rect[dim]) {
                gapCount++;
            }

            furthestEnd = Math.Max(furthestEnd, rect[dim + 2]);
        }

        return gapCount >= 2;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Grid can be Cut into Sections");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}