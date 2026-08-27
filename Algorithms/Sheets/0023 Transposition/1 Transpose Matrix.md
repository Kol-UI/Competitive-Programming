Transpose Matrix

```cs
// Transpose Matrix: given an m x n matrix, return the n x m matrix
// where transpose[i][j] = matrix[j][i].

/*

[1, 2, 3],
[4, 5, 6],
[7, 8, 9]

Becomes :

[1, 4, 7],
[2, 5, 8],
[3, 6, 9]

*/

public class TransposeMatrix
{
    // Iterative Approach : allocate new matrix, swap indices
    public static int[][] Transpose(int[][] matrix)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int[][] result = new int[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[m];
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[j][i] = matrix[i][j];
            }
        }

        return result;
    }

    // LINQ Approach: build each new row by selecting column j from every original row
    public static int[][] TransposeLinq(int[][] matrix)
    {
        int n = matrix[0].Length;

        return Enumerable.Range(0, n)
            .Select(j => matrix.Select(row => row[j]).ToArray())
            .ToArray();
    }
}```