// Count Indices With Opposite Parity
namespace CompetitiveProgramming.LeetCode.CountIndicesWithOppositeParity;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] CountOppositeParity(int[] nums) => nums.Select((m, i) => nums.Skip(i).Count(n => m % 2 != n % 2)).ToArray();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.CountOppositeParity([1,2,3,4]), [2,1,1,0]),
            ResultTester.CheckResult<int[]>(solution.CountOppositeParity([1]), [0]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Indices With Opposite Parity");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}