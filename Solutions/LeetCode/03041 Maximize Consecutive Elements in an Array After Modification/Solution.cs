// Maximize Consecutive Elements in an Array After Modification
namespace CompetitiveProgramming.LeetCode.MaximizeConsecutiveElementsinanArrayAfterModification;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxSelectedElements(int[] nums)
    {
        Array.Sort(nums);
        var dp = new Dictionary<int, int>();
        int ans = 0;
        foreach (int x in nums)
        {
            dp.TryGetValue(x - 1, out int prev);
            dp.TryGetValue(x, out int curr);
            dp.TryGetValue(x + 1, out int next);
            dp[x + 1] = Math.Max(next, curr + 1);
            dp[x] = Math.Max(curr, prev + 1);
            ans = Math.Max(ans, Math.Max(dp[x], dp[x + 1]));
        }
        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxSelectedElements([2,1,5,1,1]), 3),
            ResultTester.CheckResult<int>(solution.MaxSelectedElements([1,4,7,10]), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximize Consecutive Elements in an Array After Modification");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}