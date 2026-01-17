// Find the Largest Area of Square Inside Two Rectangles
namespace CompetitiveProgramming.LeetCode.FindtheLargestAreaofSquareInsideTwoRectangles;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long LargestSquareArea(int[][] bottomLeft, int[][] topRight)
    {
        int n = bottomLeft.Length;
        int[][] rect = new int[n][];
        for (int i = 0; i < n; i++)
        {
            rect[i] = new int[] { bottomLeft[i][0], bottomLeft[i][1], topRight[i][0], topRight[i][1] };
        }
        Array.Sort(rect, (a, b) => a[0] == b[0] ? a[1].CompareTo(b[1]) : a[0].CompareTo(b[0]));
        long maxSide = 0;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (rect[j][0] >= rect[i][2]) break;
                if (rect[j][1] >= rect[i][3] || rect[j][3] <= rect[i][1]) continue;
                int overlapX = Math.Min(rect[i][2], rect[j][2]) - Math.Max(rect[i][0], rect[j][0]);
                int overlapY = Math.Min(rect[i][3], rect[j][3]) - Math.Max(rect[i][1], rect[j][1]);
                maxSide = Math.Max(maxSide, Math.Min(overlapX, overlapY));
            }
        }
        return maxSide * maxSide;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Largest Area of Square Inside Two Rectangles");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}