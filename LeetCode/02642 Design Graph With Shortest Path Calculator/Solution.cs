// Design Graph With Shortest Path Calculator

/*
There is a directed weighted graph that consists of n nodes numbered from 0 to n - 1. The edges of the graph are initially represented by the given array edges where edges[i] = [fromi, toi, edgeCosti] meaning that there is an edge from fromi to toi with the cost edgeCosti.

Implement the Graph class:

Graph(int n, int[][] edges) initializes the object with n nodes and the given edges.
addEdge(int[] edge) adds an edge to the list of edges where edge = [from, to, edgeCost]. It is guaranteed that there is no edge between the two nodes before adding this one.
int shortestPath(int node1, int node2) returns the minimum cost of a path from node1 to node2. If no path exists, return -1. The cost of a path is the sum of the costs of the edges in the path.
 

Example 1:


Input
["Graph", "shortestPath", "shortestPath", "addEdge", "shortestPath"]
[[4, [[0, 2, 5], [0, 1, 2], [1, 2, 1], [3, 0, 3]]], [3, 2], [0, 3], [[1, 3, 4]], [0, 3]]
Output
[null, 6, -1, null, 6]

Explanation
Graph g = new Graph(4, [[0, 2, 5], [0, 1, 2], [1, 2, 1], [3, 0, 3]]);
g.shortestPath(3, 2); // return 6. The shortest path from 3 to 2 in the first diagram above is 3 -> 0 -> 1 -> 2 with a total cost of 3 + 2 + 1 = 6.
g.shortestPath(0, 3); // return -1. There is no path from 0 to 3.
g.addEdge([1, 3, 4]); // We add an edge from node 1 to node 3, and we get the second diagram above.
g.shortestPath(0, 3); // return 6. The shortest path from 0 to 3 now is 0 -> 1 -> 3 with a total cost of 2 + 4 = 6.

*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DesignGraphWithShortestPathCalculator
{
    public class Graph
    {
        List<List<KeyValuePair<int, int>>> adjList;

        public Graph(int n, int[][] edges)
        {
            adjList = new List<List<KeyValuePair<int, int>>>();
            for (int i = 0; i < n; i++)
            {
                adjList.Add(new List<KeyValuePair<int, int>>());
            }
            foreach (int[] e in edges)
            {
                adjList[e[0]].Add(new KeyValuePair<int, int>(e[1], e[2]));        
            }
        }
        
        public void AddEdge(int[] edge)
        {
            adjList[edge[0]].Add(new KeyValuePair<int, int>(edge[1], edge[2]));
        }
        
        public int ShortestPath(int node1, int node2)
        {
            int n = adjList.Count;
            var pq = new PriorityQueue<List<int>, List<int>>(Comparer<List<int>>.Create((a, b) => a[0].CompareTo(b[0])));

            int[] costForNode = new int[n];
            Array.Fill(costForNode, int.MaxValue);
            costForNode[node1] = 0;

            var root = new List<int>() { 0, node1 };
            pq.Enqueue(root, root);

            while (pq.Count > 0)
            {
                var curr = pq.Dequeue();
                int currCost = curr[0];
                int currNode = curr[1];

                if (currCost > costForNode[currNode])
                {
                    continue;
                }
                if (currNode == node2)
                {
                    return currCost;
                }

                foreach (var neighbor in adjList[currNode])
                {
                    int neighborNode = neighbor.Key;
                    int cost = neighbor.Value;
                    int newCost = currCost + cost;

                    if (newCost < costForNode[neighborNode])
                    {
                        costForNode[neighborNode] = newCost;
                        var newPath = new List<int>() { newCost, neighborNode };
                        pq.Enqueue(newPath, newPath);                    
                    }
                }
            }

            return -1;        
        }
    }

    /**
    * Your Graph object will be instantiated and called as such:
    * Graph obj = new Graph(n, edges);
    * obj.AddEdge(edge);
    * int param_2 = obj.ShortestPath(node1,node2);
    */
}