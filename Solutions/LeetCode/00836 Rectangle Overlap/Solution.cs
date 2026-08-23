// Rectangle Overlap
namespace CompetitiveProgramming.LeetCode.RectangleOverlap;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsRectangleOverlap(int[] rec1, int[] rec2)
    {
        return rec1[0] < rec2[2] && rec2[0] < rec1[2] && rec1[1] < rec2[3] && rec2[1] < rec1[3];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.IsRectangleOverlap([0,0,2,2], [1,1,3,3]), true),
            ResultTester.CheckResult<bool>(solution.IsRectangleOverlap([0,0,1,1], [1,0,2,1]), false),
            ResultTester.CheckResult<bool>(solution.IsRectangleOverlap([0,0,1,1], [2,2,3,3]), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rectangle Overlap");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}