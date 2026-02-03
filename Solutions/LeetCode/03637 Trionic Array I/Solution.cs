// Trionic Array I
namespace CompetitiveProgramming.LeetCode.TrionicArrayI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsTrionic(int[] nums)
    {
        if (nums[1] <= nums[0]) return false;
        int result = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1]) return false;
            if (result % 2 == 0 && nums[i] < nums[i - 1]) result++;
            if (result % 2 == 1 && nums[i] > nums[i - 1]) result++;
        }

        return result == 2;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.IsTrionic([1,3,5,4,2,6]), true),
            ResultTester.CheckResult<bool>(solution.IsTrionic([2,1,3]), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Trionic Array I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}