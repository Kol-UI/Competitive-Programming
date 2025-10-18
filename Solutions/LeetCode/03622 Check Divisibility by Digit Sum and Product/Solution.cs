// Check Divisibility by Digit Sum and Product
namespace CompetitiveProgramming.LeetCode.CheckDivisibilitybyDigitSumandProduct;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckDivisibility(int n)
    {
        int prod = 1, sum = 0, cur = n;
        while (cur > 0)
        {
            int rem = cur % 10;
            prod *= rem;
            sum += rem;
            cur /= 10;
        }

        return n % (sum + prod) == 0;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.CheckDivisibility(99), true),
            ResultTester.CheckResult<bool>(solution.CheckDivisibility(23), false)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check Divisibility by Digit Sum and Product");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}