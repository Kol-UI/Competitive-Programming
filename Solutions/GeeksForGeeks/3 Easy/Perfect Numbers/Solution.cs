// Perfect Numbers
namespace CompetitiveProgramming.GeeksForGeeks.Easy.PerfectNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

class Solution
{
    public bool isPerfect(int n)
    {
        if (n <= 1) return false;

        int sum = 1;
        for (int i = 2; (long)i * i <= n; i++)
        {
            if (n % i == 0)
            {
                sum += i;
                int other = n / i;
                if (other != i) sum += other;
            }
        }

        return sum == n;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.isPerfect(6), true),
            ResultTester.CheckResult<bool>(solution.isPerfect(10), false),
            ResultTester.CheckResult<bool>(solution.isPerfect(15), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Perfect Numbers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.EasyGFG, Test.TestCases());
    }
}