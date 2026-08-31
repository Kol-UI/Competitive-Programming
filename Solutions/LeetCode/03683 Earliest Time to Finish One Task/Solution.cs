// Earliest Time to Finish One Task
namespace CompetitiveProgramming.LeetCode.EarliestTimetoFinishOneTask;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int EarliestTime(int[][] tasks) => tasks.Min(m => m.Sum());
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.EarliestTime([[1,6],[2,3]]), 5),
            ResultTester.CheckResult<int>(solution.EarliestTime([[100,100],[100,100],[100,100]]), 200),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Earliest Time to Finish One Task");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}