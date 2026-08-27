namespace CompetitiveProgramming.Algorithms;
/*
[1, 2, 3],
[2, 5, 6],
[3, 6, 9]

returns true.
*/
public class SymmetricMatrix
{
    public static bool IsSymmetric(int[][] matrix)
    {
        int n = matrix.Length;

        // only need to check upper triangle against lower triangle
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (matrix[i][j] != matrix[j][i])
                {
                    return false;
                }
            }
        }

        return true;
    }
}