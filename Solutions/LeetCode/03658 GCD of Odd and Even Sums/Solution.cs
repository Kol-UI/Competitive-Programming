// GCD of Odd and Even Sums
namespace CompetitiveProgramming.LeetCode.GCDofOddandEvenSums;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int GcdOfOddEvenSums(int n)
    {
        var oddSum = 0;
        var evenSum = 0;
        foreach (var i in Enumerable.Range(1, n))
        {
            evenSum += (i * 2);
            oddSum += ((i - 1) * 2 + 1);
        }
        return GCD(oddSum, evenSum);
    }

    private int GCD(int a, int b)
    {
        if (a > b)
        {
            var temp = b;
            b = a;
            a = temp;
        }
        while (a > 0)
        {
            var r = (int)(b % a);
            b = a;
            a = r;
        }
        return b;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.GcdOfOddEvenSums(4), 4),
            ResultTester.CheckResult<int>(solution.GcdOfOddEvenSums(5), 5),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("GCD of Odd and Even Sums");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}