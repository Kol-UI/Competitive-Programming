// Find the Safest Path in a Grid

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheSafestPathinaGrid
{
    public class Solution
    {
        public int MaximumSafenessFactor(IList<IList<int>> grid)
        {
            int n = grid.Count;
            Queue<(int, int, int)> weightsToSet = new();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1) weightsToSet.Enqueue((i, j, 2 * n));
                }
            }
            while (weightsToSet.TryDequeue(out var t))
            {
                (int i, int j, int weight) = t;
                if (0 <= i && i < n && 0 <= j && j < n && weight > grid[i][j])
                {
                    grid[i][j] = weight--;
                    weightsToSet.Enqueue((i - 1, j, weight));
                    weightsToSet.Enqueue((i + 1, j, weight));
                    weightsToSet.Enqueue((i, j - 1, weight));
                    weightsToSet.Enqueue((i, j + 1, weight));
                }
            }
            PriorityQueue<(int, int), int> bestPaths = new();
            bestPaths.Enqueue((0, 0), 0);
            int maxWeight = Math.Max(grid[0][0], grid[n - 1][n - 1]);
            (int, int)[] directions = new (int, int)[4] { (-1, 0), (1, 0), (0, -1), (0, 1) };
            while (bestPaths.TryDequeue(out var t, out int weight))
            {
                if (weight > maxWeight) maxWeight = weight;
                (int i, int j) = t;
                if (i == n - 1 && j == n - 1) return 2 * n - maxWeight;
                foreach ((int dx, int dy) in directions)
                {
                    int x = i + dx;
                    int y = j + dy;
                    if (0 <= x && x < n && 0 <= y && y < n)
                    {
                        int value = grid[x][y];
                        if (value > 0) {
                            grid[x][y] = 0;
                            int priority;
                            if (value > maxWeight) priority = value;
                            else priority = -(x + y);
                            bestPaths.Enqueue((x, y), priority);
                        }
                    }
                }
            }

            return -1;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Find the Safest Path in a Grid");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}