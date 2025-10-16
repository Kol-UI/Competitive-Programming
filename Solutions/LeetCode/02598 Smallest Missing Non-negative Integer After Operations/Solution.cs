// Smallest Missing Non-negative Integer After Operations
namespace CompetitiveProgramming.LeetCode.SmallestMissingNonnegativeIntegerAfterOperations;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FindSmallestInteger(int[] nums, int value)
    {
        var count = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            int rem = ((num % value) + value) % value;
            if (!count.ContainsKey(rem)) count[rem] = 0;
            count[rem]++;
        }
        int mex = 0;
        while (count.ContainsKey(mex % value) && count[mex % value] > 0)
        {
            count[mex % value]--;
            mex++;
        }
        return mex;
    }
};

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Missing Non-negative Integer After Operations");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}