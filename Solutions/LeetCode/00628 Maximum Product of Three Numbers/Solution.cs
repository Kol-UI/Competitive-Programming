// Maximum Product of Three Numbers
namespace CompetitiveProgramming.LeetCode.MaximumProductofThreeNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumProduct(int[] nums)
    {
       int max1, max2,max3, min1, min2;
       max1 = max2 = max3 = int.MinValue;
       min1 = min2 = int.MaxValue;
       foreach(var num in nums)
       {
            if (num >= max1)
            {
                max3 = max2;
                max2 = max1;
                max1 = num;
            }
            else if (num >= max2)
            {
                max3 = max2;
                max2 = num;
            }
            else if (num > max3)
                max3 = num;

            if (num <= min1)
            {
                min2 = min1;
                min1 = num;
            }
            else if (num <= min2)
                min2 = num;
       }
       return Math.Max(min1 * min2 * max1, max1 * max2 * max3);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaximumProduct([1,2,3]), 6),
            ResultTester.CheckResult<int>(solution.MaximumProduct([1,2,3,4]), 24),
            ResultTester.CheckResult<int>(solution.MaximumProduct([-1,-2,-3]), -6),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Product of Three Numbers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}