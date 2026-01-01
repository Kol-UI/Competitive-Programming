// Minimum Operations to Make Array Sum Divisible by K
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoMakeArraySumDivisiblebyK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinOperations(int[] nums, int k) => nums.Sum() % k;
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinOperations([3,9,7], 5), 4),
            ResultTester.CheckResult<int>(solution.MinOperations([4,1,3], 4), 0),
            ResultTester.CheckResult<int>(solution.MinOperations([3,2], 6), 5),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Make Array Sum Divisible by K");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}