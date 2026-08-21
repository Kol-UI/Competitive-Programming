// Maximum Total Value of Covered Indices
namespace CompetitiveProgramming.LeetCode.MaximumTotalValueofCoveredIndices;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaxTotal(int[] nums, string s)
    {
        var dp0 = 0L;
        var dp1 = long.MinValue;

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (s[i] == '0')
            {
                dp0 = Math.Max(dp0, dp1 + nums[i]);
                dp1 = long.MinValue;
            }
            else
            {
                dp1 = Math.Max(dp0, dp1 + nums[i]);
                dp0 = dp0 + nums[i];
            }
        }

        return dp0;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MaxTotal([9,2,6,1], "0101"), 15),
            ResultTester.CheckResult<long>(solution.MaxTotal([5,1,4], "001"), 4),
            ResultTester.CheckResult<long>(solution.MaxTotal([9,3,5], "011"), 14),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Total Value of Covered Indices");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}