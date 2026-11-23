// Exactly One Consecutive Set Bits Pair
namespace CompetitiveProgramming.LeetCode.ExactlyOneConsecutiveSetBitsPair;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool ConsecutiveSetBits(int n) => Convert.ToString(n, 2).Split("0", StringSplitOptions.RemoveEmptyEntries).Aggregate((HasTwo: false, Valid: true), (acc, m) => (   
            acc.HasTwo || m.Length == 2, 
            acc.Valid && (m.Length < 2 || (!acc.HasTwo && m.Length == 2))
        ), result => result.HasTwo && result.Valid);
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.ConsecutiveSetBits(6), true),
            ResultTester.CheckResult<bool>(solution.ConsecutiveSetBits(5), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Exactly One Consecutive Set Bits Pair");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}