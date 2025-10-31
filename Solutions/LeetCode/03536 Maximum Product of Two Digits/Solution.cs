// Maximum Product of Two Digits
namespace CompetitiveProgramming.LeetCode.MaximumProductofTwoDigits;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxProduct(int n)
    {
        int[] res = new int[2];

        while (n > 0)
        {
            int dig = n % 10;
            if (dig >= res[0])
            {
                res[1] = res[0];
                res[0] = dig;
            }
            else if (dig > res[1])
                res[1] = dig;

            n /= 10;
        }

        return res[0] * res[1];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MaxProduct(31), 3),
            ResultTester.CheckResult<int>(solution.MaxProduct(124), 8),
            ResultTester.CheckResult<int>(solution.MaxProduct(22), 4)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Product of Two Digits");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}