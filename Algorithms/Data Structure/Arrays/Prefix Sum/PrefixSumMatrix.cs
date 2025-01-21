namespace CompetitiveProgramming.Algorithms;

public class PrefixSumMatrix
{
    /*
        Output :
        1  2  3
        4  5  6
        7  8  9
        Result :
        1  3  6
        4  9  15
        7  15 24
    */
    public int[][] RowWisePrefixSum(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int[][] prefix = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            prefix[i] = new int[cols];
            prefix[i][0] = grid[i][0];

            for (int j = 1; j < cols; j++)
            {
                prefix[i][j] = prefix[i][j - 1] + grid[i][j];
            }
        }
        return prefix;
    }

    /*
        Output :
        1  2  3
        4  5  6
        7  8  9
        Result :
        1  2   3
        5  7   9
        12 15 18
    */
    public int[][] ColumnWisePrefixSum(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int[][] prefix = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            prefix[i] = new int[cols];
        }

        for (int j = 0; j < cols; j++)
        {
            prefix[0][j] = grid[0][j];
        }

        for (int j = 0; j < cols; j++)
        {
            for (int i = 1; i < rows; i++)
            {
                prefix[i][j] = prefix[i - 1][j] + grid[i][j];
            }
        }

        return prefix;
    }

    /*
        Output :
        1  2  3
        4  5  6
        7  8  9
        Result :
        1   3   6
        10  15  21
        28  36  45
    */
    public int[][] ContinuousRowWisePrefixSum(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int[][] prefix = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            prefix[i] = new int[cols];
        }

        prefix[0][0] = grid[0][0];

        for (int j = 1; j < cols; j++)
        {
            prefix[0][j] = prefix[0][j - 1] + grid[0][j];
        }

        for (int i = 1; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (j == 0)
                {
                    prefix[i][j] = prefix[i - 1][cols - 1] + grid[i][j];
                }
                else
                {
                    prefix[i][j] = prefix[i][j - 1] + grid[i][j];
                }
            }
        }

        return prefix;
    }

    /*
        Output:
        1  2  3
        4  5  6
        7  8  9
        Result:
        1   2   3
        5   7   9
        12  15  18
    */
    public int[][] ContinuousColumnWisePrefixSum(int[][] grid)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;
        int[][] prefix = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            prefix[i] = new int[cols];
        }

        for (int j = 0; j < cols; j++)
        {
            prefix[0][j] = grid[0][j];
        }

        for (int i = 1; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                prefix[i][j] = prefix[i - 1][j] + grid[i][j];
            }
        }

        return prefix;
    }

}