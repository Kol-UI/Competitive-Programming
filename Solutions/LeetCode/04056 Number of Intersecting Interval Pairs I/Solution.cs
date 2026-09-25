// Number of Intersecting Interval Pairs I
namespace CompetitiveProgramming.LeetCode.NumberofIntersectingIntervalPairsI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountIntersectingIntervals(int[][] intervals)
    {
        Span<(int start, int end)> timeline = stackalloc (int,int)[128];
        int max = 0;
        foreach (var interval in intervals)
        {
            if (interval is [int start, int end])
            {
                timeline[start & 127].start++;
                timeline[(end + 1) & 127].end++;
                max = int.Max(max, end);
            }
        }

        int pairs = 0, count = 0;
        if ((uint)max < timeline.Length)
        {
            for (int i = 0; i <= max; i++)
            {
                (int start, int end) = timeline[i];
                count -= end;
                pairs += start * count + ((start * (start - 1)) >> 1);
                count += start;
            }
        }
        return pairs;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.CountIntersectingIntervals([[1,2],[2,3],[3,4]]), 2),
            ResultTester.CheckResult<int>(solution.CountIntersectingIntervals([[1,5],[2,4],[3,6]]), 3),
            ResultTester.CheckResult<int>(solution.CountIntersectingIntervals([[1,2],[3,4],[5,6]]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Intersecting Interval Pairs I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}