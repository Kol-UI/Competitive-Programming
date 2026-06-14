// Teemo Attacking
namespace CompetitiveProgramming.LeetCode.TeemoAttacking;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FindPoisonedDuration(int[] timeSeries, int duration)
    {
        if (timeSeries.Length == 0 || duration == 0) return 0;

        int totalPoisonedTime = 0;

        for(int i = 1; i < timeSeries.Length; i++)
        {
            int timer = timeSeries[i] - timeSeries[i - 1];

            if(timer < duration)
            {
                totalPoisonedTime += timer;
            }
            else
            {
                totalPoisonedTime += duration;
            }
        }
        totalPoisonedTime += duration;
        return totalPoisonedTime;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.FindPoisonedDuration([1,4], 2), 4),
            ResultTester.CheckResult<int>(solution.FindPoisonedDuration([1,2], 2), 3)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Teemo Attacking");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}