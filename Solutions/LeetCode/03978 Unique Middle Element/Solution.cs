// Unique Middle Element
namespace CompetitiveProgramming.LeetCode.UniqueMiddleElement;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsMiddleElementUnique(int[] nums)
    {
        if (nums == null || nums.Length == 0) return false;

        int midValue = nums[nums.Length / 2];
        return nums.Count(x => x == midValue) == 1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.IsMiddleElementUnique([1,2,3]), true),
            ResultTester.CheckResult<bool>(solution.IsMiddleElementUnique([1,2,2]), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Unique Middle Element");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}