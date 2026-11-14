// Score Validator
namespace CompetitiveProgramming.LeetCode.ScoreValidator;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] ScoreValidator(string[] events) => events.
    Aggregate(new int[] { 0, 0 }, (acum, curr) =>
    [
        acum[0] + (acum[1] < 10 ? curr != "W" ? int.TryParse(curr, out int value) ? value : 1 : 0 : 0),
        acum[1] + (acum[1] < 10 ? curr == "W" ? 1 : 0 : 0)
    ], m => m);
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.ScoreValidator(["1","4","W","6","WD"]), [12,1]),
            ResultTester.CheckResult<int[]>(solution.ScoreValidator(["WD","NB","0","4","4"]), [10,0]),
            ResultTester.CheckResult<int[]>(solution.ScoreValidator(["W","W","W","W","W","W","W","W","W","W","W"]), [0,10]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Score Validator");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}