// Fill a Special Grid
namespace CompetitiveProgramming.LeetCode.FillaSpecialGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private void FillMatrix(int[][] matrix, int level, int row, int col, int start)
    {
        if (level == 0)
        {
            matrix[row][col] = start;
        }
        else if (level == 1)
        {
            matrix[row][col] = start;
            matrix[row + 1][col] = start + 1;
            matrix[row + 1][col - 1] = start + 2;
            matrix[row][col - 1] = start + 3;
        }
        else
        {
            int blockSize = 1 << (2 * level - 2);
            int step = 1 << (level - 1);
            FillMatrix(matrix, level - 1, row, col, start);
            FillMatrix(matrix, level - 1, row + step, col, start + blockSize);
            FillMatrix(matrix, level - 1, row + step, col - step, start + 2 * blockSize);
            FillMatrix(matrix, level - 1, row, col - step, start + 3 * blockSize);
        }
    }

    public int[][] SpecialGrid(int n)
    {
        int size = 1 << n;
        int[][] result = new int[size][];
        for (int i = 0; i < size; i++) result[i] = new int[size];
        FillMatrix(result, n, 0, size - 1, 0);
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        int n1 = 0;
        int[][] expected1 = new int[][] { new int[] { 0 } };

        int n2 = 1;
        int[][] expected2 = new int[][]
        {
            new int[] { 3, 0 },
            new int[] { 2, 1 }
        };

        int n3 = 2;
        int[][] expected3 = new int[][]
        {
            new int[] { 15, 12, 3, 0 },
            new int[] { 14, 13, 2, 1 },
            new int[] { 11, 8, 7, 4 },
            new int[] { 10, 9, 6, 5 }
        };

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int[][]>(solution.SpecialGrid(n1), expected1),
            ResultTester.CheckResult<int[][]>(solution.SpecialGrid(n2), expected2),
            ResultTester.CheckResult<int[][]>(solution.SpecialGrid(n3), expected3),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fill a Special Grid");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}