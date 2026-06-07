Convert an Adjacency Matrix to an Adjacency List.
```cs
public class AdjacencyMatrixtoAdjacencyList
{
    public Dictionary<int, List<int>> ToAdjacencyList(int[,] matrix)
    {
        var adjList = new Dictionary<int, List<int>>();
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            adjList[i] = new List<int>();
            for (int j = 0; j < colCount; j++)
            {
                // If the value is 1 (or > 0 for a weighted graph)
                if (matrix[i, j] != 0)
                {
                    adjList[i].Add(j);
                }
            }
        }

        return adjList;
    }
}```