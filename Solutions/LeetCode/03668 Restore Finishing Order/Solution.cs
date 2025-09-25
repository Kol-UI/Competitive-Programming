// Restore Finishing Order
namespace CompetitiveProgramming.LeetCode.RestoreFinishingOrder;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] RecoverOrder(int[] order, int[] friends) => order
        .Intersect(friends)
        .ToArray();
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Restore Finishing Order");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}