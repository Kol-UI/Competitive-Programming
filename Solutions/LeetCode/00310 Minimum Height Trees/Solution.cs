// Minimum Height Trees

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumHeightTrees
{
    public class Solution
    {
        public static IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            var node2Nodes = new HashSet<int>[n];

            for(var i = 0; i < n; i++) node2Nodes[i] = new HashSet<int>();

            foreach (var e in edges)
            {
                node2Nodes[e[0]].Add(e[1]);
                node2Nodes[e[1]].Add(e[0]);
            }

            var leaves = new Queue<int>();

            for (var i = 0; i < n; i++)
            {
                if (node2Nodes[i].Count <= 1) leaves.Enqueue(i);
            }

            for (var remains = n; leaves.Count != remains;)
            {
                remains -= leaves.Count;

                for (var count = leaves.Count; count > 0; count--)
                {
                    var i = leaves.Dequeue();

                    foreach (var r in node2Nodes[i])
                    {
                        node2Nodes[r].Remove(i);

                        if (node2Nodes[r].Count == 1)
                        {
                            leaves.Enqueue(r);
                        }
                    }
                }
            }

            return leaves.ToList();
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Height Trees");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}