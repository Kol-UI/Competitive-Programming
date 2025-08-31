// Sudoku Solver
namespace CompetitiveProgramming.LeetCode.SudokuSolver;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public void SolveSudoku(char[][] board)
    {
        if (board == null || board.Length == 0 || board[0].Length == 0) return;
        SolveHelper(board);
    }

    private bool SolveHelper(char[][] board)
    {
        int rows = board.Length;
        int cols = board[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i][j] == '.')
                {
                    for (char num = '1'; num <= '9'; num++)
                    {
                        if (IsValid(board, i, j, num))
                        {
                            board[i][j] = num;
                            if (SolveHelper(board)) return true;
                            board[i][j] = '.';
                        }
                    }
                    return false;
                }
            }
        }

        return true;
    }

    private bool IsValid(char[][] board, int row, int col, char num)
    {
        for (int k = 0; k < 9; k++)
        {
            if (board[row][k] == num) return false;
            if (board[k][col] == num) return false;
            int subRow = 3 * (row / 3) + k / 3;
            int subCol = 3 * (col / 3) + k % 3;
            if (board[subRow][subCol] == num) return false;
        }
        return true;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sudoku Solver");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}