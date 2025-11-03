// Properties Graph
namespace CompetitiveProgramming.LeetCode.PropertiesGraph;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8618

public class Solution
{
    private int[] parent;

    private bool IsValidComponent(HashSet<int> set1, HashSet<int> set2, int threshold)
    {
        if (set1.Count < threshold || set2.Count < threshold) return false;

        int commonCount = set1.Count(set2.Contains);
        return commonCount >= threshold;
    }

    private int FindParent(int node)
    {
        if (parent[node] != node)
        {
            parent[node] = FindParent(parent[node]);
        }
        return parent[node];
    }

    private void UnionNodes(int node1, int node2)
    {
        int parent1 = FindParent(node1);
        int parent2 = FindParent(node2);
        parent[parent1] = parent2;
    }

    public int NumberOfComponents(int[][] properties, int k)
    {
        int componentCount = properties.Length;
        parent = Enumerable.Range(0, componentCount).ToArray();

        List<HashSet<int>> propertySets = properties
            .Select(prop => prop.ToHashSet())
            .ToList();

        for (int i = 0; i < componentCount; i++)
        {
            for (int j = i + 1; j < componentCount; j++)
            {
                if (IsValidComponent(propertySets[i], propertySets[j], k))
                {
                    UnionNodes(i, j);
                }
            }
        }

        HashSet<int> uniqueParents = new HashSet<int>();
        for (int i = 0; i < componentCount; i++)
        {
            uniqueParents.Add(FindParent(i));
        }

        return uniqueParents.Count;
    }
}
#pragma warning restore CS8618

public class Test
{
    public static bool[] TestCases()
    {
        int[][] properties1 = new int[][]
        {
            new int[] {1, 2},
            new int[] {1, 1},
            new int[] {3, 4},
            new int[] {4, 5},
            new int[] {5, 6},
            new int[] {7, 7}
        };
        int k1 = 1;

        int[][] properties2 = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {2, 3, 4},
            new int[] {4, 3, 5}
        };
        int k2 = 2;

        int[][] properties3 = new int[][]
        {
            new int[] {1, 1},
            new int[] {1, 1}
        };
        int k3 = 2;

        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.NumberOfComponents(properties1, k1), 3),
            ResultTester.CheckResult<int>(solution.NumberOfComponents(properties2, k2), 1),
            ResultTester.CheckResult<int>(solution.NumberOfComponents(properties3, k3), 2)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Properties Graph");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}