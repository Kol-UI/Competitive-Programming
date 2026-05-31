// Valid Sudoku

You are given a 9 x 9 Sudoku board board.

A Sudoku board is valid if the following rules are followed:


Each row must contain the digits 1-9 without duplicates.

Each column must contain the digits 1-9 without duplicates.

Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without duplicates.

Return true if the Sudoku board is valid, otherwise return false


Note: A board does not need to be full or be solvable to be valid.


Exemple 1 :

Input: board = 
[["1","2",".",".","3",".",".",".","."],
 ["4",".",".","5",".",".",".",".","."],
 [".","9","8",".",".",".",".",".","3"],
 ["5",".",".",".","6",".",".",".","4"],
 [".",".",".","8",".","3",".",".","5"],
 ["7",".",".",".","2",".",".",".","6"],
 [".",".",".",".",".",".","2",".","."],
 [".",".",".","4","1","9",".",".","8"],
 [".",".",".",".","8",".",".","7","9"]]

Output: true


Example 2:

Input: board = 
[["1","2",".",".","3",".",".",".","."],
 ["4",".",".","5",".",".",".",".","."],
 [".","9","1",".",".",".",".",".","3"],
 ["5",".",".",".","6",".",".",".","4"],
 [".",".",".","8",".","3",".",".","5"],
 ["7",".",".",".","2",".",".",".","6"],
 [".",".",".",".",".",".","2",".","."],
 [".",".",".","4","1","9",".",".","8"],
 [".",".",".",".","8",".",".","7","9"]]

Output: false

Explanation: There are two 1's in the top-left 3x3 sub-box.



```cs
// row & col = 1 to 9 without duplicates
// no duplicates in 3x3 sub box
public class ValidSudokuBruteForce()
{
    public bool IsValidSudoku(char[][] board)
    {
        int sudokuMax = 9;

        // Check row by row if duplicates
        for (int row = 0; row < sudokuMax; row++)
        {
            HashSet<char> seen = new();
            for (int col = 0; col < sudokuMax; col++)
            {
                if (board[row][col] == '.') continue;
                if (seen.Contains(board[row][col])) return false;
                seen.Add(board[row][col]);
            }
        }

        // Check col by col if duplicates
        for (int col = 0; col < sudokuMax; col++)
        {
            HashSet<char> seen = new();
            for (int row = 0; row < sudokuMax; row++)
            {
                if (board[row][col] == '.') continue;
                if (seen.Contains(board[row][col])) return false;
                seen.Add(board[row][col]);
            }
        }

        // Check if duplicates in each 3x3
        /*
            +-------+-------+-------+
            | 0 0 0 | 1 1 1 | 2 2 2 |   <-- rows 0, 1, 2
            | 0 0 0 | 1 1 1 | 2 2 2 |
            | 0 0 0 | 1 1 1 | 2 2 2 |
            +-------+-------+-------+
            | 3 3 3 | 4 4 4 | 5 5 5 |   <-- rows 3, 4, 5
            | 3 3 3 | 4 4 4 | 5 5 3 |
            | 3 3 3 | 4 4 4 | 5 5 5 |
            +-------+-------+-------+
            | 6 6 6 | 7 7 7 | 8 8 8 |   <-- rows 6, 7, 8
            | 6 6 6 | 7 7 7 | 8 8 8 |
            | 6 6 6 | 7 7 7 | 8 8 8 |
            +-------+-------+-------+
        */
        for (int square = 0; square < 9; square++)
        {
            HashSet<char> seen = new HashSet<char>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int row = square / 3 * 3 + i;
                    int col = square % 3 * 3 + j;
                    if (board[row][col] == '.') continue;
                    if (seen.Contains(board[row][col])) return false;
                    seen.Add(board[row][col]);
                }
            }
        }

        return true;
    }
}

public class ValidSudokuSets
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] squares = new HashSet<char>[9]; 

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            squares[i] = new HashSet<char>();
        }

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                char currentVal = board[r][c];

                if (currentVal == '.') continue;

                // Calculate the integer index for the current 3x3 square
                int squareIndex = (r / 3) * 3 + (c / 3);

                // Check for duplicates in the current row, column, and 3x3 square
                if (rows[r].Contains(currentVal) ||
                    cols[c].Contains(currentVal) ||
                    squares[squareIndex].Contains(currentVal))
                {
                    return false;
                }

                // Add the current number to the respective HashSets for tracking
                rows[r].Add(currentVal);
                cols[c].Add(currentVal);
                squares[squareIndex].Add(currentVal);
            }
        }
        
        return true;
    }
}
```