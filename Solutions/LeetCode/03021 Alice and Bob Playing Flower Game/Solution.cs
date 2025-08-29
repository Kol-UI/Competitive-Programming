// Alice and Bob Playing Flower Game
namespace CompetitiveProgramming.LeetCode.AliceandBobPlayingFlowerGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long FlowerGame(int n, int m) => (long)m * n / 2;
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long>(solution.FlowerGame(3, 2), 3),
            ResultTester.CheckResult<long>(solution.FlowerGame(1, 1), 0)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Alice and Bob Playing Flower Game");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}