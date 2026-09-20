// Circle and Rectangle Overlapping
namespace CompetitiveProgramming.LeetCode.CircleandRectangleOverlapping;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2)
    {
        var x = xCenter < x1 ? x1 : xCenter > x2 ? x2 : xCenter;
        var y = yCenter < y1 ? y1 : yCenter > y2 ? y2 : yCenter;
        
        return (x-xCenter) * (x-xCenter) + (y-yCenter) * (y-yCenter) <= radius * radius;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.CheckOverlap(1, 0, 0, 1, -1, 3, 1), true),
            ResultTester.CheckResult<bool>(solution.CheckOverlap(1, 1, 1, 1, -3, 2, -1), false),
            ResultTester.CheckResult<bool>(solution.CheckOverlap(1, 0, 0, -1, 0, 0, 1), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Circle and Rectangle Overlapping");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}