namespace CompetitiveProgramming.Algorithms;

public class FlattenedMatrix
{
    public static bool SearchInFlattenedMatrix(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        if (rows == 0) return false;

        int cols = matrix[0].Length;
        int left = 0, right = rows * cols - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midValue = matrix[mid / cols][mid % cols];

            if (midValue == target)
                return true;
            else if (midValue < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return false;
    }

    public static int[] SearchInFlattenedMatrixWithCoordinates(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        if (rows == 0) return new int[] { -1, -1 };

        int cols = matrix[0].Length;
        int left = 0, right = rows * cols - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midValue = matrix[mid / cols][mid % cols];

            if (midValue == target)
            {
                return new int[] { mid / cols, mid % cols };
            }
            else if (midValue < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return new int[] { -1, -1 };
    }


    public static int[] FlattenMatrix(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int[] flattened = new int[rows * cols];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                flattened[index++] = matrix[i][j];
            }
        }

        return flattened;
    }

    public static int[][] UnflattenMatrix(int[] flattened, int rows, int cols)
    {
        int[][] matrix = new int[rows][];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            matrix[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                matrix[i][j] = flattened[index++];
            }
        }

        return matrix;
    }
}