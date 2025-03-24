// Count Days Without Meetings
namespace CompetitiveProgramming.LeetCode.CountDaysWithoutMeetings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountDays(int days, int[][] meetings)
    {
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));

        int freeDays = 0;
        int lastEnd = 0; 

        foreach (var meeting in meetings)
        {
            int start = meeting[0];
            int end = meeting[1];
            if (start > lastEnd + 1)
            {
                freeDays += start - (lastEnd + 1);
            }

            lastEnd = Math.Max(lastEnd, end);
        }

        if (lastEnd < days)
        {
            freeDays += days - lastEnd;
        }

        return freeDays;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Days Without Meetings");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}