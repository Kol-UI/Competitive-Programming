// Count Days Spent Together


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountDaysSpentTogether
{
    public class Solution
    {
        public static int CountDaysTogether(string arriveAlice, string leaveAlice, string arriveBob, string leaveBob)
        {
            return GetDaysOfYear(arriveAlice, leaveAlice).Where(x => GetDaysOfYear(arriveBob, leaveBob).Contains(x)).Count();
        }

        public static List<int> GetDaysOfYear(string start, string stop)
        {
            int startDayOfYear = DateTime.Parse("2001-" + start).DayOfYear;
            return Enumerable.Range(startDayOfYear, (DateTime.Parse("2001-" + stop).DayOfYear-startDayOfYear)+1).ToList();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountDaysTogether("08-15", "08-18", "08-16", "08-19"), 3),
                ResultTester.CheckResult<int>(Solution.CountDaysTogether("10-01", "10-31", "11-01", "12-31"), 0),
            };
            return results;
        }
    }
}