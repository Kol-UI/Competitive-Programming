// Day of the Week

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DayoftheWeek
{
    public class Solution
    {
        public string DayOfTheWeek(int day, int month, int year)
        {
            DateTime dateTime = new DateTime(year, month, day);
            return dateTime.DayOfWeek.ToString(); 
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Day of the Week");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}