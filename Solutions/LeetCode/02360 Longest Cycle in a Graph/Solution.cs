using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestCycleinaGraph
{
    /*
        You are given a directed graph of n nodes numbered from 0 to n - 1, where each node has at most one outgoing edge.
        The graph is represented with a given 0-indexed array edges of size n, indicating that there is a directed edge from node i to node edges[i].
        If there is no outgoing edge from node i, then edges[i] == -1.
        Return the length of the longest cycle in the graph.
        If no cycle exists, return -1.
        A cycle is a path that starts and ends at the same node.

        Example 1:
        Input: edges = [3,3,4,2,3]
        Output: 3
        Explanation: The longest cycle in the graph is the cycle: 2 -> 4 -> 3 -> 2.
        The length of this cycle is 3, so 3 is returned.
        
        Example 2:
        Input: edges = [2,-1,3,1]
        Output: -1
        Explanation: There are no cycles in this graph.
    */
    public class Solution
    {
        public static int LongestCycle(int[] edges) 
        {
            int max = -1;
            int n = edges.Length;
            bool[] visited = new bool[n];
            for (int i = 0; i < n; i++)
            {
                if(!visited[i])
                {
                    var map = new Dictionary<int,int>();
                    int cur = i;
                    int cnt = 0;
                    while(!visited[cur])
                    {
                        if(edges[cur] == -1)
                        {
                            break;
                        }
                        map.Add(cur,cnt);
                        visited[cur] = true;
                        cur = edges[cur];
                        cnt++;
                    }

                    if(edges[cur] == -1)
                    {
                        continue;
                    }

                    if(map.ContainsKey(cur))
                    {
                        int diff = cnt - map[cur];
                        max = Math.Max(max, diff);
                    }
                }
            }
            return max;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[] edges2360Case1 = { 3, 3, 4, 2, 3 };
            int result2360Case1 = Solution.LongestCycle(edges2360Case1);

            // Case 2
            int[] edges2360Case2 = { 2, -1, 3, 1 };
            int result2360Case2 = Solution.LongestCycle(edges2360Case2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result2360Case1, 3),
                ResultTester.CheckResult<int>(result2360Case2, -1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Cycle in a Graph");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}