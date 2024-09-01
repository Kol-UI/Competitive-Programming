namespace CompetitiveProgramming.Algorithms
{
    public class Matrix
    {
        #region 2022
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
    }
}