// Minimum Cost Path with Alternating Directions II
namespace CompetitiveProgramming.LeetCode.MinimumCostPathwithAlternatingDirectionsII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MinCost(int rows, int columns, int[][] delayMatrix)
    {
        long[] currentRow = new long[columns];

        for (int row = 0; row < rows; row++)
        {
            long leftMinimum = long.MaxValue;
            for (int column = 0; column < columns; column++)
            {
                long currentValue = (row + 1) * (column + 1);
                if (row > 0 || column > 0)
                {
                    long previousMinimum = Math.Min(
                        row > 0 ? currentRow[column] : long.MaxValue,
                        leftMinimum
                    );
                    currentValue += delayMatrix[row][column] + previousMinimum;
                }
                leftMinimum = currentValue;
                currentRow[column] = leftMinimum;
            }
        }

        return currentRow[columns - 1] - delayMatrix[rows - 1][columns - 1];
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Cost Path with Alternating Directions II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}