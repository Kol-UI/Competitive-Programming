// Elevator Requests I
namespace CompetitiveProgramming.LeetCode.ElevatorRequestsI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int ElevatorRequests(int n, int[] requests) => requests.
        Aggregate((0, 0), (acum, curr) => (
            curr,
            acum.Item2 + Math.Abs(acum.Item1 - curr)
        ), m => m.Item2);
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.ElevatorRequests(5, [2,1,4,3]), 7),
            ResultTester.CheckResult<int>(solution.ElevatorRequests(3, [2,0,0]), 4),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Elevator Requests I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}