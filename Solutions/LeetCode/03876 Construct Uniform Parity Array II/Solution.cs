// Construct Uniform Parity Array II
namespace CompetitiveProgramming.CodeForces.ConstructUniformParityArrayII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool UniformArray(int[] nums1)
    {
        var min = nums1[0];
        var hasOdd = false;

        foreach (var n in nums1)
        {
            min = Math.Min(min, n);
            if (!hasOdd && n % 2 != 0) hasOdd = true;
        }

        if (min % 2 != 0) return true;

        return !hasOdd;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.UniformArray([1,4,7]), true),
            ResultTester.CheckResult<bool>(solution.UniformArray([2,3]), false),
            ResultTester.CheckResult<bool>(solution.UniformArray([4,6]), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Construct Uniform Parity Array II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}