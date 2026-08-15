// Angle Between Hands of a Clock
namespace CompetitiveProgramming.LeetCode.AngleBetweenHandsofaClock;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public double AngleClock(int hour, int minutes)
    {
        double minuteAngle = (360.0 / 60) * minutes;
        
        double hourAngle = (360.0 / 12) * (hour % 12) + ((360.0) / (12 * 60)) * minutes;

        double diff = Math.Abs(hourAngle - minuteAngle);
        
        return Math.Min(diff, 360 - diff);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<double>(solution.AngleClock(12, 30), 165),
            ResultTester.CheckResult<double>(solution.AngleClock(3, 30), 75),
            ResultTester.CheckResult<double>(solution.AngleClock(3, 15), 7.5),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Angle Between Hands of a Clock");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}