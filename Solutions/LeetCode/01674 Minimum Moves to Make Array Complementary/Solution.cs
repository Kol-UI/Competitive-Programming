// Minimum Moves to Make Array Complementary
namespace CompetitiveProgramming.LeetCode.MinimumMovestoMakeArrayComplementary;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinMoves(int[] nums, int limit)
    {
        int n = nums.Length;
        int[] memo = new int[2*limit+2];
        int min = int.MaxValue;

        for(int i=0; i<=(n-1)/2; ++i)
        {
            int l = nums[i];
            int r = nums[n-1-i];

            memo[Math.Min(l,r)+1]--;
            memo[l+r]--;
            memo[l+r+1]++;
            memo[Math.Max(l,r)+limit+1]++;
        }

        int val = n;
        for(int i=2; i<=2*limit; ++i)
        {
            val += memo[i];
            min = Math.Min(val, min);
        }

        return min;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinMoves([1,2,4,3], 4), 1),
            ResultTester.CheckResult<int>(solution.MinMoves([1,2,2,1], 2), 2),
            ResultTester.CheckResult<int>(solution.MinMoves([1,2,1,2], 2), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Moves to Make Array Complementary");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}