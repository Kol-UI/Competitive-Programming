// Three Fibonacci Sum
namespace CompetitiveProgramming.LeetCode.ThreeFibonacciSum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool ThreeFibonacciSum(int n)
    {
        if ((n & 1) != 0)
            return false;
        n >>= 1;
        long x = 5L * n * n;
        return IsSquare(x + 4) || IsSquare(x - 4);
    }

    private bool IsSquare(long n)
    {
        long x = 0;
        for (long b = 1L << 29; b != 0; b >>= 1)
        {
            long y = x | b;
            if (y * y <= n)
            {
                if (y * y == n)
                    return true;
                x = y;
            }
        }
        return false;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.ThreeFibonacciSum(16), true),
            ResultTester.CheckResult<bool>(solution.ThreeFibonacciSum(8), false),
            ResultTester.CheckResult<bool>(solution.ThreeFibonacciSum(2), true),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Three Fibonacci Sum");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}