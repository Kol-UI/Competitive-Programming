// Build a Matrix With Conditions

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BuildaMatrixWithConditions
{
    /*
    public class Solution
    {
        class NodeState
        {
            public List<int> adj;
            public int Incount = 0;

            public NodeState()
            {
                adj = new();
            }

            public void Add(int node)
            {
                adj.Add(node);
            }
        }

        public int[][] BuildMatrix(int k, int[][] rowConditions, int[][] colConditions) {
            var rowOrder = TSort(rowConditions, k);
            if (!rowOrder.Any()) return [];
            var colOrder = TSort(colConditions, k);
            if (!colOrder.Any()) return [];

            int[][] res = new int[k][];

            for (int i = 0; i < res.Length; ++i)
            {
                res[i] = new int[k];
            }

            int row = 0, col = 0;

            while (row < res.Length)
            {
                col = colOrder.IndexOf(rowOrder[row]);

                res[row][col] = rowOrder[row] + 1;

                ++row;
            }

            return res;

        }

        void Print(IList<int> arr)
        {
            foreach (var num in arr)
            {
                Console.Write((num + 1) + " ");
            }
            Console.WriteLine();
        }
        IList<int> TSort(int[][] arr, int k)
        {
            NodeState[] graph = new NodeState[k];
            for (int i = 0; i < graph.Length; ++i)
            {
                graph[i] = new NodeState();
            }
            foreach (var c in arr)
            {
                graph[c[0] - 1].Add(c[1] - 1);
                graph[c[1] - 1].Incount++;
            }

            Queue<int> bfs = new();
            
            for (int i = 0; i < graph.Length; ++i)
            {
                if (graph[i].Incount == 0)
                {
                    bfs.Enqueue(i);
                }
            }
            List<int> res = new();
            while (bfs.Count > 0)
            {
                var top = bfs.Dequeue();

                res.Add(top);

                foreach (var node in graph[top].adj)
                {
                    if (--graph[node].Incount == 0)
                    {
                        bfs.Enqueue(node);
                    }
                }
            }

            if (res.Count != graph.Length) return [];

            return res;
        }
    }
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Build a Matrix With Conditions");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}