// Concatenate Array With Reverse
namespace CompetitiveProgramming.LeetCode.ConcatenateArrayWithReverse;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] ConcatWithReverse(int[] nums)
    {
        var result = new int[nums.Length * 2];
        Array.Copy(nums, 0, result, 0, nums.Length);
        Array.Reverse(nums);
        Array.Copy(nums, 0, result, nums.Length, nums.Length);
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
            ResultTester.CheckResult<int[]>(solution.ConcatWithReverse([1,2,3]), [1,2,3,3,2,1]),
            ResultTester.CheckResult<int[]>(solution.ConcatWithReverse([1]), [1,1]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Concatenate Array With Reverse");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}