// Minimum Levels to Gain More Points
namespace CompetitiveProgramming.LeetCode.MinimumLevelstoGainMorePoints;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumLevels(int[] possible)
    {
        int len = possible.Length;
        int maxSum = -1;

        int[] p = new int[len];
        p[0] = possible[0] == 1 ? 1 : -1;

        for (int i = 1; i < len; i++)
        {
            p[i] = p[i - 1] + (possible[i] == 1 ? 1 : -1);
        }

        for (int i = 0; i < len - 1; i++)
        {
            if (p[len - 1] < 2 * p[i])
                return i + 1;
        }

        return maxSum;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinimumLevels([1,0,1,0]), 1),
            ResultTester.CheckResult<int>(solution.MinimumLevels([1,1,1,1,1]), 3),
            ResultTester.CheckResult<int>(solution.MinimumLevels([0,0]), -1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Levels to Gain More Points");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}