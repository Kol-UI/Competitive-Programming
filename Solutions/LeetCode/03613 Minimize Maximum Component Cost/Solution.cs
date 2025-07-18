// Minimize Maximum Component Cost
namespace CompetitiveProgramming.LeetCode.MinimizeMaximumComponentCost;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinCost(int n, int[][] edges, int k)
    {
        var weights = new int[edges.Length + 1];
        weights[0] = 0;

        for (var i = 0; i < edges.Length; i++)
        {
            weights[i + 1] = edges[i][2];
        }

        Array.Sort(weights);

        var left = 0;
        var right = weights.Length;

        while (left < right)
        {
            var mid = left + (right - left) / 2;
            var tmp = weights[mid];

            if (Check(tmp, n, edges) <= k)
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return weights[right];
    }

    private int Check(int maxWeight, int n, int[][] edges)
    {
        var uf = new UnionFind(n);

        foreach (var edge in edges)
        {
            if (edge[2] <= maxWeight)
            {
                uf.Union(edge[0], edge[1]);
            }
        }

        var set = new HashSet<int>();

        for (var i = 0; i < n; i++)
        {
            set.Add(uf.Find(i));
        }

        return set.Count;
    }

    public class UnionFind
    {
        public UnionFind(int n)
        {
            Parent = new int[n];
            Size = new int[n];
            for (var i = 0; i < n; i++)
            {
                Parent[i] = i;
                Size[i] = 1;
            }
        }

        public int[] Parent;
        public int[] Size;

        public int Find(int x)
        {
            if (Parent[x] != x)
            {
                Parent[x] = Find(Parent[x]);
            }
            return Parent[x];
        }

        public void Union(int x, int y)
        {
            var rootX = Find(x);
            var rootY = Find(y);
            if (rootX != rootY)
            {
                if (Size[rootX] < Size[rootY])
                {
                    Parent[rootX] = rootY;
                    Size[rootY] += Size[rootX];
                }
                else
                {
                    Parent[rootY] = rootX;
                    Size[rootX] += Size[rootY];
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
        StyleHelper.Title("Minimize Maximum Component Cost");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}