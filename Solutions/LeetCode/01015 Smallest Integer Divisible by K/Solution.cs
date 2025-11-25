// Smallest Integer Divisible by K
namespace CompetitiveProgramming.LeetCode.SmallestIntegerDivisiblebyK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SmallestRepunitDivByK(int k)
    {
        if (k % 2 == 0 || k % 5 == 0) return -1;
        int rem = 0;
        for (int len = 1; len <= k; len++)
        {
            rem = (rem * 10 + 1) % k;
            if (rem == 0) return len;
        }
        return -1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.SmallestRepunitDivByK(1), 1),
            ResultTester.CheckResult<int>(solution.SmallestRepunitDivByK(2), -1),
            ResultTester.CheckResult<int>(solution.SmallestRepunitDivByK(3), 3)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Integer Divisible by K");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}