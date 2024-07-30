// Valid Boomerang

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ValidBoomerang
{
    public class Solution
    {
        public bool IsBoomerang(int[][] points)
        {
            if (points.Length != 3 || points.Any(point => point.Length != 2))
            {
                throw new ArgumentException("Invalid input");
            }

            int x1 = points[0][0], y1 = points[0][1];
            int x2 = points[1][0], y2 = points[1][1];
            int x3 = points[2][0], y3 = points[2][1];

            return (x3 - x1) * (y2 - y1) != (x2 - x1) * (y3 - y1);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Valid Boomerang");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}