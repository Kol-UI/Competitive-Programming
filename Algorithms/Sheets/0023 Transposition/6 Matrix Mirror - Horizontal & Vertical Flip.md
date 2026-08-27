Matrix Mirror (Horizontal & Vertical Flip)

```cs
// Matrix Mirror: flip a matrix horizontally (reverse each row)
// or vertically (reverse the row order).

/*

[1, 2, 3],
[4, 5, 6],
[7, 8, 9]

Horizontal :

[3, 2, 1],
[6, 5, 4],
[9, 8, 7]

Vertical :
[7, 8, 9],
[4, 5, 6],
[1, 2, 3]

*/

public class MatrixMirror
{
    // Horizontal flip: mirror each row left-right
    public static int[][] FlipHorizontal(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int[][] result = new int[m][];
        for (int i = 0; i < m; i++)
        {
            result[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                result[i][j] = matrix[i][n - 1 - j];
            }
        }

        return result;
    }

    // Vertical flip: mirror rows top-bottom
    public static int[][] FlipVertical(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int[][] result = new int[m][];
        for (int i = 0; i < m; i++)
        {
            result[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                result[i][j] = matrix[m - 1 - i][j];
            }
        }

        return result;
    }
}```