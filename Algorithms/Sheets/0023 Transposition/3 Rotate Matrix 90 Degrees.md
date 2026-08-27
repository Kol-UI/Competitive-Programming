Rotate Matrix 90 Degrees

```cs
// Rotate Matrix 90 Degrees: rotate an m x n matrix clockwise by 90 degrees.
// Two approaches: allocate a new matrix, or rotate in place (square only).

/*

[1, 2, 3],
[4, 5, 6],
[7, 8, 9]

Becomes :

[7, 4, 1],
[8, 5, 2],
[9, 6, 3]

*/

public class RotateMatrix
{
    // New Matrix Approach: works for any m x n matrix
    public static int[][] Rotate(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int[][] result = new int[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[m];
        }

        // element at [i][j] moves to [j][m-1-i]
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[j][m - 1 - i] = matrix[i][j];
            }
        }

        return result;
    }
}

public class RotateMatrixInPlace
{
    // In place Approach: square matrix only, transpose then reverse each row
    public static void Rotate(int[][] matrix)
    {
        int n = matrix.Length;

        // transpose
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        // reverse each row
        for (int i = 0; i < n; i++)
        {
            int left = 0;
            int right = n - 1;
            while (left < right)
            {
                int temp = matrix[i][left];
                matrix[i][left] = matrix[i][right];
                matrix[i][right] = temp;
                left++;
                right--;
            }
        }
    }
}```