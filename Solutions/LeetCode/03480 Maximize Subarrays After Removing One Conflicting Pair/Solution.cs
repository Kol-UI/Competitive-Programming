// Maximize Subarrays After Removing One Conflicting Pair
namespace CompetitiveProgramming.LeetCode.MaximizeSubarraysAfterRemovingOneConflictingPair;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

class Solution
{
    public long MaxSubarrays(int n, int[][] conflictingPairs)
    {
        var right = Enumerable.Range(0, n + 1).Select(x => new List<int>()).ToArray();

        foreach (var x in conflictingPairs)
            right[Math.Max(x[0], x[1])].Add(Math.Min(x[0], x[1]));

        long ans = 0, add = 0;
        int maxLeft = 0, secondMaxLeft = 0;
        var imp = new long[n + 1];

        for (int r = 1; r <= n; r++)
        {
            foreach (int l in right[r])
                if (l > maxLeft)
                {
                    secondMaxLeft = maxLeft;
                    maxLeft = l;
                }
                else secondMaxLeft = Math.Max(secondMaxLeft, l);

            ans += r - maxLeft;
            imp[maxLeft] += maxLeft - secondMaxLeft;
            add = Math.Max(add, imp[maxLeft]);
        }
        return ans + add;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximize Subarrays After Removing One Conflicting Pair");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}