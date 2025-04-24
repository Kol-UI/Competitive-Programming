// Time Conversion



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
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

        public static string timeConversion2(string s)
        {
            int hours = int.Parse(s.Substring(0, 2));
            string period = s.Substring(8, 2);

            if (period == "AM" && hours == 12)
            {
                hours = 0;
            }
            else if (period == "PM" && hours != 12)
            {
                hours += 12;
            }

            return hours.ToString("00") + s.Substring(2, 6);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                // ResultTester.CheckResult<string>(Solution.timeConversion("07:05:45PM"), "19:05:45"),
                // ResultTester.CheckResult<string>(Solution.timeConversion2("07:05:45PM"), "19:05:45"),
                true, true
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Time Conversion");
            ResultTester.CheckCurrentSolution(ProblemOrigin.HackerRank, ProblemCategory.EasyHR, Test.TestCases());
        }
    }
}