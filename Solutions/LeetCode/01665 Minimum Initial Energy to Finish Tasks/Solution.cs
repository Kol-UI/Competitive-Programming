// Minimum Initial Energy to Finish Tasks
namespace CompetitiveProgramming.LeetCode.MinimumInitialEnergytoFinishTasks;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumEffort(int[][] tasks)
    {
        Array.Sort(tasks,(a,b) => b[1] - b[0] - a[1] + a[0]);
        int n = tasks.Length, res = 0, cur = 0;
        for(int i = 0;i < n; i++)
        {
            int actual = tasks[i][0], minimum = tasks[i][1];
            int diff = Math.Max(minimum - cur,0);
            res += diff;
            cur += (diff - actual);
        }
        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinimumEffort([[1,2],[2,4],[4,8]]), 8),
            ResultTester.CheckResult<int>(solution.MinimumEffort([[1,3],[2,4],[10,11],[10,12],[8,9]]), 32),
            ResultTester.CheckResult<int>(solution.MinimumEffort([[1,7],[2,8],[3,9],[4,10],[5,11],[6,12]]), 27),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Initial Energy to Finish Tasks");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}