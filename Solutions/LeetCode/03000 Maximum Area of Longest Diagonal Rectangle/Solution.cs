// Maximum Area of Longest Diagonal Rectangle

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumAreaofLongestDiagonalRectangle
{
    public class Solution
    {
        public static int AreaOfMaxDiagonal(int[][] dimensions)
        {
            double maxDiagonal = 0;
            var maxAreas = new List<int>();

            for (int i = 0; i < dimensions.Length; i++)
            {
                var diagonal = Math.Sqrt(Math.Pow(dimensions[i][0], 2) + Math.Pow(dimensions[i][1], 2));
                var area = dimensions[i][0] * dimensions[i][1];
                if (diagonal > maxDiagonal)
                {
                    maxAreas.Clear();
                    maxAreas.Add(area);
                    maxDiagonal = diagonal;
                }
                else if (diagonal == maxDiagonal)
                    maxAreas.Add(area);
            }

            return maxAreas.Max();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] dimensions1 = { new int[] { 9, 3 }, new int[] { 8, 6 } };
            int[][] dimensions2 = { new int[] { 3, 4 }, new int[] { 4, 3 } };
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.AreaOfMaxDiagonal(dimensions1), 48),
                ResultTester.CheckResult<int>(Solution.AreaOfMaxDiagonal(dimensions2), 12),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("3000");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}