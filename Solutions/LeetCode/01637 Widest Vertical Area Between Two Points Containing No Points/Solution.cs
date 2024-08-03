// Widest Vertical Area Between Two Points Containing No Points



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.WidestVerticalAreaBetweenTwoPointsContainingNoPoints
{
    public class Solution
    {
        public static int MaxWidthOfVerticalArea(int[][] points)
        {
            var x = points.Select(p => p[0]).OrderBy(p => p);

            return x.Skip(1).Zip(x, (a, b) => a - b).Max();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] points1 = new int[][]
            {
                new int[] {8,7},
                new int[] {9,9},
                new int[] {7,4},
                new int[] {9,7},
            };

            int[][] points2 = new int[][]
            {
                new int[] {3,1},
                new int[] {9,0},
                new int[] {1,0},
                new int[] {1,4},
                new int[] {5,3},
                new int[] {8,8},
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxWidthOfVerticalArea(points1), 1),
                ResultTester.CheckResult<int>(Solution.MaxWidthOfVerticalArea(points2), 3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Widest Vertical Area Between Two Points Containing No Points");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}