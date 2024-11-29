// Minimum Time to Visit a Cell In a Grid
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumTimetoVisitaCellInaGrid
{
    public class Solution
    {
        public int MinimumTime(int[][] grid)
        {
            int rows = grid.Length;
            int cols = grid[0].Length;

            if(grid[0][1] > 1 && grid[1][0] > 1)
            {
                return -1;
            }

            var directions = new int[][] 
            {
                new int[] { 0, 1 },
                new int[] { 1, 0 },
                new int[] { 0, -1 },
                new int[] { -1, 0 } 
            };

            var pq = new PriorityQueue<(int time, int row, int col), int>();
            pq.Enqueue((0, 0, 0), 0);

            bool[,] visited = new bool[rows, cols];

            while (pq.Count > 0)
            {
                var (currentTime, row, col) = pq.Dequeue();

                if (row == rows - 1 && col == cols - 1) 
                {
                    return currentTime;
                }

                if (visited[row, col]) 
                {
                    continue;
                }
                visited[row, col] = true;

                foreach (var dir in directions)
                {
                    int newRow = row + dir[0];
                    int newCol = col + dir[1];

                    if (newRow >= 0 && newRow < rows && newCol >= 0 && newCol < cols)
                    {
                        int waitTime = grid[newRow][newCol];
                        int nextTime = currentTime + 1;

                        if (nextTime < waitTime)
                        {
                            nextTime = waitTime + (waitTime - nextTime) % 2;
                        }

                        pq.Enqueue((nextTime, newRow, newCol), nextTime);
                    }
                }
            }

            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            int[][] grid1 = new int[][]
            {
                new int[] { 0, 1, 3, 2 },
                new int[] { 5, 1, 2, 5 },
                new int[] { 4, 3, 8, 6 }
            };

            int[][] grid2 = new int[][]
            {
                new int[] { 0, 2, 4 },
                new int[] { 3, 2, 1 },
                new int[] { 1, 0, 4 }
            };

            int[][] grid3 = new int[][]
            {
                new int[] { 0, 2, 4 },
                new int[] { 0, 5, 5 },
                new int[] { 5, 4, 3 }
            };

            int[][] grid4 = new int[][]
            {
                new int[] { 0, 2, 4 },
                new int[] { 3, 2, 1 },
                new int[] { 1, 0, 4 }
            };

            int[][] grid5 = new int[][]
            {
                new int[] { 0, 5, 1 },
                new int[] { 0, 7, 6 },
                new int[] { 7, 7, 1 }
            };

            int[][] grid6 = new int[][]
            {
                new int[] { 0, 1, 3, 2 },
                new int[] { 5, 1, 2, 5 },
                new int[] { 4, 3, 8, 6 }
            };

            int[][] grid7 = new int[][]
            {
                new int[] { 0, 7, 6, 6 },
                new int[] { 1, 6, 8, 6 },
                new int[] { 1, 5, 8, 3 },
                new int[] { 4, 7, 0, 1 }
            };

            int[][] grid8 = new int[][]
            {
                new int[] { 0, 1, 12 },
                new int[] { 19, 39, 97 },
                new int[] { 75, 88, 33 },
                new int[] { 21, 2, 88 }
            };

            int[][] grid9 = new int[][]
            {
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 25, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MinimumTime(grid1), 7),
                ResultTester.CheckResult<int>(solution.MinimumTime(grid2), -1),
                ResultTester.CheckResult<int>(solution.MinimumTime(grid3), 6),
                ResultTester.CheckResult<int>(solution.MinimumTime(grid4), -1),
                ResultTester.CheckResult<int>(solution.MinimumTime(grid5), 8),
                ResultTester.CheckResult<int>(solution.MinimumTime(grid6), 7),
                ResultTester.CheckResult<int>(solution.MinimumTime(grid7), 10),
                ResultTester.CheckResult<int>(solution.MinimumTime(grid8), 89),
                ResultTester.CheckResult<int>(solution.MinimumTime(grid9), 42),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Time to Visit a Cell In a Grid");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}