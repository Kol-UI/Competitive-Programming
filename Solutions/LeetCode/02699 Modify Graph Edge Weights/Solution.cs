// Modify Graph Edge Weights

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ModifyGraphEdgeWeights
{
    public class SolutionModifiedGraphEdges
    {
        private const int INF = 2000000000;
        private const int WeightToIgnore = -1;

        public int[][] ModifiedGraphEdges(int n, int[][] edges, int source, int destination, int target)
        {
            long initialDistance = CalculateDijkstraShortestDistance(n, edges, source, destination);
            
            if (initialDistance < target)
            {
                return new int[0][];
            }

            bool isTargetReached = (initialDistance == target);
            AdjustEdgeWeights(edges, n, source, destination, ref isTargetReached, target);

            return isTargetReached ? edges : new int[0][];
        }

        private static void AdjustEdgeWeights(int[][] edges, int n, int source, int destination, ref bool isTargetReached, int target)
        {
            foreach (var edge in edges)
            {
                if (edge[2] > 0)
                {
                    continue;
                }

                if (isTargetReached)
                {
                    edge[2] = INF;
                }
                else
                {
                    edge[2] = 1;
                    long newDistance = CalculateDijkstraShortestDistance(n, edges, source, destination);

                    if (newDistance <= target)
                    {
                        isTargetReached = true;
                        edge[2] += target - (int)newDistance;
                    }
                }
            }
        }

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
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] edges1 = new int[][]
            {
                new int[] { 4, 1, -1 },
                new int[] { 2, 0, -1 },
                new int[] { 0, 3, -1 },
                new int[] { 4, 3, -1 },
            };

            int[][] expected1 = new int[][]
            {
                new int[] { 4, 1, 1 },
                new int[] { 2, 0, 1 },
                new int[] { 0, 3, 1 },
                new int[] { 4, 3, 3 },
            };

            int[][] edges2 = new int[][]
            {
                new int[] { 1, 0, 4 },
                new int[] { 1, 2, 3 },
                new int[] { 2, 3, 5 },
                new int[] { 0, 3, -1 },
            };

            int[][] expected2 = new int[][]
            {
                new int[] { 1, 0, 4 },
                new int[] { 1, 2, 3 },
                new int[] { 2, 3, 5 },
                new int[] { 0, 3, 1 },
            };

            int[][] edges3 = new int[][]
            {
                new int[] { 1, 0, 4 },
                new int[] { 1, 2, 3 },
                new int[] { 2, 3, 5 },
                new int[] { 0, 3, -1 },
            };

            int[][] expected3 = new int[][]
            {
                new int[] { 1, 0, 4 },
                new int[] { 1, 2, 3 },
                new int[] { 2, 3, 5 },
                new int[] { 0, 3, 1 },
            };

            SolutionModifiedGraphEdges solution = new();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(solution.ModifiedGraphEdges(5, edges1, 0, 1, 5), expected1),
                ResultTester.CheckResult<int[][]>(solution.ModifiedGraphEdges(4, edges2, 0, 2, 6), expected2),
                ResultTester.CheckResult<int[][]>(solution.ModifiedGraphEdges(4, edges3, 0, 2, 6), expected3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Modify Graph Edge Weights");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}