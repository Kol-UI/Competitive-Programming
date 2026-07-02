// Find a Safe Walk Through a Grid
namespace CompetitiveProgramming.LeetCode.FindaSafeWalkThroughaGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool FindSafeWalk(IList<IList<int>> grid, int health)
    {
        int rows = grid.Count, cols = grid[0].Count;
        if (rows == 0 || cols == 0)
            return true;
        health -= grid[0][0];
        if (health <= 0)
            return false;

        int[] dir = new int[] { 0, 1, 0, -1, 0 };
        bool[,,] visited = new bool[rows, cols, health+1];

        visited[0, 0, health] = true;
        Queue<(int, int, int)> que = new();
        que.Enqueue((0, 0, health));
        while (que.Count > 0)
        {
            int qLen = que.Count;
            for (int i = 0; i < qLen; i++)
            {
                (int x, int y, int curH) cur = que.Dequeue();
                int r = cur.x, c = cur.y, restH = cur.curH;
                if (r == rows - 1 && c == cols - 1)
                    return true;

                for (int p = 0; p < 4; p++)
                {
                    int newX = r + dir[p], newY = c + dir[p + 1];
                    if (newX < 0 || newY < 0 || newX >= rows || newY >= cols)
                        continue;

                    int nextH = restH - grid[newX][newY];
                    if (nextH >= 1)
                    {
                        if (newX == rows - 1 && newY == cols - 1)
                            return true;

                        if (!visited[newX, newY, nextH])
                        { 
                            visited[newX, newY, nextH] = true;
                            que.Enqueue((newX, newY, nextH));
                        }
                    }
                }
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
            ResultTester.CheckResult<bool>(solution.FindSafeWalk([[0,1,0,0,0],[0,1,0,1,0],[0,0,0,1,0]], 1), true),
            ResultTester.CheckResult<bool>(solution.FindSafeWalk([[0,1,1,0,0,0],[1,0,1,0,0,0],[0,1,1,1,0,1],[0,0,1,0,1,0]], 3), false),
            ResultTester.CheckResult<bool>(solution.FindSafeWalk([[1,1,1],[1,0,1],[1,1,1]], 5), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find a Safe Walk Through a Grid");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}