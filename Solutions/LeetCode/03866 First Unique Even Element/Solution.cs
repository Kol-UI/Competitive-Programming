// First Unique Even Element
namespace CompetitiveProgramming.LeetCode.FirstUniqueEvenElement;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FirstUniqueEven(int[] nums)
    {
        Span<int> count = stackalloc int[101];
        for (var i = 0; i < nums.Length; ++i)
            ++count[nums[i]];

        for (var i = 0; i < nums.Length; ++i)
            if (count[nums[i]] == 1 - (nums[i] & 1))
                return nums[i];

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
            ResultTester.CheckResult<int>(solution.FirstUniqueEven([3,4,2,5,4,6]), 2),
            ResultTester.CheckResult<int>(solution.FirstUniqueEven([4,4]), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("First Unique Even Element");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}