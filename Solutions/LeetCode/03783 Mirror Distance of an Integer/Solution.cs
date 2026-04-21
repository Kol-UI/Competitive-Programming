// Mirror Distance of an Integer
namespace CompetitiveProgramming.LeetCode.MirrorDistanceofanInteger;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MirrorDistance(int n)
    {
        return Math.Abs(n - Reverse(n));
    }

    private static int Reverse(int n)
    {
        var reverse = 0;

        while (n > 0)
        {
            reverse = reverse * 10 + n % 10;
            n /= 10;
        }

        return reverse;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MirrorDistance(25), 27),
            ResultTester.CheckResult<int>(solution.MirrorDistance(10), 9),
            ResultTester.CheckResult<int>(solution.MirrorDistance(7), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mirror Distance of an Integer");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}