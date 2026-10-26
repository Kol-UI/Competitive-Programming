// Maximum K to Sort a Permutation
namespace CompetitiveProgramming.LeetCode.MaximumKtoSortaPermutation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SortPermutation(int[] nums)
    {
        int n = nums.Length;
        int result = int.MaxValue;
        for (int i = 0; i < n; ++i)
        {
            if (nums[i] == i)
            {
                continue;
            }
            result &= nums[i];
        }
        return result == int.MaxValue ? 0 : result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.SortPermutation([0,3,2,1]), 1),
            ResultTester.CheckResult<int>(solution.SortPermutation([0,1,3,2]), 2),
            ResultTester.CheckResult<int>(solution.SortPermutation([3,2,1,0]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum K to Sort a Permutation");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}