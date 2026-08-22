// Traffic Signal Color
namespace CompetitiveProgramming.LeetCode.TrafficSignalColor;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string TrafficSignal(int timer)
    {
        string result = "";
        switch(timer)
        {
            case 0: result = "Green"; break;
            case 30: result = "Orange"; break;
            default:
                if(30 < timer && timer <= 90) result = "Red";
                else result = "Invalid";
                break;
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.TrafficSignal(60), "Red"),
            ResultTester.CheckResult<string>(solution.TrafficSignal(5), "Invalid"),
            ResultTester.CheckResult<string>(solution.TrafficSignal(30), "Orange"),
            ResultTester.CheckResult<string>(solution.TrafficSignal(0), "Green"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Traffic Signal Color");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}