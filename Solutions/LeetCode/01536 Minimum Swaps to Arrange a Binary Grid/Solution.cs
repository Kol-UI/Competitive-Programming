// Minimum Swaps to Arrange a Binary Grid
namespace CompetitiveProgramming.LeetCode.MinimumSwapstoArrangeaBinaryGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinSwaps(int[][] grid)
    {
        int n = grid.Length;
        int[] pos = new int[n];
        Array.Fill(pos, -1);

        for (int i = 0; i < n; ++i)
        {
            for (int j = n - 1; j >= 0; --j)
            {
                if (grid[i][j] == 1)
                {
                    pos[i] = j;
                    break;
                }
            }
        }

        int result = 0;
        for (int i = 0; i < n; ++i)
        {
            int k = -1;
            for (int j = i; j < n; ++j)
            {
                if (pos[j] <= i)
                {
                    result += j - i;
                    k = j;
                    break;
                }
            }

            if (k != -1)
            {
                for (int j = k; j > i; --j)
                {
                    (pos[j], pos[j - 1]) = (pos[j - 1], pos[j]);
                }
            }
            else
            {
                return -1;
            }
        }
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Swaps to Arrange a Binary Grid");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}