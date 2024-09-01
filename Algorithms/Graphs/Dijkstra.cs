namespace CompetitiveProgramming.Dijkstra
{
    public class Dijkstra
    {
        #region LC2699
        private const int INF = 2000000000;
        private const int WeightToIgnore = -1;
        private static long CalculateDijkstraShortestDistance(int n, int[][] edges, int source, int destination)
        {
            int[][] graph = InitializeGraph(n, edges);
            long[] distances = InitializeDistances(n, source);
            bool[] visited = new bool[n];

            for (int i = 0; i < n; i++)
            {
                int currentNode = GetNextNodeToProcess(distances, visited);

                if (currentNode == WeightToIgnore)
                    break;

                visited[currentNode] = true;
                UpdateDistances(graph, distances, currentNode, n);
            }

            return distances[destination];
        }

        private static int[][] InitializeGraph(int n, int[][] edges)
        {
            int[][] graph = new int[n][];

            for (int i = 0; i < n; i++)
            {
                graph[i] = new int[n];
                Array.Fill(graph[i], INF);
            }

            foreach (var edge in edges)
            {
                int u = edge[0], v = edge[1], w = edge[2];
                if (w != WeightToIgnore)
                {
                    graph[u][v] = w;
                    graph[v][u] = w;
                }
            }

            return graph;
        }

        private static long[] InitializeDistances(int n, int source)
        {
            long[] distances = new long[n];
            Array.Fill(distances, INF);
            distances[source] = 0;
            return distances;
        }

        private static int GetNextNodeToProcess(long[] distances, bool[] visited)
        {
            int currentNode = WeightToIgnore;

            for (int j = 0; j < distances.Length; j++)
            {
                if (!visited[j] && (currentNode == WeightToIgnore || distances[currentNode] > distances[j]))
                {
                    currentNode = j;
                }
            }

            return currentNode;
        }

        private static void UpdateDistances(int[][] graph, long[] distances, int currentNode, int n)
        {
            for (int j = 0; j < n; j++)
            {
                distances[j] = Math.Min(distances[j], distances[currentNode] + graph[currentNode][j]);
            }
        }
        #endregion

        #region LC1514
        private SortedSet<(double, int)> CreatePriorityQueue()
        {
            return new SortedSet<(double, int)>(Comparer<(double, int)>.Create((a, b) =>
            {
                int cmp = b.Item1.CompareTo(a.Item1);
                return cmp == 0 ? a.Item2.CompareTo(b.Item2) : cmp;
            }));
        }

        private double GetDijkstraMaxProbability(Dictionary<int, List<(int, double)>> graph, double[] maxProb, SortedSet<(double probability, int node)> priorityQueue, int end)
        {
            while (priorityQueue.Count > 0)
            {
                var (currentProb, currentNode) = priorityQueue.Min;
                priorityQueue.Remove(priorityQueue.Min);

                if (currentNode == end)
                {
                    return currentProb;
                }

                foreach (var (neighbor, prob) in graph[currentNode])
                {
                    double newProb = currentProb * prob;
                    if (newProb > maxProb[neighbor])
                    {
                        maxProb[neighbor] = newProb;
                        priorityQueue.Add((newProb, neighbor));
                    }
                }
            }

            return 0.0;
        }
        #endregion
    }
}