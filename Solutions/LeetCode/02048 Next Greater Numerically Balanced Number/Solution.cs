// Next Greater Numerically Balanced Number
namespace CompetitiveProgramming.LeetCode.NextGreaterNumericallyBalancedNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NextBeautifulNumber(int n)
    {
        for (int i = n + 1; i <= 1224444; i++)
        {
            if (IsBalance(i))
            {
                return i;
            }
        }
        return -1;
    }

    private bool IsBalance(int x)
    {
        int[] count = new int[10];
        while (x > 0)
        {
            count[x % 10]++;
            x /= 10;
        }
        for (int i = 0; i < 10; i++)
        {
            if (count[i] > 0 && count[i] != i)
            {
                return false;
            }
        }
        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.NextBeautifulNumber(1), 22),
            ResultTester.CheckResult<int>(solution.NextBeautifulNumber(1000), 1333),
            ResultTester.CheckResult<int>(solution.NextBeautifulNumber(3000), 3133),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Next Greater Numerically Balanced Number");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}