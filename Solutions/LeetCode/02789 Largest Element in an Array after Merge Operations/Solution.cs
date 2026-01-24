// Largest Element in an Array after Merge Operations
namespace CompetitiveProgramming.LeetCode.LargestElementinanArrayafterMergeOperations;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaxArrayValue(int[] nums)
    {
        long result = nums[^1];
        for (int i = nums.Length - 1; i > 0; i--)
        {
            if (nums[i - 1] <= result)
                result += nums[i - 1];
            else
                result = nums[i - 1];
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MaxArrayValue([2,3,7,9,3]), 21),
            ResultTester.CheckResult<long>(solution.MaxArrayValue([5,3,3]), 11),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Largest Element in an Array after Merge Operations");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}