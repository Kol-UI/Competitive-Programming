// Check if There is a Valid Path in a Grid
namespace CompetitiveProgramming.LeetCode.CheckifThereisaValidPathinaGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public Dictionary<char, (int x, int y)> moves = new Dictionary<char, (int, int)> { { 'd', (1, 0) }, { 'u', (-1, 0) }, { 'r', (0, 1) }, { 'l', (0, -1) } };

    public Dictionary<int, (char st1, char st2)> streets = new Dictionary<int, (char, char)> { { 1, ('l', 'r') }, { 2, ('u', 'd') }, { 3, ('l', 'd') }, { 4, ('r', 'd') }, { 5, ('l', 'u') }, { 6, ('r', 'u') } };
    public Dictionary<char, char> opposite = new Dictionary<char, char> {
        {'u', 'd'}, {'d', 'u'}, {'l', 'r'}, {'r', 'l'}
    };
    public bool HasValidPath(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        if (m == 1 && n == 1)
        {
            return true;
        }
        Queue<(int, int)> queue = new();
        HashSet<(int, int)> visited = new();
        queue.Enqueue((0, 0));
        while (queue.Count > 0)
        {
            (int row, int col) = queue.Dequeue();
            if (visited.Contains((row, col)))
            {
                continue;
            }
            visited.Add((row, col));
            var movePair = streets[grid[row][col]];
            List<(int x, int y, char dir)> options = new() {
                (moves[movePair.st1].x, moves[movePair.st1].y, movePair.st1),
                (moves[movePair.st2].x, moves[movePair.st2].y, movePair.st2)
            };
            foreach (var option in options)
            {

                int newRow = row + option.x;
                int newCol = col + option.y;
                if (newRow >= 0 && newRow < m && newCol >= 0 && newCol < n && !visited.Contains((newRow, newCol)))
                {
                    var newMovePair = streets[grid[newRow][newCol]];

                    if (newMovePair.st1 == opposite[option.dir] || newMovePair.st2 == opposite[option.dir])
                    {
                        queue.Enqueue((newRow, newCol));
                    }
                }
            }
            if (row == m - 1 && col == n - 1)
            {
                return true;
            }
        }
        return false;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.HasValidPath([[2,4,3],[6,5,2]]), true),
            ResultTester.CheckResult<bool>(solution.HasValidPath([[1,2,1],[1,2,1]]), false),
            ResultTester.CheckResult<bool>(solution.HasValidPath([[1,1,2]]), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if There is a Valid Path in a Grid");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}