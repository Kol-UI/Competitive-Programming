// Stone Removal Game
namespace CompetitiveProgramming.LeetCode.StoneRemovalGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CanAliceWin(int n)
    {
        var startValue = 10;

        if (n < startValue)
            return false;

        var aliceTurn = true;
        n = n - startValue;

        while (n >= 0)
        {
            aliceTurn = aliceTurn ? false : true;

            startValue = startValue - 1;
            n = n - startValue;
        }

        return !aliceTurn;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.CanAliceWin(12), true),
            ResultTester.CheckResult<bool>(solution.CanAliceWin(1), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Stone Removal Game");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}