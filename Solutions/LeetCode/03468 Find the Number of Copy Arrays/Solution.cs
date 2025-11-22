// Find the Number of Copy Arrays
namespace CompetitiveProgramming.LeetCode.FindtheNumberofCopyArrays;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

public class Solution
{
    public int CountArrays(int[] original, int[][] bounds)
    {
        var currBound = new long[] { bounds[0][0], bounds[0][1] };
        for (int i = 1; i < original.Length; i++)
        {
            currBound = Switch(currBound, original[i] - original[i - 1]);
            currBound = Join(currBound, bounds[i]);
            if (currBound == null) return 0;
        }
        var rs = (int)(currBound[1] - currBound[0] + 1);
        return rs;
    }

    private long[] Switch(long[] currBound, int diff)
    {
        currBound[0] += diff;
        currBound[1] += diff;
        return currBound;
    }

    private long[]? Join(long[] currBound, int[] bound)
    {
        var limit0 = Math.Max(currBound[0], bound[0]);
        var limit1 = Math.Min(currBound[1], bound[1]);
        return limit0 <= limit1 ? new[] { limit0, limit1 } : null;
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Number of Copy Arrays");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}