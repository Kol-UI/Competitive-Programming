// Minimum Deletions to Make Array Sharp
namespace CompetitiveProgramming.LeetCode.MinimumDeletionstoMakeArraySharp;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinDeletions(int[] nums) => nums.Skip(1).
        Aggregate((nums[0], 0), (acum, curr) => (
            (acum.Item1 ^ curr) == 0 ? acum.Item1 : curr,
            acum.Item2 + ((acum.Item1 ^ curr) == 0 ? 1 : 0)
        ), m => m.Item2);
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinDeletions([1,1,2,2,2,3]), 3),
            ResultTester.CheckResult<int>(solution.MinDeletions([4,4,9,4]), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Deletions to Make Array Sharp");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}