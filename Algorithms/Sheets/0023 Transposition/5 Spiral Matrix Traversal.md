Spiral Matrix Traversal

```cs
// Spiral Matrix Traversal: return all elements of an m x n matrix
// in spiral order, starting from the top-left corner, going right.
/*
[1, 2, 3],
[4, 5, 6],
[7, 8, 9]

Expected : [1, 2, 3, 6, 9, 8, 7, 4, 5]
*/
public class SpiralMatrix
{
    public static List<int> SpiralTraversal(int[][] matrix)
    {
        List<int> result = new List<int>();
        if (matrix.Length == 0 || matrix[0].Length == 0)
        {
            return result;
        }

        int top = 0;
        int bottom = matrix.Length - 1;
        int left = 0;
        int right = matrix[0].Length - 1;

        while (top <= bottom && left <= right)
        {
            // traverse top row, left to right
            for (int j = left; j <= right; j++)
            {
                result.Add(matrix[top][j]);
            }
            top++;

            // traverse right column, top to bottom
            for (int i = top; i <= bottom; i++)
            {
                result.Add(matrix[i][right]);
            }
            right--;

            // traverse bottom row, right to left (if still valid)
            if (top <= bottom)
            {
                for (int j = right; j >= left; j--)
                {
                    result.Add(matrix[bottom][j]);
                }
                bottom--;
            }

            // traverse left column, bottom to top (if still valid)
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
        }

        return result;
    }
}```