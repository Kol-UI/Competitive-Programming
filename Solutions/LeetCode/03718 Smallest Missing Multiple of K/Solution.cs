// Smallest Missing Multiple of K
namespace CompetitiveProgramming.LeetCode.SmallestMissingMultipleofK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MissingMultiple(int[] nums, int k) => Enumerable.Range(1, 200).
        Except(nums).
        Where(m => m % k == 0).
        FirstOrDefault();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MissingMultiple([8,2,3,4,6], 2), 10),
            ResultTester.CheckResult<int>(solution.MissingMultiple([1,4,7,10,15], 5), 5),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Missing Multiple of K");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}