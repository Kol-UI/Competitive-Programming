Convert 2D Matrix (T[,]) to 1D Array (T[]).
```cs
public static class MatrixtoFlattenedArray
{
    public static T[] Flatten<T>(T[,] matrix)
    {
        if (matrix == null) return Array.Empty<T>();
        
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        T[] flattened = new T[rows * cols];

        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                flattened[index++] = matrix[i, j];
            }
        }

        return flattened;
    }
    
    public static T[] FlattenWithLinq<T>(T[,] matrix)
    {
        if (matrix == null) return Array.Empty<T>();
        return matrix.Cast<T>().ToArray();
    }
}```