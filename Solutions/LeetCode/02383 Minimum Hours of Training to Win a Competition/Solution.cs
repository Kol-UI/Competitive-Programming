// Minimum Hours of Training to Win a Competition


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumHoursofTrainingtoWinaCompetition
{
    public class Solution
    {
        public static int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience) 
        {
            var hours = Math.Max(0, energy.Sum() + 1 - initialEnergy);

            foreach(var current in experience)
            {
                var diff = initialExperience - current;

                diff = diff > 0 ? 0 : 1 - diff;

                hours += diff;

                initialExperience += diff + current;
            }

            return hours;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Hours of Training to Win a Competition");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}