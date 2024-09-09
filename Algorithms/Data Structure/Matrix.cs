using CompetitiveProgramming.LeetCode;

namespace CompetitiveProgramming.Algorithms
{
    public class Matrix
    {
        #region LC2022
        private static void Fill2DArray(int[] original, int[][] result, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                result[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    result[i][j] = original[i * n + j];
                }
            }
        }
        #endregion

        #region LC 2326
        private static int[][] InitializeAndFillMatrix(int rows, int cols, int emptySpace)
        {
            int[][] matrix = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = emptySpace;
                }
            }
            return matrix;
        }

        private void FillMatrixInSpiralOrder(int[][] matrix, ListNode head)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            
            int[] rowDirections = { 0, 1, 0, -1 };
            int[] colDirections = { 1, 0, -1, 0 };
            
            int currentRow = 0, currentCol = 0, currentDirection = 0;
            ListNode currentNode = head;
            
            for (int i = 0; i < m * n && currentNode != null; i++)
            {
                matrix[currentRow][currentCol] = currentNode.val;
                currentNode = currentNode.next;
                
                int nextRow = currentRow + rowDirections[currentDirection];
                int nextCol = currentCol + colDirections[currentDirection];
                
                if (!IsInBounds(nextRow, nextCol, m, n) || matrix[nextRow][nextCol] != -1)
                {
                    currentDirection = (currentDirection + 1) % 4;
                    nextRow = currentRow + rowDirections[currentDirection];
                    nextCol = currentCol + colDirections[currentDirection];
                }
                
                currentRow = nextRow;
                currentCol = nextCol;
            }
        }

        private bool IsInBounds(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }

        public void PrintMatrix(int[][] matrix)
        {
            if (matrix == null || matrix.Length == 0)
            {
                Console.WriteLine("The matrix is empty.");
                return;
            }

            int numRows = matrix.Length;
            int numCols = matrix[0].Length;

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    Console.Write(matrix[i][j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        #endregion
    }
}