// Transform Array by Parity
namespace CompetitiveProgramming.LeetCode.TransformArraybyParity;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] TransformArray(int[] nums) => nums.Select(x => { return x % 2 == 0 ? 0 : 1; }).Order().ToArray();
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Transform Array by Parity");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}