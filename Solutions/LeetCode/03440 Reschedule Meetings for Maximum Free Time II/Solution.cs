// Reschedule Meetings for Maximum Free Time II
namespace CompetitiveProgramming.LeetCode.RescheduleMeetingsforMaximumFreeTimeII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
    {
        var max = 0;
        var n = startTime.Length;
        var result = 0;
        for(int i = 0; i < n; i++)
        {
            var left = i > 0 ? endTime[i-1] : 0;
            var right = i == n - 1 ? eventTime : startTime[i + 1];
            var meeting = endTime[i] - startTime[i];
            if(max >= meeting)
            {
                result = Math.Max(result, right - left);
            }
            else
            {
                result = Math.Max(result, right - left - meeting);
            }
            max = Math.Max(max, startTime[i] - left);
        }
        max = 0;
        for(int i = n -1; i >= 0; i--)
        {
            var left = i > 0 ? endTime[i-1] : 0;
            var right = i == n - 1 ? eventTime : startTime[i + 1];
            var meeting = endTime[i] - startTime[i];
            if(max >= meeting)
            {
                result = Math.Max(result, right - left);
            }
            else
            {
                result = Math.Max(result, right - left - meeting);
            }
            max = Math.Max(max, right - endTime[i]);
        }


        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reschedule Meetings for Maximum Free Time II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}