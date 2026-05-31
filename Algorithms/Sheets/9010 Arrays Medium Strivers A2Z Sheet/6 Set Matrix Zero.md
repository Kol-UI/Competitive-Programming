Set Matrix Zero :

Given a matrix if an element in the matrix is 0 then you will have to set its entire column and row to 0 and then return the matrix.

Examples :

Input: matrix=[[1,1,1],[1,0,1],[1,1,1]]

Output: [[1,0,1],[0,0,0],[1,0,1]]

Explanation: Since matrix[2][2]=0
Therefore the 2nd column and 2nd row wil be set to 0.
 
Input: matrix=[[0,1,2,0],[3,4,5,2],[1,3,1,5]]

Output:[[0,0,0,0],[0,4,5,0],[0,3,1,0]]

Explanation: Since matrix[0][0]=0 and matrix[0][3]=0.
Therefore 1st row, 1st column and 4th column will be set to 0


```cs

public class SetMatrixZero
{
    public int[][] SetZeroes(int[][] matrix)
    {
        // Number of rows and cols
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        // Marking rows and cols
        bool[] zeroRows = new bool[rows];
        bool[] zeroCols = new bool[cols];

        // First Step : find zeroes
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i][j] == 0)
                {
                    // If a zero is found, mark corresponding row and col
                    zeroRows[i] = true;
                    zeroCols[j] = true;
                }
            }
        }

        // Second Step : put zeroes on marked rows and cols
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (zeroRows[i] || zeroCols[j])
                {
                    matrix[i][j] = 0;
                }
            }
        }
        
        return matrix;
    }
}
```