// Minimum Sensors to Cover Grid
namespace CompetitiveProgramming.LeetCode.MinimumSensorstoCoverGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinSensors(int n, int m, int k)
    {
        int sideLen = 2 * k + 1;
        int sensorR = m / sideLen + (m % sideLen != 0 ? 1 : 0), sensorC = n / sideLen + (n % sideLen != 0 ? 1 : 0);
        return sensorR * sensorC;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinSensors(5, 5, 1), 4),
            ResultTester.CheckResult<int>(solution.MinSensors(2, 2, 2), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Sensors to Cover Grid");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}