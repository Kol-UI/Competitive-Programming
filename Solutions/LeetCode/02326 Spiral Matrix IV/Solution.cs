// Spiral Matrix IV

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SpiralMatrixIV
{
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int val=0, ListNode next=null) {
    *         this.val = val;
    *         this.next = next;
    *     }
    * }
    */
    public class Solution
    {
        public int[][] SpiralMatrix(int m, int n, ListNode head)
        {
            int[][] matrix = InitializeAndFillMatrix(m, n, -1);
            FillMatrixInSpiralOrder(matrix, head);
            return matrix;
        }

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
    }

    public class Test
    {
        public static bool[] TestCases()
        {

            var solution = new Solution();

            var head1 = new ListNode(3, new ListNode(0, new ListNode(2, new ListNode(6, 
                new ListNode(8, new ListNode(1, new ListNode(7, new ListNode(9, new ListNode(4, 
                new ListNode(2, new ListNode(5, new ListNode(5, new ListNode(0)))))))))))));

            var result1 = solution.SpiralMatrix(3, 5, head1);

            var expected1 = new int[][]
            {
                new int[] { 3, 0, 2, 6, 8 },
                new int[] { 5, 0, -1, -1, 1 },
                new int[] { 5, 2, 4, 9, 7 }
            };
            
            var head2 = new ListNode(0, new ListNode(1, new ListNode(2)));

            var result2 = solution.SpiralMatrix(1, 4, head2);

            var expected2 = new int[][]
            {
                new int[] { 0, 1, 2, -1 }
            };



            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(result1, expected1),
                ResultTester.CheckResult<int[][]>(result2, expected2),
            };

            solution.PrintMatrix(result1);
            solution.PrintMatrix(expected1);
            solution.PrintMatrix(result2);
            solution.PrintMatrix(expected2);

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Spiral Matrix IV");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}