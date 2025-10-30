// Minimum Number of Increments on Subarrays to Form a Target Array
namespace CompetitiveProgramming.LeetCode.MinimumNumberofIncrementsonSubarraystoFormaTargetArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinNumberOperations(int[] target)
    {
        int x = target.Length;
        int result = target[0];

        for (int i = 1; i < x; ++i)
            result += Math.Max(target[i] - target[i - 1], 0);

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of Increments on Subarrays to Form a Target Array");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}