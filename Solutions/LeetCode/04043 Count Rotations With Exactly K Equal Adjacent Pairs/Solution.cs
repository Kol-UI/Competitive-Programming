// Count Rotations With Exactly K Equal Adjacent Pairs
namespace CompetitiveProgramming.LeetCode.CountRotationsWithExactlyKEqualAdjacentPairs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountRotations(string s, int k)
    {
        var pairsCount = s[0] == s[s.Length - 1] ? 1 : 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1]) pairsCount++;
        }
        if (pairsCount == k)
        {
            return s.Length - pairsCount;
        }
        if (pairsCount - 1 == k)
        {
            return pairsCount;
        }
        return 0;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.CountRotations("aab", 1), 2),
            ResultTester.CheckResult<int>(solution.CountRotations("abca", 0), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Rotations With Exactly K Equal Adjacent Pairs");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}