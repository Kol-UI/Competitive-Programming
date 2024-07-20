// Number of Days Between Two Dates

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofDaysBetweenTwoDates
{
    public class Solution
    {
        public int DaysBetweenDates(string date1, string date2)
        {
            return Math.Abs((DateTime.Parse(date2) - DateTime.Parse(date1)).Days);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Days Between Two Dates");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}