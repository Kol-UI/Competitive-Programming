// Find Valid Matrix Given Row and Column Sums

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindValidMatrixGivenRowandColumnSums
{
    public class Solution
    {
        public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
        {
            int[][] matrix = new int[rowSum.Length][];
            int n = 0;

            for(int i = 0; i < rowSum.Length; i++)
            {
                matrix[i] = new int[colSum.Length];
            }

            for(int j = 0; j < colSum.Length; j++)
            {
                for(int i = 0; i < rowSum.Length; i++)
                {
                    n = Math.Min(rowSum[i], colSum[j]);
                    matrix[i][j] = n;
                    rowSum[i] -= n;
                    colSum[j] -= n;
                }
            }

            return matrix;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Valid Matrix Given Row and Column Sums");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}