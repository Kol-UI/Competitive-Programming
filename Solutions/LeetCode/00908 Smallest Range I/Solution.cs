// Smallest Range I
namespace CompetitiveProgramming.LeetCode.SmallestRangeI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SmallestRangeI(int[] nums, int k)
    {
        var n = nums.Length;
        var min = nums[0];
        var max = nums[0];
        for(int i = 1;i < n; i++)
        {
            if(max < nums[i]) max = nums[i];
            if(min > nums[i]) min = nums[i];
        }
        return max - min > 2 * k ? max - min - 2 * k : 0;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.SmallestRangeI([1], 0), 0),
            ResultTester.CheckResult<int>(solution.SmallestRangeI([0,10], 2), 6),
            ResultTester.CheckResult<int>(solution.SmallestRangeI([1,3,6], 3), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Range I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}