// Earliest Finish Time for Land and Water Rides I
namespace CompetitiveProgramming.LeetCode.EarliestFinishTimeforLandandWaterRidesI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) =>
        Math.Min(
            landStartTime.Select((m, i) => waterStartTime.Select((n, j) => m + landDuration[i] <= n ? n + waterDuration[j] : m + landDuration[i] + waterDuration[j]).Min()).Min(),
            waterStartTime.Select((n, j) => landStartTime.Select((m, i) => n + waterDuration[j] <= m ? m + landDuration[i] : n + waterDuration[j] + landDuration[i]).Min()).Min()
        );
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.EarliestFinishTime([2,8], [4,1], [6], [3]), 9),
            ResultTester.CheckResult<int>(solution.EarliestFinishTime([5], [3], [1], [10]), 14),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Earliest Finish Time for Land and Water Rides I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}