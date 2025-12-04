// Count Collisions on a Road
namespace CompetitiveProgramming.LeetCode.CountCollisionsonaRoad;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountCollisions(string directions) => directions.TrimStart('L').TrimEnd('R').Count(c => c != 'S');
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.CountCollisions("RLRSLL"), 5),
            ResultTester.CheckResult<int>(solution.CountCollisions("LLRR"), 0),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Collisions on a Road");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}