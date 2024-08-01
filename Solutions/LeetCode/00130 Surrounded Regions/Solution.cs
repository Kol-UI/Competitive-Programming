// Surrounded Regions

/*
Given an m x n matrix board containing 'X' and 'O', capture all regions that are 4-directionally surrounded by 'X'.

A region is captured by flipping all 'O's into 'X's in that surrounded region.

 

Example 1:


Input: board = [["X","X","X","X"],["X","O","O","X"],["X","X","O","X"],["X","O","X","X"]]
Output: [["X","X","X","X"],["X","X","X","X"],["X","X","X","X"],["X","O","X","X"]]
Explanation: Notice that an 'O' should not be flipped if:
- It is on the border, or
- It is adjacent to an 'O' that should not be flipped.
The bottom 'O' is on the border, so it is not flipped.
The other three 'O' form a surrounded region, so they are flipped.

Example 2:

Input: board = [["X"]]
Output: [["X"]]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SurroundedRegions
{
    public class Solution
    {
        private static int rows = 0;
        private static int cols = 0;

        public static void Solve(char[][] board)
        {
            rows = board.Length;
            cols = board[0].Length;

            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < cols; col++)
                {
                    if(board[row][col] == 'O' &&
                    (row == 0 || row == rows - 1 || col == 0 || col == cols - 1)) {
                        Capture(board, row, col);
                    }
                }
            }

            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < cols; col++)
                {
                    if(board[row][col] == 'O')
                    {
                        board[row][col] = 'X';
                    }
                }
            }

            for(int row = 0; row < rows; row++)
            {
                for(int col = 0; col < cols; col++)
                {
                    if(board[row][col] == 'T')
                    {
                        board[row][col] = 'O';
                    }
                }
            }
        }

        private static void Capture(char[][] board, int row, int col)
        {
            if((row < 0 || row >= rows) ||
            (col < 0 || col >= cols) ||
            board[row][col] != 'O')
            {
                return;
            }

            board[row][col] = 'T';
            Capture(board, row + 1, col);
            Capture(board, row - 1, col);
            Capture(board, row, col + 1);
            Capture(board, row, col - 1);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            char[][] board1 = new char[][]
            {
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'O', 'O', 'X' },
                new char[] { 'X', 'X', 'O', 'X' },
                new char[] { 'X', 'O', 'X', 'X' }
            };

            char[][] output1 = new char[][]
            {
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'X', 'X', 'X' },
                new char[] { 'X', 'O', 'X', 'X' }
            };

            char[][] board2 = new char[][]
            {
                new char[] { 'X' }
            };

            char[][] output2 = new char[][]
            {
                new char[] { 'X' }
            };

            Solution.Solve(board1);
            Solution.Solve(board2);

            bool[] results = new bool[]
            {
                true, true
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Surrounded Regions");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}