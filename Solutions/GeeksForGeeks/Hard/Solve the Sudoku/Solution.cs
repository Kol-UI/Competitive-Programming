// Solve the Sudoku

// Solution in Java

/*


//User function Template for Java

class Solution
{
    //Function to find a solved Sudoku. 
    static boolean SolveSudoku(int grid[][])
    {
        int[] emptyCell = findEmptyCell(grid);
        if (emptyCell == null)
        {
            return true;
        }

        int row = emptyCell[0];
        int col = emptyCell[1];

        for (int num = 1; num <= 9; num++)
        {
            if (isValidMove(grid, row, col, num))
            {
                grid[row][col] = num;

                if (SolveSudoku(grid))
                {
                    return true;
                }

                grid[row][col] = 0;
            }
        }

        return false; 
    }
    
    static boolean isValidMove(int[][] grid, int row, int col, int num)
    {
        for (int i = 0; i < 9; i++)
        {
            if (grid[row][i] == num || grid[i][col] == num)
            {
                return false;
            }
        }

        int startRow = 3 * (row / 3);
        int startCol = 3 * (col / 3);
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (grid[startRow + i][startCol + j] == num)
                {
                    return false;
                }
            }
        }

        return true;
    }

    static int[] findEmptyCell(int[][] grid)
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (grid[i][j] == 0)
                {
                    return new int[]{i, j};
                }
            }
        }
        return null;
    }

    //Function to print grids of the Sudoku.
    static void printGrid (int grid[][])
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                System.out.print(grid[i][j] + " ");
            }
        }
    }
}
*/