// Where Will the Ball Fall

/*
You have a 2-D grid of size m x n representing a box, and you have n balls. The box is open on the top and bottom sides.

Each cell in the box has a diagonal board spanning two corners of the cell that can redirect a ball to the right or to the left.

A board that redirects the ball to the right spans the top-left corner to the bottom-right corner and is represented in the grid as 1.
A board that redirects the ball to the left spans the top-right corner to the bottom-left corner and is represented in the grid as -1.
We drop one ball at the top of each column of the box. Each ball can get stuck in the box or fall out of the bottom. A ball gets stuck if it hits a "V" shaped pattern between two boards or if a board redirects the ball into either wall of the box.

Return an array answer of size n where answer[i] is the column that the ball falls out of at the bottom after dropping the ball from the ith column at the top, or -1 if the ball gets stuck in the box.

 

Example 1:



Input: grid = [[1,1,1,-1,-1],[1,1,1,-1,-1],[-1,-1,-1,1,1],[1,1,1,1,-1],[-1,-1,-1,-1,-1]]
Output: [1,-1,-1,-1,-1]
Explanation: This example is shown in the photo.
Ball b0 is dropped at column 0 and falls out of the box at column 1.
Ball b1 is dropped at column 1 and will get stuck in the box between column 2 and 3 and row 1.
Ball b2 is dropped at column 2 and will get stuck on the box between column 2 and 3 and row 0.
Ball b3 is dropped at column 3 and will get stuck on the box between column 2 and 3 and row 0.
Ball b4 is dropped at column 4 and will get stuck on the box between column 2 and 3 and row 1.


Example 2:

Input: grid = [[-1]]
Output: [-1]
Explanation: The ball gets stuck against the left wall.


Example 3:

Input: grid = [[1,1,1,1,1,1],[-1,-1,-1,-1,-1,-1],[1,1,1,1,1,1],[-1,-1,-1,-1,-1,-1]]
Output: [0,1,2,3,4,-1]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.WhereWilltheBallFall
{
    public class Solution
    {
        internal enum Direction
        {
            Left,
            Right = 1
        }

        public static int[] FindBall(int[][] grid)
        {
            if(grid[0].Length == 1)
            {
                return new int[] { -1 };
            } 

            int[] res = new int[grid[0].Length];
            for(int i = 0; i < res.Length; ++i)
            {
                res[i] = CalculateEndingPosition(0, i, grid);
            }

            return res;
        }

        private static int CalculateEndingPosition(int currentRow, int startPos, int[][] grid)
        {
            int currentPos = startPos;
            if(currentRow == grid.Length)
            {
                return currentPos;
            }
            
            if(grid[currentRow][startPos] == (int)Direction.Right)
            {
                if(!CanMoveRight(startPos, currentRow, grid))
                {
                    return -1;
                }
                currentPos++;
            }
            else
            {
                if(!CanMoveLeft(startPos, currentRow, grid))
                {
                    return -1;
                }
                currentPos--;
            }

            return CalculateEndingPosition(currentRow + 1, currentPos, grid);
        }

        private static bool CanMoveRight(int currentColumn, int currentRow, int[][] grid)
        {
            return currentColumn < grid[0].Length - 1
                && grid[currentRow][currentColumn + 1] != -1;
        }

        private static bool CanMoveLeft(int currentColumn, int currentRow, int[][] grid)
        {
            return currentColumn > 0 
                && grid[currentRow][currentColumn - 1] != 1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] grid1 = new int[][]
            {
                new int[] { 1, 1, 1, -1, -1 },
                new int[] { 1, 1, 1, -1, -1 },
                new int[] { -1, -1, -1, 1, 1 },
                new int[] { 1, 1, 1, 1, -1 },
                new int[] { -1, -1, -1, -1, -1 }
            };

            int[][] grid2 = new int[][]
            {
                new int[] { -1 }
            };

            int[][] grid3 = new int[][]
            {
                new int[] { 1, 1, 1, 1, 1, 1 },
                new int[] { -1, -1, -1, -1, -1, -1 },
                new int[] { 1, 1, 1, 1, 1, 1 },
                new int[] { -1, -1, -1, -1, -1, -1 }
            };

            int[] result1 = {1,-1,-1,-1,-1};
            int[] result2 = {-1};
            int[] result3 = {0,1,2,3,4,-1};


            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.FindBall(grid1), result1),
                ResultTester.CheckResult<int[]>(Solution.FindBall(grid2), result2),
                ResultTester.CheckResult<int[]>(Solution.FindBall(grid3), result3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Where Will the Ball Fall");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}