// Zigzag Grid Traversal With Skip
namespace CompetitiveProgramming.LeetCode.ZigzagGridTraversalWithSkip;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    enum Direction
    {
        LeftToRight,
        RightToLeft
    }
    enum Status
    {
        Take,
        Skip
    }

    public IList<int> ZigzagTraversal(int[][] grid)
    {
        int _rows = grid.Length;
        int _cols = grid[0].Length;

        Direction current = Direction.LeftToRight;
        Status status = Status.Take;

        List<int> result = new List<int>();

        for (int row = 0; row < _rows; row++)
        {
            if (current == Direction.LeftToRight)
            {
                for (int col = 0; col < _cols; col++)
                {
                    if (status == Status.Take)
                    {
                        result.Add(grid[row][col]);
                        status = Status.Skip;
                    }
                    else
                    {
                        status = Status.Take;
                    }
                }
            }
            else
            {
                for (int col = _cols - 1; col >= 0; col--)
                {
                    if (status == Status.Take)
                    {
                        result.Add(grid[row][col]);
                        status = Status.Skip;
                    }
                    else
                    {
                        status = Status.Take;
                    }
                }
            }
            if (current == Direction.LeftToRight)
            {
                current = Direction.RightToLeft;
            }
            else
            {
                current = Direction.LeftToRight;
            }
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<IList<int>>(solution.ZigzagTraversal([[1,2],[3,4]]), [1,4]),
            ResultTester.CheckResult<IList<int>>(solution.ZigzagTraversal([[2,1],[2,1],[2,1]]), [2,1,2]),
            ResultTester.CheckResult<IList<int>>(solution.ZigzagTraversal([[1,2,3],[4,5,6],[7,8,9]]), [1,3,5,7,9]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Zigzag Grid Traversal With Skip");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}