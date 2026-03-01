// Minimum Impossible OR
namespace CompetitiveProgramming.LeetCode.MinimumImpossibleOR;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinImpossibleOR(int[] nums)
    {
        for (int i = 0; i < 32; ++i)
        {
            int value = 1 << i;

            if (!nums.Contains(value))
                return value;
        }
        return -1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinImpossibleOR([2,1]), 4),
            ResultTester.CheckResult<int>(solution.MinImpossibleOR([5,3,2]), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Impossible OR");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}