// Maximum Weighted K-Edge Path
namespace CompetitiveProgramming.LeetCode.MaximumWeightedKEdgePath;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxWeight(int n, int[][] edges, int k, int t)
    {
        var adj = new List<Tuple<int, int>>[n];
        for (int i = 0; i < n; i++)
        {
            adj[i] = new List<Tuple<int, int>>();
        }

        foreach (var edge in edges)
        {
            int u = edge[0];
            int v = edge[1];
            int w = edge[2];
            adj[u].Add(Tuple.Create(v, w));
        }

        var dp = new HashSet<int>[k + 1][];
        for (int i = 0; i <= k; i++)
        {
            dp[i] = new HashSet<int>[n];
            for (int j = 0; j < n; j++)
            {
                dp[i][j] = new HashSet<int>();
            }
        }

        if (t > 0)
        {
            for (int i = 0; i < n; i++)
            {
                dp[0][i].Add(0);
            }
        }

        for (int step = 1; step <= k; step++)
        {
            for (int u = 0; u < n; u++)
            {
                if (dp[step - 1][u].Count == 0) continue;

                foreach (var edge in adj[u])
                {
                    int v = edge.Item1;
                    int w = edge.Item2;

                    foreach (int prevSum in dp[step - 1][u])
                    {
                        int currSum = prevSum + w;
                        if (currSum < t)
                        {
                            dp[step][v].Add(currSum);
                        }
                    }
                }
            }
        }

        int maxWeight = -1;
        for (int i = 0; i < n; i++)
        {
            foreach (int val in dp[k][i])
            {
                maxWeight = Math.Max(maxWeight, val);
            }
        }

        return maxWeight;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Weighted K-Edge Path");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}