// Concatenate Non-Zero Digits and Multiply by Sum I
namespace CompetitiveProgramming.LeetCode.ConcatenateNonZeroDigitsandMultiplybySumI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long SumAndMultiply(int n)
    {
        var rs = 0L;
        var mult = 1;
        var sum = 0L;
        while (n > 0)
        {
            var digit = n % 10;
            if (digit != 0)
            {
                rs += digit * mult;
                mult *= 10;
                sum += digit;
            }
            n /= 10;
        }
        rs *= sum;
        return rs;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.SumAndMultiply(10203004), 12340),
            ResultTester.CheckResult<long>(solution.SumAndMultiply(1000), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Concatenate Non-Zero Digits and Multiply by Sum I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}