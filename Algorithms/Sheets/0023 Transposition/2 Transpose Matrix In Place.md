Transpose Matrix In Place

```cs
// Transpose Matrix In Place: transpose a square n x n matrix
// without allocating a new matrix, by swapping elements above
// and below the diagonal.

/*

[1, 2, 3],
[4, 5, 6],
[7, 8, 9]

Becomes :

[1, 4, 7],
[2, 5, 8],
[3, 6, 9]

*/

public class TransposeMatrixInPlace
{
    public static void Transpose(int[][] matrix)
    {
        int n = matrix.Length;

        // only swap upper triangle with lower triangle
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }
}```