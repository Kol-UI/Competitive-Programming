// Points That Intersect With Cars




using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.PointsThatIntersectWithCars
{
    public class Solution
    {
        public static int CoveredPoints(int[][] nums)
        {
            var points = new HashSet<int>();
            
            foreach(var car in nums)
            {
                for(int i = car[0]; i <= car[1]; i++)
                {
                    points.Add(i);
                }
            }
            
            return points.Count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] nums1 = new int[][] { new int[] {3, 6}, new int[] {1, 5}, new int[] {4, 7} };
            int[][] nums2 = new int[][] { new int[] {1, 3}, new int[] {5, 8} };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CoveredPoints(nums1), 7),
                ResultTester.CheckResult<int>(Solution.CoveredPoints(nums2), 7),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2848");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}