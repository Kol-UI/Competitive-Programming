namespace CompetitiveProgramming.Algorithms;

public class SearchMatrix
{
    public static bool SearchElementInMatrixBruteForce(int[][] matrix, int target)
    {
        foreach (var row in matrix)
        {
            foreach (var element in row)
            {
                if (element == target)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public static int[] SearchElementInMatrixWithCoordinates(int[][] matrix, int target)
    {
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                if (matrix[row][col] == target)
                {
                    return new int[] { row, col };
                }
            }
        }
        return new int[] { -1, -1 };
    }


    public static bool SearchInSortedMatrix(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        if (rows == 0) return false;

        int cols = matrix[0].Length;

        int row = 0, col = cols - 1;

        while (row < rows && col >= 0)
        {
            if (matrix[row][col] == target)
                return true;
            else if (matrix[row][col] > target)
                col--;
            else
                row++;
        }

        return false;
    }

    public static int[] SearchInSortedMatrixWithCoordinates(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        if (rows == 0) return new int[] { -1, -1 };

        int cols = matrix[0].Length;

        int row = 0, col = cols - 1;

        while (row < rows && col >= 0)
        {
            if (matrix[row][col] == target)
            {
                return new int[] { row, col };
            }
            else if (matrix[row][col] > target)
            {
                col--;
            }
            else
            {
                row++;
            }
        }

        return new int[] { -1, -1 };
    }
}