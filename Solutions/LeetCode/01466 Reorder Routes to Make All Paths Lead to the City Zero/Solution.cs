using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ReorderRoutestoMakeAllPathsLeadtotheCityZero
{
    public class Solution
	{
        // There are n cities numbered from 0 to n - 1 and n - 1 roads such that there is only one way to travel between two different cities (this network form a tree).
        // Last year, The ministry of transport decided to orient the roads in one direction because they are too narrow.
        // Roads are represented by connections where connections[i] = [ai, bi] represents a road from city ai to city bi.
        // This year, there will be a big event in the capital (city 0), and many people want to travel to this city.
        // Your task consists of reorienting some roads such that each city can visit the city 0. Return the minimum number of edges changed.
        // It's guaranteed that each city can reach city 0 after reorder.

        // Example 1:
        // Input: n = 6, connections = [[0,1],[1,3],[2,3],[4,0],[4,5]]
        // Output: 3
        // Explanation: Change the direction of edges show in red such that each node can reach the node 0 (capital).
        
        // Example 2:
        // Input: n = 5, connections = [[1,0],[1,2],[3,2],[3,4]]
        // Output: 2
        // Explanation: Change the direction of edges show in red such that each node can reach the node 0 (capital).
        
        // Example 3:
        // Input: n = 3, connections = [[1,0],[2,0]]
        // Output: 0

        private static readonly Dictionary<int, List<(int city, bool direction)>> _graph = new();
        private static readonly HashSet<int> _visited = new();
        private static int _result;

        public static int MinReorder(int n, int[][] connections)
        {
            foreach (var connection in connections)
            {
                var cityA = connection[0];
                var cityB = connection[1];

                _graph[cityA] = _graph.GetValueOrDefault(cityA, new List<(int, bool)>());
                _graph[cityA].Add((cityB, true));

                _graph[cityB] = _graph.GetValueOrDefault(cityB, new List<(int, bool)>());
                _graph[cityB].Add((cityA, false));
            }
            
            dfs(0);

            return _result;
        }

        private static void dfs(int city)
        {
            _visited.Add(city);

            foreach (var (node, direction) in _graph[city])
            {
                if (_visited.Contains(node)) continue;

                if (direction)
                {
                    ++_result;
                }

                dfs(node);
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[][] connections1466Case1 = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 1, 3 },
                new int[] { 2, 3 },
                new int[] { 4, 0 },
                new int[] { 4, 5 }
            };
            int n1466Case1 = 6;
            int result1466Case1 = Solution.MinReorder(n1466Case1, connections1466Case1);

            // Case 2
            int[][] connections1466Case2 = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 1, 2 },
                new int[] { 3, 2 },
                new int[] { 3, 4 }
            };
            int n1466Case2 = 5;
            int result1466Case2 = Solution.MinReorder(n1466Case2, connections1466Case2);

            // Case 3
            int[][] connections1466Case3 = new int[][]
            {
                new int[] { 1, 0 },
                new int[] { 2, 0 }
            };
            int n1466Case3 = 3;
            int result1466Case3 = Solution.MinReorder(n1466Case3, connections1466Case3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1466Case1, 3),
                ResultTester.CheckResult<int>(result1466Case2, 3),
                ResultTester.CheckResult<int>(result1466Case3, 3)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Reorder Routes to Make All Paths Lead to the City Zero");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}