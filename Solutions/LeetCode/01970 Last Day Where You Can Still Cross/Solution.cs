// Last Day Where You Can Still Cross

/*
There is a 1-based binary matrix where 0 represents land and 1 represents water. You are given integers row and col representing the number of rows and columns in the matrix, respectively.

Initially on day 0, the entire matrix is land. However, each day a new cell becomes flooded with water. You are given a 1-based 2D array cells, where cells[i] = [ri, ci] represents that on the ith day, the cell on the rith row and cith column (1-based coordinates) will be covered with water (i.e., changed to 1).

You want to find the last day that it is possible to walk from the top to the bottom by only walking on land cells. You can start from any cell in the top row and end at any cell in the bottom row. You can only travel in the four cardinal directions (left, right, up, and down).

Return the last day where it is possible to walk from the top to the bottom by only walking on land cells.

 

Example 1:

Input: row = 2, col = 2, cells = [[1,1],[2,1],[1,2],[2,2]]
Output: 2
Explanation: The above image depicts how the matrix changes each day starting from day 0.
The last day where it is possible to cross from top to bottom is on day 2.

Example 2:

Input: row = 2, col = 2, cells = [[1,1],[1,2],[2,1],[2,2]]
Output: 1
Explanation: The above image depicts how the matrix changes each day starting from day 0.
The last day where it is possible to cross from top to bottom is on day 1.

Example 3:

Input: row = 3, col = 3, cells = [[1,2],[2,1],[3,3],[2,2],[1,1],[1,3],[2,3],[3,2],[3,1]]
Output: 3
Explanation: The above image depicts how the matrix changes each day starting from day 0.
The last day where it is possible to cross from top to bottom is on day 3.
*/

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LastDayWhereYouCanStillCross
{
    public class Solution
    {
        private static int[][] directions = new int[][]
        {
            new int[] { 1, 0 },
            new int[] { -1, 0 },
            new int[] { 0, 1 },
            new int[] { 0, -1 }
        };
        
        public static bool CanCross(int row, int col, int[][] cells, int day)
        {
            int[][] grid = new int[row][];
            for (int i = 0; i < row; i++)
            {
                grid[i] = new int[col];
            }
            
            for (int i = 0; i < day; i++)
            {
                int r = cells[i][0] - 1;
                int c = cells[i][1] - 1;
                grid[r][c] = 1;
            }
            
            for (int i = 0; i < col; i++)
            {
                if (grid[0][i] == 0 && DFS(grid, 0, i, row, col))
                {
                    return true;
                }
            }
            
            return false;
        }

        private static bool DFS(int[][] grid, int r, int c, int row, int col)
        {
            if (r < 0 || r >= row || c < 0 || c >= col || grid[r][c] != 0)
            {
                return false;
            }
            
            if (r == row - 1)
            {
                return true;
            }
            
            grid[r][c] = -1;
            
            foreach (int[] dir in directions)
            {
                int newR = r + dir[0];
                int newC = c + dir[1];
                if (DFS(grid, newR, newC, row, col))
                {
                    return true;
                }
            }
            
            return false;
        }

        public static int LatestDayToCross(int row, int col, int[][] cells)
        {
            int left = 1;
            int right = row * col;
            
            while (left < right)
            {
                int mid = right - (right - left) / 2;
                if (CanCross(row, col, cells, mid))
                {
                    left = mid;
                }
                else
                {
                    right = mid - 1;
                }
            }
            
            return left;
        }
    }

    public class Test
    {
        public static bool[] TestLastDayWhereYouCanStillCroww()
        {
            int row1 = 2;
            int col1 = 2;
            int[][] cells1 = new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 2, 1 },
                new int[] { 2, 1 },
                new int[] { 1, 2 },
                new int[] { 2, 2 }
            };
            int row2 = 2;
            int col2 = 2;
            int[][] cells2 = new int[][]
            {
                new int[] { 1, 1 },
                new int[] { 1, 2 },
                new int[] { 1, 2 },
                new int[] { 2, 2 }
            };
            int row3 = 3;
            int col3 = 3;
            int[][] cells3 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 2 },
                new int[] { 3, 3 },
                new int[] { 2, 2 },
                new int[] { 1, 1 },
                new int[] { 1, 3 },
                new int[] { 2, 3 },
                new int[] { 3, 2 },
                new int[] { 3, 1 }
            };
            int result1 = Solution.LatestDayToCross(row1, col1, cells1);
            int result2 = Solution.LatestDayToCross(row2, col2, cells2);
            int result3 = Solution.LatestDayToCross(row3, col3, cells3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 1),
                ResultTester.CheckResult<int>(result3, 4)
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Last Day Where You Can Still Cross");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestLastDayWhereYouCanStillCroww());
        }
    }
}