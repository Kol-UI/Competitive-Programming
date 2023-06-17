// All Paths From Source to Target

/*
Given a directed acyclic graph (DAG) of n nodes labeled from 0 to n - 1, find all possible paths from node 0 to node n - 1 and return them in any order.

The graph is given as follows: graph[i] is a list of all nodes you can visit from node i (i.e., there is a directed edge from node i to node graph[i][j]).

 

Example 1:

Input: graph = [[1,2],[3],[3],[]]
Output: [[0,1,3],[0,2,3]]
Explanation: There are two paths: 0 -> 1 -> 3 and 0 -> 2 -> 3.

Example 2:

Input: graph = [[4,3,1],[3,2,4],[3],[4],[]]
Output: [[0,4],[0,3,4],[0,1,3,4],[0,1,2,3,4],[0,1,4]]
*/

using System;
namespace CompetitiveProgramming.LeetCode.AllPathsFromSourcetoTarget
{
    public class Solution
    {
        public static IList<IList<int>> result = new List<IList<int>>();

        public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
        {
            FindAllPaths(graph, new List<int>(), 0);
            return result;
        }

        public static void FindAllPaths(int[][] graph, IList<int> currentList, int index)
        {
            currentList.Add(index);
            if(graph.Length == 0)
                return;

            if(index == graph.Length - 1)
            {
                int[] copyList = new int[currentList.Count()];
                currentList.CopyTo(copyList, 0);
                result.Add(copyList);
                return;
            }

            for(int i = 0; i < graph[index].Length; i++)
            {
                FindAllPaths(graph, currentList, graph[index][i]);
                currentList.RemoveAt(currentList.Count -1);
            }
        }
    }
}