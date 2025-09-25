// Minimum Operations to Equalize Array
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoEqualizeArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinOperations(int[] nums) => nums.Distinct().Count() > 1 ? 1 : 0;
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Equalize Array");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}