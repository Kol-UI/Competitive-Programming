// Check if Array Is Sorted and Rotated

namespace CompetitiveProgramming.LeetCode.CheckifArrayIsSortedandRotated;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool Check(int[] nums) => nums
        .Where((m, i) => m > nums[(i + 1) % nums.Length])
        .Count() <= 1;
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.Check(new int[]{3,4,5,1,2}), true),
            ResultTester.CheckResult<bool>(solution.Check(new int[]{2,1,3,4}), false),
            ResultTester.CheckResult<bool>(solution.Check(new int[]{1,2,3}), true),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if Array Is Sorted and Rotated");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}