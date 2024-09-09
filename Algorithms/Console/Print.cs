namespace CompetitiveProgramming.Algorithms;

public class Print
{
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