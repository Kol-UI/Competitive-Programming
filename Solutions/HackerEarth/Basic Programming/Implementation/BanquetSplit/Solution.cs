// BanquetSplit
#nullable disable

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.BanquetSplit
{
    class BanquetSplit
    {
        static List<int>[] graph;
        static int[] heights, tin, tout;
        static int[,] up;
        static int timer, levels;

        static void DFS(int node, int parent = 0, int height = 0)
        {
            tin[node] = ++timer;
            up[node, 0] = parent;
            heights[node] = height++;
            for (int i = 1; i <= levels; i++)
                up[node, i] = up[up[node, i - 1], i - 1];
            foreach (var child in graph[node])
            {
                if (child != parent)
                    DFS(child, node, height);
            }
            tout[node] = ++timer;
        }

        static bool IsUpper(int a, int b)
        {
            return tin[a] <= tin[b] && tout[a] >= tout[b];
        }

        static int LCA(int a, int b)
        {
            for (int i = levels; i >= 0; i--)
            {
                if (!IsUpper(up[a, i], b))
                    a = up[a, i];
            }
            return up[a, 0];
        }

        //static void Main()
        static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine()!);
            while (t-- > 0)
            {
                int n = int.Parse(Console.ReadLine()!);
                graph = new List<int>[n];
                for (int i = 0; i < n; i++)
                    graph[i] = new List<int>();

                for (int i = 0; i < n - 1; i++)
                {
                    var edge = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                    int u = edge[0] - 1, v = edge[1] - 1;
                    graph[u].Add(v);
                    graph[v].Add(u);
                }

                timer = 0;
                levels = 1;
                while ((1 << levels) <= n)
                    levels++;

                heights = new int[n];
                tin = new int[n];
                tout = new int[n];
                up = new int[n, levels + 1];

                DFS(0);

                int q = int.Parse(Console.ReadLine()!);
                while (q-- > 0)
                {
                    var query = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                    int u = query[0] - 1, v = query[1] - 1;

                    if ((heights[u] & 1) != (heights[v] & 1))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                        Console.Write("1 ");
                        if (heights[u] > heights[v]) (u, v) = (v, u);

                        if (IsUpper(u, v))
                            Console.WriteLine(heights[v] - heights[u] + 1);
                        else
                        {
                            int lcaHeight = heights[LCA(u, v)] * 2;
                            Console.WriteLine(heights[u] + heights[v] - lcaHeight + 1);
                        }
                    }
                }
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("BanquetSplit");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}
#nullable enable