using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShortestPathwithAlternatingColors
{
	public class Solution
    {
        // You are given an integer n, the number of nodes in a directed graph where the nodes are labeled from 0 to n - 1. Each edge is red or blue in this graph, and there could be self-edges and parallel edges.
        // You are given two arrays redEdges and blueEdges where:
        // redEdges[i] = [ai, bi] indicates that there is a directed red edge from node ai to node bi in the graph, and
        // blueEdges[j] = [uj, vj] indicates that there is a directed blue edge from node uj to node vj in the graph.
        // Return an array answer of length n, where each answer[x] is the length of the shortest path from node 0 to node x such that the edge colors alternate along the path, or -1 if such a path does not exist.

        // Example 1:

        // Input: n = 3, redEdges = [[0,1],[1,2]], blueEdges = []
        // Output: [0,1,-1]
        
        // Example 2:

        // Input: n = 3, redEdges = [[0,1]], blueEdges = [[2,1]]
        // Output: [0,1,-1]

        public static int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges)
        {
            var red = new List<int>[n];
            var blue = new List<int>[n];
            for (var i = 0; i < n; i++)
            {
                red[i] = new List<int>();
                blue[i] = new List<int>();
            }

            foreach (var edge in redEdges) red[edge[0]].Add(edge[1]);
            foreach (var edge in blueEdges) blue[edge[0]].Add(edge[1]);

            var result = new int[n];
            for (var i = 0; i < n; i++)
            {
                result[i] = -1;
            } 

            var queue = new Queue<(int node, bool color)>();
            queue.Enqueue((0, true));
            queue.Enqueue((0, false));
            var visited = new HashSet<(int node, bool color)>();
            visited.Add((0, true));
            visited.Add((0, false));

            var level = 0;
            while (queue.Count > 0)
            {
                var count = queue.Count;
                for (var i = 0; i < count; i++)
                {
                    var (node, color) = queue.Dequeue();
                    if (result[node] == -1) result[node] = level;

                    if (color)
                    {
                        foreach (var next in red[node])
                        {
                            if (!visited.Contains((next, false)))
                            {
                                queue.Enqueue((next, false));
                                visited.Add((next, false));
                            }
                        }   
                    }
                    else
                    {
                        foreach (var next in blue[node])
                        {
                            if (!visited.Contains((next, true)))
                            {
                                queue.Enqueue((next, true));
                                visited.Add((next, true));
                            }
                        }
                    }
                }
                level++;
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestShortestPathwithAlternatingColors()
        {
            // Case 1
            int nCase1_1129 = 3;
            int[][] redEdgesCase1_1129 = new int[][]
            {
                new int[] {0, 1},
                new int[] {1, 2}
            };
            int[][] blueEdgesCase1_1129 = new int[][] { };
            int[] Case1_1129_Result = Solution.ShortestAlternatingPaths(nCase1_1129, redEdgesCase1_1129, blueEdgesCase1_1129);

            // Case 2
            int nCase2_1129 = 3;
            int[][] redEdgesCase2_1129 = new int[][]
            {
                new int[] {0, 1}
            };
            int[][] blueEdgesCase2_1129 = new int[][]
            {
                new int[] {2, 1}
            };
            int[] Case2_1129_Result = Solution.ShortestAlternatingPaths(nCase2_1129, redEdgesCase2_1129, blueEdgesCase2_1129);

            // Case 3
            int nCase3_1129 = 7;
            int[][] redEdgesCase3_1129 = new int[][]
            {
                new int[] {0, 1},
                new int[] {0, 2},
                new int[] {1, 4},
                new int[] {1, 2},
                new int[] {2, 3}
            };
            int[][] blueEdgesCase3_1129 = new int[][]
            {
                new int[] {1, 2},
                new int[] {2, 5},
                new int[] {3, 6}
            };
            int[] Case3_1129_Result = Solution.ShortestAlternatingPaths(nCase3_1129, redEdgesCase3_1129, blueEdgesCase3_1129);

            int[] expected1 = {0,1,-1};
            int[] expected2 = {0,1,-1};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Case1_1129_Result, expected1),
                ResultTester.CheckResult<int[]>(Case2_1129_Result, expected2),
                ResultTester.CheckResult<int[]>(Case3_1129_Result, Case3_1129_Result)
            };

            return results;
        }
    }
}