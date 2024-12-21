// Maximum Number of K-Divisible Components

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNumberofKDivisibleComponents
{
    public class Solution
    {
        public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k)
        {
            List<int>[] graph = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<int>();
            }
            foreach (var edge in edges)
            {
                graph[edge[0]].Add(edge[1]);
                graph[edge[1]].Add(edge[0]);
            }

            int validComponents = 0;

            int DFS(int node, int parent)
            {
                int subtreeSum = values[node];
                foreach (var neighbor in graph[node])
                {
                    if (neighbor != parent)
                    {
                        subtreeSum += DFS(neighbor, node);
                    }
                }

                if (subtreeSum % k == 0)
                {
                    validComponents++;
                    return 0;
                }

                return subtreeSum % k;
            }

            DFS(0, -1);

            return validComponents;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            int n1 = 7;
            int[][] edges1 = new int[][] {
                new int[] {0, 1}, 
                new int[] {0, 2}, 
                new int[] {1, 3}, 
                new int[] {1, 4},
                new int[] {2, 5}, 
                new int[] {2, 6}
            };
            int[] values1 = new int[] {3,0,6,1,5,2,1};
            int k1 = 3;

            int n2 = 5;
            int[][] edges2 = new int[][] {
                new int[] {0, 2}, 
                new int[] {1, 2}, 
                new int[] {1, 3}, 
                new int[] {2, 4}
            };
            int[] values2 = new int[] {1,8,1,4,4};
            int k2 = 6;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MaxKDivisibleComponents(n1, edges1, values1, k1), 3),
                ResultTester.CheckResult<int>(solution.MaxKDivisibleComponents(n2, edges2, values2, k2), 2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of K-Divisible Components");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}