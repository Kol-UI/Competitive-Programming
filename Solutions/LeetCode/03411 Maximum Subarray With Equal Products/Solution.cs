// Maximum Subarray With Equal Products
namespace CompetitiveProgramming.LeetCode.MaximumSubarrayWithEqualProducts;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    static int[] divisors = InitDivisors(max: 10);

    public int MaxLength(int[] nums)
    {
        var left = 0;
        var hasDivisors = 0;
        var result = Math.Min(nums.Length, 2);

        for (var right = 0; right < nums.Length; right++)
        {
            var newDivisors = divisors[nums[right]];

            while ((newDivisors & hasDivisors) != 0)
                hasDivisors ^= divisors[nums[left++]];

            result = Math.Max(result, right - left + 1);
            hasDivisors |= newDivisors;
        }

        return result;
    }

    static int[] InitDivisors(int max)
    {
        var divisors = new int[max + 1];

        for (var i = 2; i <= max; i += 1)
        for (var j = i; j <= max; j += i)
        {
            divisors[j] |= 1 << i;
        }

        return divisors;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxLength([1,2,1,2,1,1,1]), 5),
            ResultTester.CheckResult<int>(solution.MaxLength([2,3,4,5,6]), 3),
            ResultTester.CheckResult<int>(solution.MaxLength([1,2,3,1,4,5,1]), 5),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Subarray With Equal Products");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}