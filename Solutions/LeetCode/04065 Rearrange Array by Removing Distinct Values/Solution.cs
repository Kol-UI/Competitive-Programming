// Rearrange Array by Removing Distinct Values
namespace CompetitiveProgramming.LeetCode.RearrangeArraybyRemovingDistinctValues;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] RearrangeArray(int[] nums) => nums.GroupBy(x => x).
        SelectMany((g, i) => g.Select((v, j) => (v, j))).
        OrderBy(x => x.j).
        ThenBy(x => x.v).
        Select(x => x.v).
        ToArray();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.RearrangeArray([3,1,3,2,1,3]), [1,2,3,1,3,3]),
            ResultTester.CheckResult<int[]>(solution.RearrangeArray([7,7,4,4,4]), [4,7,4,7,4]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rearrange Array by Removing Distinct Values");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}