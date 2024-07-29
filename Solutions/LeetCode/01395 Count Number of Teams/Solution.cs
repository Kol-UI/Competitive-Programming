// Count Number of Teams

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountNumberofTeams
{
    public class Solution
    {
        public int NumTeams(int[] ratings)
        {
            int totalTeams = 0;

            for (int first = 0; first < ratings.Length - 2; first++)
            {
                for (int second = first + 1; second < ratings.Length - 1; second++)
                {
                    for (int third = second + 1; third < ratings.Length; third++)
                    {
                        if (IsAscending(ratings[first], ratings[second], ratings[third]) ||
                            IsDescending(ratings[first], ratings[second], ratings[third]))
                        {
                            totalTeams++;
                        }
                    }
                }
            }

            return totalTeams;
        }

        private bool IsAscending(int a, int b, int c)
        {
            return a < b && b < c;
        }

        private bool IsDescending(int a, int b, int c)
        {
            return a > b && b > c;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Number of Teams");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}