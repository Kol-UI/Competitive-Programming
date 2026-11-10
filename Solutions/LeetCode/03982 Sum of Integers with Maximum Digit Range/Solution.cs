// Sum of Integers with Maximum Digit Range
namespace CompetitiveProgramming.LeetCode.SumofIntegerswithMaximumDigitRange;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxDigitRange(int[] nums)
    {
        Span<int> sums = stackalloc int[10];
        int maxRange = 0;
        foreach (int num in nums)
        {
            int n = num, min = int.MaxValue, max = int.MinValue;
            while (n != 0)
            {
                int digit = n % 10;
                n /= 10;
                min = int.Min(min, digit);
                max = int.Max(max, digit);
            }
            int range = max - min;
            maxRange = int.Max(maxRange, range);
            sums[range] += num;
        }
        return sums[maxRange];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxDigitRange([5724,111,350]), 6074),
            ResultTester.CheckResult<int>(solution.MaxDigitRange([90,900]), 990),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Integers with Maximum Digit Range");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}