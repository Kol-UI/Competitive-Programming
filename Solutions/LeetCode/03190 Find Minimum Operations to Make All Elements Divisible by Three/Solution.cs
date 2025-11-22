// Find Minimum Operations to Make All Elements Divisible by Three
namespace CompetitiveProgramming.LeetCode.FindMinimumOperationstoMakeAllElementsDivisiblebyThree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumOperations(int[] nums)
    {
        return nums.Count(x => x % 3 != 0);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinimumOperations([1,2,3,4]), 3),
            ResultTester.CheckResult<int>(solution.MinimumOperations([3,6,9]), 0)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Minimum Operations to Make All Elements Divisible by Three");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}