// DFS of Graph

/*
You are given a connected undirected graph. Perform a Depth First Traversal of the graph.
Note: Use a recursive approach to find the DFS traversal of the graph starting from the 0th vertex from left to right according to the graph.


Example 1:

Input: V = 5 , adj = [[2,3,1] , [0], [0,4], [0], [2]]

Output: 0 2 4 3 1
Explanation: 
0 is connected to 2, 3, 1.
1 is connected to 0.
2 is connected to 0 and 4.
3 is connected to 0.
4 is connected to 2.
so starting from 0, it will go to 2 then 4,
and then 3 and 1.
Thus dfs will be 0 2 4 3 1.


Example 2:

Input: V = 4, adj = [[1,3], [2,0], [1], [0]]

Output: 0 1 2 3
Explanation:
0 is connected to 1 , 3.
1 is connected to 0, 2. 
2 is connected to 1.
3 is connected to 0. 
so starting from 0, it will go to 1 then 2
then back to 0 then 0 to 3
thus dfs will be 0 1 2 3. 

Your task:
You don't need to read input or print anything. Your task is to complete the function dfsOfGraph() which takes the integer V denoting the number of vertices and adjacency list as input parameters and returns a list containing the DFS traversal of the graph starting from the 0th vertex from left to right according to the graph.
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.DFSofGraph
{
    public class Graph
    {
        private int V;
        private List<List<int>> adj;

        public Graph(int V)
        {
            this.V = V;
            adj = new List<List<int>>();
            for (int i = 0; i < V; i++)
                adj.Add(new List<int>());
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
            adj[w].Add(v);
        }

        public List<int> DFS(int v)
        {
            List<int> result = new List<int>();
            bool[] visited = new bool[V];
            DFSUtil(v, visited, result);
            return result;
        }

        private void DFSUtil(int v, bool[] visited, List<int> result)
        {
            visited[v] = true;
            result.Add(v);
            foreach (int neighbor in adj[v])
            {
                if (!visited[neighbor])
                    DFSUtil(neighbor, visited, result);
            }
        }
    }

    public class Solution
    {
        // Function to return a list containing the DFS traversal of the graph.
        public List<int> dfsOfGraph(int V, List<List<int>> adj)
        {
            Graph graph = new Graph(V);
            for (int i = 0; i < adj.Count; i++)
            {
                foreach (int neighbor in adj[i])
                {
                    graph.AddEdge(i, neighbor);
                }
            }

            return graph.DFS(0);
        }
    }

    public class Test
    {
        public static bool[] TestDFSofGraph()
        {
            List<int> output1 = new List<int> { 0, 2, 4, 3, 1 };
            List<List<int>> adj1 = new List<List<int>>()
            {
                new List<int> { 2, 3, 1 },
                new List<int> { 0 },
                new List<int> { 0, 4 },
                new List<int> { 0 },
                new List<int> { 2 }
            };
            Solution solution1 = new Solution();
            List<int> result1 = solution1.dfsOfGraph(5, adj1);

            List<int> output2 = new List<int> { 0, 1, 2, 3 };
            List<List<int>> adj2 = new List<List<int>>()
            {
                new List<int> { 1, 3 },
                new List<int> { 2, 0 },
                new List<int> { 1 },
                new List<int> { 0 }
            };
            Solution solution2 = new Solution();
            List<int> result2 = solution2.dfsOfGraph(4, adj2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<List<int>>(result1, output1),
                ResultTester.CheckResult<List<int>>(result2, output2),
            };
            return results;
        }
    }
}