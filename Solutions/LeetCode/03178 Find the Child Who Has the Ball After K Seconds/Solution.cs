// Find the Child Who Has the Ball After K Seconds
namespace CompetitiveProgramming.LeetCode.FindtheChildWhoHastheBallAfterKSeconds;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumberOfChild(int n, int k)
    {
        int doubleSize = 2*(n-1);
        k %= doubleSize;
        if(k < n)
            return k;

        k -= (n-1);
        return n -1 -k;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.NumberOfChild(3, 5), 1),
            ResultTester.CheckResult<int>(solution.NumberOfChild(5, 6), 2),
            ResultTester.CheckResult<int>(solution.NumberOfChild(4, 4), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Child Who Has the Ball After K Seconds");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}