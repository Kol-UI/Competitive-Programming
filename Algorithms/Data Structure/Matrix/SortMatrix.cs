namespace CompetitiveProgramming.Algorithms;

public class SortMatrix
{
    public static void SortMatrixRows(int[][] matrix)
    {
        foreach (var row in matrix)
        {
            Array.Sort(row);
        }
    }

    public static void SortMatrixColumns(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        for (int col = 0; col < cols; col++)
        {
            List<int> column = new List<int>();

            for (int row = 0; row < rows; row++)
            {
                column.Add(matrix[row][col]);
            }

            column.Sort();

            for (int row = 0; row < rows; row++)
            {
                matrix[row][col] = column[row];
            }
        }
    }

    public static void SortMatrixGlobally(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        List<int> flatList = new List<int>();
        foreach (var row in matrix)
        {
            flatList.AddRange(row);
        }

        flatList.Sort();

        int index = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row][col] = flatList[index++];
            }
        }
    }
}