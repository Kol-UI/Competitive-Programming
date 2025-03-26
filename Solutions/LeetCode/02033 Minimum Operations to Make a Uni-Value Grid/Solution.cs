// Minimum Operations to Make a Uni-Value Grid
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoMakeaUniValueGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class TestSolution : BaseSolution
{
    public class Solution
    {
        public int MinOperations(int[][] grid, int x)
        {
            var l = new List<int>();
            foreach (int[] i in grid) l.AddRange(i);
            l = l.OrderBy(c => c).ToList();
            int median = l[l.Count / 2];
            int steps = 0;

            foreach (int val in l)
            {
                int diff = Math.Abs(val - median);
                if (diff % x != 0)
                    return -1;
                steps += diff / x;
            }
            return steps;
        }
    }

    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Make a Uni-Value Grid");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}