// Reschedule Meetings for Maximum Free Time I
namespace CompetitiveProgramming.LeetCode.RescheduleMeetingsforMaximumFreeTimeI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
    {
        var result = 0;
        var tmp = 0;

        for (var i = 0; i <= startTime.Length; i++)
        {
            tmp += CheckTargetFreeTime(i, eventTime, startTime, endTime);

            if (i < k)
                continue;

            result = Math.Max(result, tmp);

            tmp -= CheckTargetFreeTime(i - k, eventTime, startTime, endTime);
        }

        return result;
    }

    public int CheckTargetFreeTime(int targetFreeIndex, int eventTime, int[] startTime, int[] endTime)
    {
        if (targetFreeIndex == 0)
            return startTime[targetFreeIndex];

        if (targetFreeIndex == startTime.Length)
            return eventTime - endTime[^1];

        return startTime[targetFreeIndex] - endTime[targetFreeIndex - 1];
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reschedule Meetings for Maximum Free Time I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}