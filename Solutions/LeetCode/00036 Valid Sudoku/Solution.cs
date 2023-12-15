using System;
namespace CompetitiveProgramming.LeetCode.ValidSudoku
{
    public class Solution
	{
        //Determine if a 9 x 9 Sudoku board is valid.Only the filled cells need to be validated according to the following rules:

        //Each row must contain the digits 1-9 without repetition.
        //Each column must contain the digits 1-9 without repetition.
        //Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
        //Note:

        //A Sudoku board (partially filled) could be valid but is not necessarily solvable.
        //Only the filled cells need to be validated according to the mentioned rules.

        public static bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] != '.')
                        if (Array.FindAll(board[i], el => el == board[i][j]).Length > 1) return false;
                }
            }

            for (int column = 0; column < board[0].Length; column++)
            {
                char[] arr = new char[board[0].Length];
                for (int row = 0; row < board.Length; row++) arr[row] = board[row][column];

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != '.')
                        if (Array.FindAll(arr, el => el == arr[i]).Length > 1) return false;
                }

            }

            int boxRowStart = 0;
            int boxRowEnd = 3;
            int boxColumnStart = 0;
            int boxColumnEnd = 3;
            while (boxRowStart < 9 && boxColumnStart < 9)
            {
                int count = 0;
                char[] arr = new char[9];
                for (int row = boxRowStart; row < boxRowEnd; row++)
                {
                    for (int column = boxColumnStart; column < boxColumnEnd; column++)
                    {
                        arr[count] = board[row][column];
                        count++;
                    }
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != '.')
                        if (Array.FindAll(arr, el => el == arr[i]).Length > 1) return false;
                }
                if (boxRowEnd == 9)
                {
                    boxColumnStart += 3;
                    boxColumnEnd += 3;
                    boxRowStart = 0;
                    boxRowEnd = 3;
                }
                else if (boxColumnEnd > 9) break;
                else
                {
                    boxRowStart += 3;
                    boxRowEnd += 3;
                }
            }

            return true;
        }
    }
}

