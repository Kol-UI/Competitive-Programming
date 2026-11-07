// Nearest Available Drone
namespace CompetitiveProgramming.LeetCode.NearestAvailableDrone;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NearestDrone(int[][] drones, int[] target) => drones.
        Select((m, i) => new { 
            index = i, 
            range = m[2], 
            distance = Math.Abs(m[0] - target[0]) + Math.Abs(m[1] - target[1])}).
        Where(m => m.distance <= m.range).
        OrderBy(m => m.distance).
        ThenBy(m => m.index).
        FirstOrDefault()?.index ?? -1;
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.NearestDrone([[0,0,8],[2,2,9]], [3,4]), 1),
            ResultTester.CheckResult<int>(solution.NearestDrone([[2,1,5],[4,4,5],[6,6,8]], [5,5]), 1),
            ResultTester.CheckResult<int>(solution.NearestDrone([[4,4,5]], [8,6]), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Nearest Available Drone");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}