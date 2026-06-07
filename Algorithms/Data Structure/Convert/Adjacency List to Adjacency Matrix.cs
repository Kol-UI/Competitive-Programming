namespace CompetitiveProgramming.Algorithms;

public class AdjacencyListToAdjacencyMatrix
{
    public int[,] ToAdjacencyMatrix(Dictionary<int, List<int>> adjList, int nodeCount)
    {
        // Initialize a square matrix of size N x N
        int[,] matrix = new int[nodeCount, nodeCount];

        foreach (var node in adjList)
        {
            int u = node.Key; // The source node
            foreach (int v in node.Value) // Its neighbors
            {
                // Mark the connection
                // Note: This assumes that indices are 0-based
                matrix[u, v] = 1;

                // If the graph is undirected, you would also need to do:
                // matrix[v, u] = 1;
            }
        }

        return matrix;
    }
}