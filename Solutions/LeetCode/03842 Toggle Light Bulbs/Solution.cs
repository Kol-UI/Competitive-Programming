// Toggle Light Bulbs
namespace CompetitiveProgramming.LeetCode.ToggleLightBulbs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<int> ToggleLightBulbs(IList<int> bulbs) => bulbs
      .GroupBy(item => item)
      .Where(group => group.Count() % 2 != 0)
      .Select(item => item.Key)
      .OrderBy(item => item)
      .ToList();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<IList<int>>(solution.ToggleLightBulbs([10,30,20,10]), [20,30]),
            ResultTester.CheckResult<IList<int>>(solution.ToggleLightBulbs([100,100]), []),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Toggle Light Bulbs");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}