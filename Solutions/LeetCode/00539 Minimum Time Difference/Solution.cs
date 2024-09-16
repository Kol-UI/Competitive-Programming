// Minimum Time Difference

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumTimeDifference
{
    public class Solution
    {
        public int FindMinDifference(IList<string> timePoints)
        {
            List<int> result = new List<int>();

            for(int i = 0; i < timePoints.Count; i++)
            {
                string[] time = timePoints[i].Split(":");

                int hour = int.Parse(time[0]);
                int minute = int.Parse(time[1]);

                result.Add(hour * 60 + minute);
            }

            result.Sort();

            int min = int.MaxValue;

            for(int i = 1; i < result.Count; i++)
            {
                min = Math.Min(min, result[i] - result[i - 1]); 
            }

            int cornerCase = result[0] + (1440 - result[result.Count - 1]);

            return Math.Min(min, cornerCase);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Time Difference");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}