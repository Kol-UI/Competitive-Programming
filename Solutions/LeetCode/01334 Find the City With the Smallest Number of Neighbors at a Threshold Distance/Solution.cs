// Find the City With the Smallest Number of Neighbors at a Threshold Distance

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheCityWiththeSmallestNumberofNeighborsataThresholdDistance
{
    public class Solution
    {
        public int FindTheCity(int n, int[][] edges, int distanceThreshold)
        {
            int[,] dist = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        dist[i, j] = 0;
                    }
                    else
                    {
                        dist[i, j] = int.MaxValue / 2;
                    }
                }
            }

            foreach (var edge in edges)
            {
                int from = edge[0];
                int to = edge[1];
                int weight = edge[2];
                dist[from, to] = weight;
                dist[to, from] = weight;
            }

            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (dist[i, k] + dist[k, j] < dist[i, j])
                        {
                            dist[i, j] = dist[i, k] + dist[k, j];
                        }
                    }
                }
            }

            int resultCity = -1;
            int minReachableCities = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int reachableCities = 0;
                for (int j = 0; j < n; j++)
                {
                    if (i != j && dist[i, j] <= distanceThreshold)
                    {
                        reachableCities++;
                    }
                }

                if (reachableCities < minReachableCities || (reachableCities == minReachableCities && i > resultCity))
                {
                    minReachableCities = reachableCities;
                    resultCity = i;
                }
            }

            return resultCity;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the City With the Smallest Number of Neighbors at a Threshold Distance");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}