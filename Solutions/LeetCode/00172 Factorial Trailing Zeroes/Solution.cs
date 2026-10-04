// Factorial Trailing Zeroes
namespace CompetitiveProgramming.LeetCode.FactorialTrailingZeroes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int TrailingZeroes(int n)
    {
        int trailingZeroes = 0;

        while(n >= 5)
        {
            n /= 5;
            trailingZeroes += n;
        }

        return trailingZeroes;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.TrailingZeroes(3), 0),
            ResultTester.CheckResult<int>(solution.TrailingZeroes(5), 1),
            ResultTester.CheckResult<int>(solution.TrailingZeroes(0), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Factorial Trailing Zeroes");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}