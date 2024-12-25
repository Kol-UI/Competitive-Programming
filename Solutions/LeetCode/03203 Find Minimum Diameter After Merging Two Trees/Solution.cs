// Find Minimum Diameter After Merging Two Trees

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindMinimumDiameterAfterMergingTwoTrees
{
    public class Solution
    {
        public int MinimumDiameterAfterMerge(int[][] edges1, int[][] edges2)
        {
            int n = edges1.Length + 1;
            int m = edges2.Length + 1;

            List<List<int>> adjList1 = BuildAdjList(n, edges1);
            List<List<int>> adjList2 = BuildAdjList(m, edges2);

            int diameter1 = FindDiameter(n, adjList1);
            int diameter2 = FindDiameter(m, adjList2);

            int combinedDiameter =
                (int)Math.Ceiling(diameter1 / 2.0) +
                (int)Math.Ceiling(diameter2 / 2.0) +
                1;

            return Math.Max(Math.Max(diameter1, diameter2), combinedDiameter);
        }

        private (int, int) FindFarthestNode(int n, List<List<int>> adjList, int sourceNode)
        {
            Queue<int> queue = new Queue<int>();
            bool[] visited = new bool[n];

            queue.Enqueue(sourceNode);
            visited[sourceNode] = true;

            int maximumDistance = 0;
            int farthestNode = sourceNode;

            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    int currentNode = queue.Dequeue();
                    farthestNode = currentNode;

                    foreach (int neighbor in adjList[currentNode])
                    {
                        if (!visited[neighbor])
                        {
                            visited[neighbor] = true;
                            queue.Enqueue(neighbor);
                        }
                    }
                }
                if (queue.Count > 0) maximumDistance++;
            }
            return (farthestNode, maximumDistance);
        }

        private int FindDiameter(int n, List<List<int>> adjList)
        {
            (int farthestNode, int _) = FindFarthestNode(n, adjList, 0);
            (_, int maximumDistance) = FindFarthestNode(n, adjList, farthestNode);
            return maximumDistance;
        }

        private List<List<int>> BuildAdjList(int size, int[][] edges)
        {
            List<List<int>> adjList = new List<List<int>>();
            for (int i = 0; i < size; i++)
            {
                adjList.Add(new List<int>());
            }
            foreach (int[] edge in edges)
            {
                adjList[edge[0]].Add(edge[1]);
                adjList[edge[1]].Add(edge[0]);
            }
            return adjList;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Minimum Diameter After Merging Two Trees");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}