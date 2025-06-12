// Maximum Difference Between Adjacent Elements in a Circular Array
namespace CompetitiveProgramming.LeetCode.MaximumDifferenceBetweenAdjacentElementsinaCircularArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxAdjacentDistance(int[] nums)
    {
        int n = nums.Length - 1;
        int max = Math.Abs(nums[n] - nums[0]);

        for (int i = 0; i < n; i++)
        {            
            max = Math.Max(Math.Abs(nums[i] - nums[i + 1]), max);
        }

        return max;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MaxAdjacentDistance(new int[]{1,2,4}), 3),
            ResultTester.CheckResult<int>(solution.MaxAdjacentDistance(new int[]{-5,-10,-5}), 5)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Difference Between Adjacent Elements in a Circular Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}