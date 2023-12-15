using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindClosestNodetoGivenTwoNodes
{
	public class Solution
    {
        //You are given a directed graph of n nodes numbered from 0 to n - 1, where each node has at most one outgoing edge.
        //The graph is represented with a given 0-indexed array edges of size n, indicating that there is a directed edge from node i to node edges[i]. If there is no outgoing edge from i, then edges[i] == -1.

        //You are also given two integers node1 and node2.
        //Return the index of the node that can be reached from both node1 and node2, such that the maximum between the distance from node1 to that node, and from node2 to that node is minimized.If there are multiple answers, return the node with the smallest index, and if no possible answer exists, return -1.

        //Note that edges may contain cycles.

        //Example 1
        //Input: edges = [2, 2, 3, -1], node1 = 0, node2 = 1
        //Output: 2
        //Explanation: The distance from node 0 to node 2 is 1, and the distance from node 1 to node 2 is 1.
        //The maximum of those two distances is 1. It can be proven that we cannot get a node with a smaller maximum distance than 1, so we return node 2.

        //Example 2
        //Input: edges = [1,2,-1], node1 = 0, node2 = 2
        //Output: 2
        //Explanation: The distance from node 0 to node 2 is 2, and the distance from node 2 to itself is 0.
        //The maximum of those two distances is 2. It can be proven that we cannot get a node with a smaller maximum distance than 2, so we return node 2.


        public static int ClosestMeetingNode(int[] edges, int node1, int node2)
        {
            Queue<(int, int, int)> q = new();
            int[] max = new int[edges.Length];
            int[] visited = new int[edges.Length];
            q.Enqueue((node1, 1, 0));
            q.Enqueue((node2, 2, 0));
            var answer = -1;
            while (q.Count > 0)
            {
                (var node, var source, var cost) = q.Dequeue();
                max[node] = Math.Max(cost, max[node]);
                visited[node] += source;
                if (visited[node] == 3 && (answer == -1 || max[node] < max[answer] || (max[node] == max[answer] && node < answer)))
                {
                    answer = node;
                }
                var next = edges[node];
                if (next != -1 && ((visited[next] & source) != source))
                {
                    q.Enqueue((next, source, cost + 1));
                }
            }
            return answer;
        }

    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[] edgesCase1_2359 = { 2, 2, 3, -1 };
            int node1Case1_2359 = 0;
            int node2Case1_2359 = 1;
            int Case1_2359_Result = Solution.ClosestMeetingNode(edgesCase1_2359, node1Case1_2359, node2Case1_2359);

            // Case 2
            int[] edgesCase2_2359 = { 1, 2, -1 };
            int node1Case2_2359 = 0;
            int node2Case2_2359 = 2;
            int Case2_2359_Result = Solution.ClosestMeetingNode(edgesCase2_2359, node1Case2_2359, node2Case2_2359);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_2359_Result, 2),
                ResultTester.CheckResult<int>(Case2_2359_Result, 2)
            };
            return results;
        }
    }
}

