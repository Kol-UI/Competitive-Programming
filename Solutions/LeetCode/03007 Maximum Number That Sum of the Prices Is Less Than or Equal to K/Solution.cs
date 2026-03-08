// Maximum Number That Sum of the Prices Is Less Than or Equal to K
namespace CompetitiveProgramming.LeetCode.MaximumNumberThatSumofthePricesIsLessThanorEqualtoK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long FindMaximumNumber(long k, int x)
    {
        long result = 0;
        int count = 0;
        for (int i = 59; i >= 1; i--)
        {
            long c = Contribute(x, i) + count * (long)Math.Pow(2, i - 1);
            if (c <= k)
            {
                result += ((long)1 << (i - 1));
                k -= c;
                if (i % x == 0) count++;
            }
        }
        return result;
    }

    private long Contribute(int x, int b)
    {
        int p = (b - 1) / x;
        long c = 0;
        if (b >= 2) c += p * (long)Math.Pow(2, b - 2);
        if (b % x == 0) c += 1;
        return c;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.FindMaximumNumber(9, 1), 6),
            ResultTester.CheckResult<long>(solution.FindMaximumNumber(7, 2), 9),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number That Sum of the Prices Is Less Than or Equal to K");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}