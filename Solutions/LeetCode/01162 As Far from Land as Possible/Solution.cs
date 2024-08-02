using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AsFarfromLandasPossible
{
	public class Solution
    {
        // Given an n x n grid containing only values 0 and 1, where 0 represents water and 1 represents land, find a water cell such that its distance to the nearest land cell is maximized, and return the distance. If no land or water exists in the grid, return -1.
        // The distance used in this problem is the Manhattan distance: the distance between two cells (x0, y0) and (x1, y1) is |x0 - x1| + |y0 - y1|.

        // Example 1:
        // Input: grid = [[1,0,1],[0,0,0],[1,0,1]]
        // Output: 2
        // Explanation: The cell (1, 1) is as far as possible from all the land with distance 2.

        // Example 2:
        // Input: grid = [[1,0,0],[0,0,0],[0,0,0]]
        // Output: 4
        // Explanation: The cell (2, 2) is as far as possible from all the land with distance 4.

        public static int MaxDistance(int[][] grid)
        {
            int maxD = 0;
            int rows = grid.Length;
            int cols = grid[0].Length;
            int[][] Dirs = new int[][]{new int[]{0,1}, new int[]{0,-1}, 
                new int[]{-1,0}, new int[]{1,0}};
            int[,] visited = new int[rows,cols];
            Queue<((int,int),int)> q = new();
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    visited[i,j] = grid[i][j];
                    if (grid[i][j] == 1)
                        q.Enqueue(((i,j),0));
                }
            }
            while(q.Count > 0)
            {
                (var pos, var count) = q.Dequeue();
                visited[pos.Item1,pos.Item2] = 1;
                maxD = count;
                foreach(var d in Dirs)
                {
                    var nr = pos.Item1 + d[0];
                    var nc = pos.Item2 + d[1];
                    if(nr >= 0 && nr < rows
                        && nc >=0 && nc < cols && visited[nr,nc] == 0)
                    {
                        visited[nr,nc] = 1;
                        q.Enqueue(((nr, nc), count + 1));
                    }
                }
            }
            if(maxD == 0)
                return -1;
            return maxD;
        }

        public static bool[] TestAsFarfromLandasPossible()
        {
            // Case 1
            int[][] gridCase1_1162 = new int[][]
            {
                new int[] {1, 0, 1},
                new int[] {0, 0, 0},
                new int[] {1, 0, 1}
            };
            int Case1_1162_Result = LeetCode.AsFarfromLandasPossible.Solution.MaxDistance(gridCase1_1162);

            // Case 2
            int[][] gridCase2_1162 = new int[][]
            {
                new int[] {1, 0, 0},
                new int[] {0, 0, 0},
                new int[] {0, 0, 0}
            };
            int Case2_1162_Result = LeetCode.AsFarfromLandasPossible.Solution.MaxDistance(gridCase2_1162);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_1162_Result, 2),
                ResultTester.CheckResult<int>(Case2_1162_Result, 4)
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("As Far from Land as Possible");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Solution.TestAsFarfromLandasPossible());
        }
    }
}