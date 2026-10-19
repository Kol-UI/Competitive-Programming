// Ways to Make a Fair Array
namespace CompetitiveProgramming.LeetCode.WaystoMakeaFairArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int WaysToMakeFair(int[] nums)
    {
        Span<int> right = stackalloc int[2];
        Span<int> left = stackalloc int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            right[i & 1] += nums[i];
        }

        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            right[i & 1] -= nums[i];

            if (left[0] + right[1] == left[1] + right[0])
            {
                count++;
            }

            left[i & 1] += nums[i];
        }
        
        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.WaysToMakeFair([2,1,6,4]), 1),
            ResultTester.CheckResult<int>(solution.WaysToMakeFair([1,1,1]), 3),
            ResultTester.CheckResult<int>(solution.WaysToMakeFair([1,2,3]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ways to Make a Fair Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}