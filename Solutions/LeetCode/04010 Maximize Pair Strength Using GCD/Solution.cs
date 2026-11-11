// Maximize Pair Strength Using GCD
namespace CompetitiveProgramming.LeetCode.MaximizePairStrengthUsingGCD;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaxPairStrength(int[] nums)
    {
        long result = 0;
        for(var i = 0; i < nums.Length; i++)
        {
            for(var j = i + 1; j < nums.Length; j++)
            {
                var gcd = FindGCD(nums[i], nums[j]);
                result = Math.Max(result, (long)nums[i]*nums[j]/(gcd*gcd));
            }
        }
        return result;
    }

    private long FindGCD(long a, long b)
    {
        while (b != 0)
        {
            long temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MaxPairStrength([2,3,5]), 15),
            ResultTester.CheckResult<long>(solution.MaxPairStrength([4,6,8]), 12),
            ResultTester.CheckResult<long>(solution.MaxPairStrength([3,3]), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximize Pair Strength Using GCD");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}