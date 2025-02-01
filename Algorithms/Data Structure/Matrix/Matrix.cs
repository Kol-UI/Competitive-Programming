using CompetitiveProgramming.LeetCode;

namespace CompetitiveProgramming.Algorithms
{
    public class Matrix
    {
        public static int GetRowCount(int[][] matrix)
        {
            return matrix.Length;
        }

        public static int GetColCount(int[][] matrix)
        {
            return matrix.Length > 0 ? matrix[0].Length : 0;
        }

        // nb of col = nb of row
        public static bool IsSquareMatrix(int[][] matrix)
        {
            return matrix.Length > 0 && matrix.Length == matrix[0].Length;
        }

        public static int GetMaxValue(int[][] matrix)
        {
            int max = int.MinValue;
            foreach (var row in matrix)
            {
                foreach (var val in row)
                {
                    max = Math.Max(max, val);
                }
            }
            return max;
        }

        public static int GetMinValue(int[][] matrix)
        {
            int min = int.MaxValue;
            foreach (var row in matrix)
            {
                foreach (var val in row)
                {
                    min = Math.Min(min, val);
                }
            }
            return min;
        }

        public static bool AreMatricesEqual(int[][] matrix1, int[][] matrix2)
        {
            if (matrix1.Length != matrix2.Length) return false;

            for (int i = 0; i < matrix1.Length; i++)
            {
                if (matrix1[i].Length != matrix2[i].Length) return false;

                for (int j = 0; j < matrix1[i].Length; j++)
                {
                    if (matrix1[i][j] != matrix2[i][j]) return false;
                }
            }
            return true;
        }

        // inverse row & col of each value
        public static int[][] TransposeMatrix(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int[][] transposed = new int[cols][];
            for (int i = 0; i < cols; i++)
            {
                transposed[i] = new int[rows];
                for (int j = 0; j < rows; j++)
                {
                    transposed[i][j] = matrix[j][i];
                }
            }
            return transposed;
        }

        private static List<int> SpiralTraversal(int[][] matrix)
        {
            List<int> result = new List<int>();
            if (matrix == null || matrix.Length == 0) 
            {
                return result;
            }

            int top = 0, bottom = matrix.Length - 1;
            int left = 0, right = matrix[0].Length - 1;

            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++)
                {
                    result.Add(matrix[top][i]);
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    result.Add(matrix[i][right]);
                }
                right--;

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        result.Add(matrix[bottom][i]);
                    }
                    bottom--;
                }

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

        public static int FindMedianInSortedMatrix(int[][] matrix)
        {
            List<int> elements = new List<int>();

            foreach (var row in matrix)
            {
                elements.AddRange(row);
            }

            elements.Sort();

            return elements[elements.Count / 2];
        }
        
        public static int FindMedianInRowWiseSortedMatrix(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int low = matrix[0][0], high = matrix[0][cols - 1];

            foreach (var row in matrix)
            {
                low = Math.Min(low, row[0]);
                high = Math.Max(high, row[cols - 1]);
            }

            int medianPos = (rows * cols) / 2;

            while (low < high)
            {
                int mid = low + (high - low) / 2;
                int count = 0;

                foreach (var row in matrix)
                {
                    count += BinarySearchCount(row, mid);
                }

                if (count <= medianPos)
                    low = mid + 1;
                else
                    high = mid;
            }

            return low;
        }

        private static int BinarySearchCount(int[] row, int target)
        {
            int left = 0, right = row.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (row[mid] <= target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return left;
        }

        #region LC 2022
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

        #region CF 1520C
        public static string MatrixToString(int[,] matrix, int n)
        {
            List<string> rows = new List<string>();
            for (int i = 0; i < n; i++)
            {
                List<string> row = new List<string>();
                for (int j = 0; j < n; j++)
                {
                    row.Add(matrix[i, j].ToString());
                }
                rows.Add(string.Join(" ", row));
            }
            return string.Join("\n", rows);
        }
        #endregion
    }
}