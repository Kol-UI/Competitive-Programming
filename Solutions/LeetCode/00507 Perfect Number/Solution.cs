// Perfect Number
namespace CompetitiveProgramming.LeetCode.PerfectNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckPerfectNumber(int num)
    {
        if (num <= 1) return false;
        int sum = 1;
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0) sum += i;
        }
        return sum == num;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.CheckPerfectNumber(28), true),
            ResultTester.CheckResult<bool>(solution.CheckPerfectNumber(7), false)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Perfect Number");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}