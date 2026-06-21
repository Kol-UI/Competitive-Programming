// Minimum Number of Seconds to Make Mountain Height Zero
namespace CompetitiveProgramming.LeetCode.MinimumNumberofSecondstoMakeMountainHeightZero;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MinNumberOfSeconds(int mountainHeight, int[] workerTimes)
    {
        int len = workerTimes.Length;
        if (len == 0)
            return 0;

        PriorityQueue<(long, long), long> pq = new();
        int height = mountainHeight;
        if (height == 0)
            return 0;
        foreach (int cur in workerTimes)
        {
            pq.Enqueue((cur, 1), cur);
        }

        while (pq.Count > 0 && pq.TryDequeue(out var cur, out long times))
        {
            long w = cur.Item1, freq = cur.Item2;
            if (--height == 0)
                return times;

            freq++;
            long nextTime = w * (freq + 1) * freq / 2;
            pq.Enqueue((w, freq), nextTime);
        }

        return -1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MinNumberOfSeconds(4, [2,1,1]), 3),
            ResultTester.CheckResult<long>(solution.MinNumberOfSeconds(10, [3,2,2,4]), 12),
            ResultTester.CheckResult<long>(solution.MinNumberOfSeconds(5, [1]), 15),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of Seconds to Make Mountain Height Zero");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}