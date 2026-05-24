// Smallest Divisible Digit Product I
namespace CompetitiveProgramming.LeetCode.SmallestDivisibleDigitProductI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SmallestNumber(int n, int t)
    {
        while (true)
        {
            if (IsProductDivisible(n, t))
            {
                return n;
            }
            n++;
        }
    }

    private static bool IsProductDivisible(int number, int t)
    {
        var product = 1;

        while (number > 0)
        {
            var digit = number % 10;
            product *= digit;
            number /= 10;
        }

        return product % t == 0;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.SmallestNumber(10, 2), 10),
            ResultTester.CheckResult<int>(solution.SmallestNumber(15, 3), 16),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Divisible Digit Product I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}