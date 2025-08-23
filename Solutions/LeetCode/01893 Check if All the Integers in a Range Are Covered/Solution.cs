// Check if All the Integers in a Range Are Covered
namespace CompetitiveProgramming.LeetCode.CheckifAlltheIntegersinaRangeAreCovered;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsCovered(int[][] ranges, int left, int right)
    {
        SortedSet<int> ints = new(Enumerable.Range(left, right - left + 1));

        foreach (var range in ranges)
            ints.GetViewBetween(range[0], range[1]).RemoveWhere(_ => true);

        return !ints.Any();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        int[][] ranges1 = new int[][]
        {
            new int[] {1, 2},
            new int[] {3, 4},
            new int[] {5, 6}
        };

        int[][] ranges2 = new int[][]
        {
            new int[] {1, 10},
            new int[] {10, 20}
        };
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.IsCovered(ranges1, 2, 5), true),
            ResultTester.CheckResult<bool>(solution.IsCovered(ranges2, 21, 21), false)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if All the Integers in a Range Are Covered");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}