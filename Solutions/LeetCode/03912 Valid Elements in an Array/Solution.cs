// Valid Elements in an Array
namespace CompetitiveProgramming.LeetCode.ValidElementsinanArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public IList<int> FindValidElements(int[] nums) => nums
        .Select((m, i) => (m, i))
        .Where(m => m.i == 0 || m.i == nums.Length - 1 ||
            nums.Take(m.i).Max() < m.m || nums.Skip(m.i + 1).Max() < m.m)
        .Select(m => m.m)
        .ToList();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<IList<int>>(solution.FindValidElements([1,2,4,2,3,2]), [1,2,4,3,2]),
            ResultTester.CheckResult<IList<int>>(solution.FindValidElements([5,5,5,5]), [5,5]),
            ResultTester.CheckResult<IList<int>>(solution.FindValidElements([1]), [1]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Valid Elements in an Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}