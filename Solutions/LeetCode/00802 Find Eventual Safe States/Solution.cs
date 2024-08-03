// Find Eventual Safe States

/*
There is a directed graph of n nodes with each node labeled from 0 to n - 1. The graph is represented by a 0-indexed 2D integer array graph where graph[i] is an integer array of nodes adjacent to node i, meaning there is an edge from node i to each node in graph[i].

A node is a terminal node if there are no outgoing edges. A node is a safe node if every possible path starting from that node leads to a terminal node (or another safe node).

Return an array containing all the safe nodes of the graph. The answer should be sorted in ascending order.

 

Example 1:

Illustration of graph
Input: graph = [[1,2],[2,3],[5],[0],[5],[],[]]
Output: [2,4,5,6]
Explanation: The given graph is shown above.
Nodes 5 and 6 are terminal nodes as there are no outgoing edges from either of them.
Every path starting at nodes 2, 4, 5, and 6 all lead to either node 5 or 6.

Example 2:

Input: graph = [[1,2,3,4],[1,2],[3,4],[0,4],[]]
Output: [4]
Explanation:
Only node 4 is a terminal node, and every path starting at node 4 leads to node 4.
*/


using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindEventualSafeStates
{
    public class Solution
    {
        public static IList<int> EventualSafeNodes(int[][] graph)
        {
            List<int> SafeNode = new List<int>{};
            var visited = Enumerable.Repeat(0, graph.Length).ToArray();
            var dfsvisited = Enumerable.Repeat(0, graph.Length).ToArray();
            var cycle = Enumerable.Repeat(false, graph.Length).ToArray();
            
            for (int i = 0; i < graph.Length; i++)
            {
                if(visited[i] == 0)
                {
                    DFS(i, graph, visited, dfsvisited, cycle);
                }
            }

            for (int i = 0; i < graph.Length; i++)
            {
                if(!cycle[i]) SafeNode.Add(i);
            }
            return SafeNode;
        }

        static bool DFS(int i, int[][] graph, int[] visited, int[] dfsvisited, bool[] cycle)
        {
            visited[i] = 1;
            dfsvisited[i] = 1;

            foreach(int v in graph[i])
            {
                if(visited[v] == 0)
                {
                if(DFS(v,graph, visited, dfsvisited, cycle)) return cycle[i]=true;
                }
                else if (visited[v] == 1 && dfsvisited[v] == 1)
                {
                    return cycle[i] = true;
                }
            }

            dfsvisited[i] = 0;
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] graph1 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 5 },
                new int[] { 0 },
                new int[] { 5 },
                new int[] { },
                new int[] { }
            };

            IList<int> output1 = new List<int> { 2, 4, 5, 6 };

            int[][] graph2 = new int[][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 1, 2 },
                new int[] { 3, 4 },
                new int[] { 0, 4 },
                new int[] { }
            };

            IList<int> output2 = new List<int> { 4 };


            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(Solution.EventualSafeNodes(graph1), output1),
                ResultTester.CheckResult<IList<int>>(Solution.EventualSafeNodes(graph2), output2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Find Eventual Safe States");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}