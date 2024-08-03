// Restore the Array From Adjacent Pairs



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RestoretheArrayFromAdjacentPairs
{
    public class Solution
    {
        public static int[] RestoreArray(int[][] adjacentPairs)
        {
            Dictionary<int, List<int>> adjacencyMap = new();

            foreach (var pair in adjacentPairs)
            {
                if (!adjacencyMap.ContainsKey(pair[0]))
                {
                    adjacencyMap[pair[0]] = new List<int>();
                }
                if (!adjacencyMap.ContainsKey(pair[1]))
                {
                    adjacencyMap[pair[1]] = new List<int>();
                }

                adjacencyMap[pair[0]].Add(pair[1]);
                adjacencyMap[pair[1]].Add(pair[0]);
            }

            int startNode = adjacencyMap.Keys.First(key => adjacencyMap[key].Count == 1);

            List<int> result = new();
            HashSet<int> visited = new();
            DFS(startNode, adjacencyMap, visited, result);

            return result.ToArray();
        }

        private static void DFS(int node, Dictionary<int, List<int>> adjacencyMap, HashSet<int> visited, List<int> result)
        {
            visited.Add(node);
            result.Add(node);

            foreach (var neighbor in adjacencyMap[node])
            {
                if (!visited.Contains(neighbor))
                {
                    DFS(neighbor, adjacencyMap, visited, result);
                }
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] case1 = new int[][]
            {
                new int[] { 2, 1 },
                new int[] { 3, 4 },
                new int[] { 3, 2 }
            };

            int[][] case2 = new int[][]
            {
                new int[] { 4, -2 },
                new int[] { 1, 4 },
                new int[] { -3, 1 }
            };

            int[][] case3 = new int[][]
            {
                new int[] { 100000, -100000 },
            };

            int[] result1 = {1,2,3,4};
            int[] result2 = {-2,4,1,-3};
            int[] result3 = {100000,-100000};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.RestoreArray(case1), result1),
                ResultTester.CheckResult<int[]>(Solution.RestoreArray(case2), result2),
                ResultTester.CheckResult<int[]>(Solution.RestoreArray(case3), result3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Restore the Array From Adjacent Pairs");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}