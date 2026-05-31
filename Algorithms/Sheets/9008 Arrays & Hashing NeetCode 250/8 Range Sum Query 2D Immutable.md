Range Sum Query 2D Immutable

You are given a 2D matrix matrix, handle multiple queries of the following type:

Calculate the sum of the elements of matrix inside the rectangle defined by its upper left corner (row1, col1) and lower right corner (row2, col2).


Implement the NumMatrix class:

NumMatrix(int[][] matrix) Initializes the object with the integer matrix matrix.

int sumRegion(int row1, int col1, int row2, int col2) Returns the sum of the elements of matrix inside the rectangle defined by its upper left corner (row1, col1) and lower right corner (row2, col2).

You must design an algorithm where sumRegion works on O(1) time complexity.


Example:

Input: ["NumMatrix", "sumRegion", "sumRegion", "sumRegion"]

[[[[3, 0, 1, 4, 2], [5, 6, 3, 2, 1], [1, 2, 0, 1, 5], [4, 1, 0, 1, 7], [1, 0, 3, 0, 5]]], [2, 1, 4, 3], [1, 1, 2, 2], [1, 2, 2, 4]]

Output: [null, 8, 11, 12]

Explanation:

NumMatrix numMatrix = new NumMatrix([[3, 0, 1, 4, 2], [5, 6, 3, 2, 1], [1, 2, 0, 1, 5], [4, 1, 0, 1, 7], [1, 0, 3, 0, 5]]);

numMatrix.sumRegion(2, 1, 4, 3); // return 8 (i.e sum of the red rectangle)

numMatrix.sumRegion(1, 1, 2, 2); // return 11 (i.e sum of the green rectangle)

numMatrix.sumRegion(1, 2, 2, 4); // return 12 (i.e sum of the blue rectangle)


Constraints:


m == matrix.length

n == matrix[i].length

1 <= m, n <= 200

-10,000 <= matrix[i][j] <= 10,000

0 <= row1 <= row2 < m

0 <= col1 <= col2 < n

At most 10,000 calls will be made to sumRegion.


```cs
// Brute Force Approach

public class NumMatrixBruteForce
{
    public required int[][] _matrix;

    public NumMatrixBruteForce(int[][] matrix)
    {
        _matrix = matrix;
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        int result = 0;
        for (int row = row1; row <= row2; row++) // for each row
        {
            for (int col = col1; col <= col2; col++) // for each col
            {
                result += _matrix[row][col];
            }
        }
        return result;
    }
}

// Prefix Sum Approach

public class NumMatrixOnDimensionalPrefixSum
{
    public required int[][] prefixSum;

    public NumMatrixOnDimensionalPrefixSum(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        prefixSum = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            prefixSum[i] = new int[cols];
            prefixSum[i][0] = matrix[i][0];
            for (int j = 1; j < cols; j++)
            {
                prefixSum[i][j] = prefixSum[i][j - 1] + matrix[i][j];
                // actual prefixSum = value on the left of the actual + actual from origin matrix
            }
        }

        /*
            Example:
            1 2 3
            2 3 4

            Prefix Sum
            0  0  0  0
            0  1  3  6 (0, 0+1*, 1+2**, 3+3***)
            0  3  8 15 (0, 1+2****, 1+2+2+3*****, 1+2+2+3+3+4******)

            *
            '1' 2 3
            2 3 4

            **
            '1' '2' 3
            2 3 4

            ***
            '1' '2' '3'
            2 3 4

            ****
            '1' 2 3
            '2' 3 4

            *****
            '1' '2' 3
            '2' '3' 4

            ******
            '1' '2' '3'
            '2' '3' '4'
        */
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        int result = 0;
        for (int row = row1; row <= row2; row++) // for each row, calculate all cols sum
        {
            if (col1 > 0)
            {
                result += prefixSum[row][col2] - prefixSum[row][col1 - 1];
            }
            else
            {
                result += prefixSum[row][col2];
            }
        }
        return result;

        /*
            Matrix
            1 2 3
            2 3 4

            PrefixSum
            1 3 6
            2 5 9

            Case col1 > 0
            sumRegion(0, 1, 0, 2)
            1 '2' '3'
            2 3 4
            Sum = 5

            Case col1 == 0
            sumRegion(1, 0, 1, 1)
            1 2 3
            '2' '3' 4
            Sum = 5

            Case 3
            sumRegion(1, 0, 1, 1)
            1 2 3
            2 3 4
        */
    }
}

public class NumMatrixTwoDimensionalPrefixSum
{
    public int[,] sumMat;

    public NumMatrixTwoDimensionalPrefixSum(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        sumMat = new int[rows + 1, cols + 1];

        for (int r = 0; r < rows; r++)
        {
            int prefix = 0;
            for (int c = 0; c < cols; c++)
            {
                prefix += matrix[r][c];
                int above = sumMat[r, c + 1];
                sumMat[r + 1, c + 1] = prefix + above;
            }
        }
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        row1++; col1++; row2++; col2++;
        int bottomRight = sumMat[row2, col2];
        int above = sumMat[row1 - 1, col2];
        int left = sumMat[row2, col1 - 1];
        int topLeft = sumMat[row1 - 1, col1 - 1];
        return bottomRight - above - left + topLeft;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */
```