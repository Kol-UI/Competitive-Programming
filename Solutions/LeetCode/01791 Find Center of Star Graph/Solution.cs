// Find Center of Star Graph

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindCenterofStarGraph
{
    public class Solution
    {
        public int FindCenter(int[][] edges) 
        {
            int node1 = edges[0][0];
            int node2 = edges[0][1];

            if (node1 == edges[1][0] || node1 == edges[1][1])
            {
                return node1;
            }
            return node2;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Center of Star Graph");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}