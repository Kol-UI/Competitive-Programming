// Maximum Containers on a Ship
namespace CompetitiveProgramming.LeetCode.MaximumContainersonaShip;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxContainers(int n, int w, int maxWeight)
    {
        var maxCell = n * n;
        while (maxCell * w > maxWeight)
        {
            maxCell--;
        }
        return maxCell;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Containers on a Ship");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}