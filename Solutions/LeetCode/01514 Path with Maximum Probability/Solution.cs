// Path with Maximum Probability

/*

You are given an undirected weighted graph of n nodes (0-indexed), represented by an edge list where edges[i] = [a, b] is an undirected edge connecting the nodes a and b with a probability of success of traversing that edge succProb[i].

Given two nodes start and end, find the path with the maximum probability of success to go from start to end and return its success probability.

If there is no path from start to end, return 0. Your answer will be accepted if it differs from the correct answer by at most 1e-5.

 
Example 1:

Input: n = 3, edges = [[0,1],[1,2],[0,2]], succProb = [0.5,0.5,0.2], start = 0, end = 2
Output: 0.25000
Explanation: There are two paths from start to end, one having a probability of success = 0.2 and the other has 0.5 * 0.5 = 0.25.

Example 2:

Input: n = 3, edges = [[0,1],[1,2],[0,2]], succProb = [0.5,0.5,0.3], start = 0, end = 2
Output: 0.30000

Example 3:

Input: n = 3, edges = [[0,1]], succProb = [0.5], start = 0, end = 2
Output: 0.00000
Explanation: There is no path between 0 and 2.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PathwithMaximumProbability
{
    public class Solution
    {
        public static double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end)
        {
            Dictionary<int, List<(int, double)>> graph = new Dictionary<int, List<(int, double)>>();

            for (int i = 0; i < edges.Length; i++)
            {
                int u = edges[i][0];
                int v = edges[i][1];
                double pathProb = succProb[i];

                if (!graph.ContainsKey(u))
                    graph[u] = new List<(int, double)>();

                if (!graph.ContainsKey(v))
                    graph[v] = new List<(int, double)>();

                graph[u].Add((v, pathProb));
                graph[v].Add((u, pathProb));
            }

            double[] maxProb = new double[n];
            maxProb[start] = 1d;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                int curNode = queue.Dequeue();
                foreach ((int nxtNode, double pathProb) in graph.GetValueOrDefault(curNode, new List<(int, double)>()))
                {
                    if (maxProb[curNode] * pathProb > maxProb[nxtNode])
                    {
                        maxProb[nxtNode] = maxProb[curNode] * pathProb;
                        queue.Enqueue(nxtNode);
                    }
                }
            }

            return maxProb[end];
        }
    }

    public class Solution2
    {
        public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node)
        {
            var graph = CreateGraph(n, edges, succProb);

            double[] maxProb = new double[n];
            maxProb[start_node] = 1.0;

            var priorityQueue = CreatePriorityQueue();

            priorityQueue.Add((1.0, start_node));

            return GetDijkstraMaxProbability(graph, maxProb, priorityQueue, end_node);
        }

        private Dictionary<int, List<(int, double)>> CreateGraph(int n, int[][] edges, double[] succProb)
        {
            var graph = new Dictionary<int, List<(int, double)>>();
            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<(int, double)>();
            }

            for (int i = 0; i < edges.Length; i++)
            {
                int u = edges[i][0];
                int v = edges[i][1];
                double prob = succProb[i];
                graph[u].Add((v, prob));
                graph[v].Add((u, prob));
            }

            return graph;
        }

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
    }

    public class Test
    {
        public static bool[] TestPathwithMaximumProbability()
        {
            int n1 = 3; double[] succProb1 = {0.5,0.5,0.2}; int start1 = 0; int end1 = 2;
            int[][] edges1 = new int[][]
            {
                new int[] { 0,1 },
                new int[] { 1,2 },
                new int[] { 0,2 }
            };

            int n2 = 3; double[] succProb2 = {0.5,0.5,0.3}; int start2 = 0; int end2 = 2;
            int[][] edges2 = new int[][]
            {
                new int[] { 0,1 },
                new int[] { 1,2 },
                new int[] { 0,2 }
            };

            int n3 = 3; double[] succProb3 = {0.5}; int start3 = 0; int end3 = 2;
            int[][] edges3 = new int[][]
            {
                new int[] { 0,1 }
            };

            Solution2 solution = new();

            int n4 = 3; double[] succProb4 = {0.5,0.5,0.2}; int start4 = 0; int end4 = 2;
            int[][] edges4 = new int[][]
            {
                new int[] { 0,1 },
                new int[] { 1,2 },
                new int[] { 0,2 }
            };

            int n5 = 3; double[] succProb5 = {0.5,0.5,0.3}; int start5 = 0; int end5 = 2;
            int[][] edges5 = new int[][]
            {
                new int[] { 0,1 },
                new int[] { 1,2 },
                new int[] { 0,2 }
            };

            int n6 = 3; double[] succProb6 = {0.5}; int start6 = 0; int end6 = 2;
            int[][] edges6 = new int[][]
            {
                new int[] { 0,1 }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double>(Solution.MaxProbability(n1, edges1, succProb1, start1, end1), 0.25000),
                ResultTester.CheckResult<double>(Solution.MaxProbability(n2, edges2, succProb2, start2, end2), 0.30000),
                ResultTester.CheckResult<double>(Solution.MaxProbability(n3, edges3, succProb3, start3, end3), 0.00000),
                ResultTester.CheckResult<double>(solution.MaxProbability(n4, edges4, succProb4, start4, end4), 0.25000),
                ResultTester.CheckResult<double>(solution.MaxProbability(n5, edges5, succProb5, start5, end5), 0.30000),
                ResultTester.CheckResult<double>(solution.MaxProbability(n6, edges6, succProb6, start6, end6), 0.00000),
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Path with Maximum Probability");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestPathwithMaximumProbability());
        }
    }
}