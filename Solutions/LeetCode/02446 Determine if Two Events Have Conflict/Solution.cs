// Determine if Two Events Have Conflict


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DetermineifTwoEventsHaveConflict
{
    public class Solution
    {
        public static bool HaveConflict(string[] event1, string[] event2) 
            => event1[0].CompareTo(event2[1]) <= 0 && event2[0].CompareTo(event1[1]) <= 0;
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.HaveConflict(new string[]{"01:15","02:00"}, new string[]{"02:00","03:00"}), true),
                ResultTester.CheckResult<bool>(Solution.HaveConflict(new string[]{"01:00","02:00"}, new string[]{"01:20","03:00"}), true),
                ResultTester.CheckResult<bool>(Solution.HaveConflict(new string[]{"10:00","11:00"}, new string[]{"14:00","15:00"}), false),
            };
            return results;
        }
    }
}