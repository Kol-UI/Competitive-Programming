// Time Conversion



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.TimeConversion
{
    public class Solution
    {
        public static string timeConversion(string s)
        {
            DateTime dateTime = DateTime.ParseExact(s, "hh:mm:sstt", null);
            return dateTime.ToString("HH:mm:ss");
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.timeConversion("07:05:45PM"), "19:05:45"),
            };
            return results;
        }
    }
}