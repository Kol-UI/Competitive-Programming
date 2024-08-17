// Maximum Number of Points with Cost

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNumberofPointswithCost
{
    public class Solution
    {
        public long MaxPoints(int[][] points)
        {
            int rows = points.Length;
            int cols = points[0].Length;

            long[] previousRowMaxPoints = new long[cols];

            for (int col = 0; col < cols; col++)
            {
                previousRowMaxPoints[col] = points[0][col];
            }

            for (int row = 0; row < rows - 1; row++)
            {
                long[] leftMax = new long[cols];
                long[] rightMax = new long[cols];

                leftMax[0] = previousRowMaxPoints[0];

                for (int col = 1; col < cols; col++)
                {
                    leftMax[col] = Math.Max(leftMax[col - 1] - 1, previousRowMaxPoints[col]);
                }

                rightMax[cols - 1] = previousRowMaxPoints[cols - 1];

                for (int col = cols - 2; col >= 0; col--)
                {
                    rightMax[col] = Math.Max(rightMax[col + 1] - 1, previousRowMaxPoints[col]);
                }

                long[] currentRowMaxPoints = new long[cols];

                for (int col = 0; col < cols; col++)
                {
                    currentRowMaxPoints[col] = points[row + 1][col] + Math.Max(leftMax[col], rightMax[col]);
                }

                previousRowMaxPoints = currentRowMaxPoints;
            }

            return previousRowMaxPoints.Max();
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Points with Cost");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}