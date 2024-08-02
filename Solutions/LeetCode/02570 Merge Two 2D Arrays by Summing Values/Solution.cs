// Merge Two 2D Arrays by Summing Values


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MergeTwoTwoDArraysbySummingValues
{
    public class Solution
    {
        public static int[][] MergeArrays(int[][] nums1, int[][] nums2) => nums1
            .Concat(nums2)
            .GroupBy(num => num[0])
            .Select(g => g.Aggregate(new int[2], (sum, item) => new [] { item[0], sum[1] + item[1] }))
            .OrderBy(item => item[0])
            .ToArray();
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] nums1_1 = new int[][]
            {
                new int[] {1, 2},
                new int[] {2, 3},
                new int[] {4, 5}
            };

            int[][] nums2_1 = new int[][]
            {
                new int[] {1, 4},
                new int[] {3, 2},
                new int[] {4, 1}
            };

            int[][] result1 = new int[][]
            {
                new int[] {1, 6},
                new int[] {2, 3},
                new int[] {3, 2},
                new int[] {4, 6},
            };

            int[][] nums1_2 = new int[][]
            {
                new int[] {2, 4},
                new int[] {3, 6},
                new int[] {5, 5}
            };

            int[][] nums2_2 = new int[][]
            {
                new int[] {1, 3},
                new int[] {4, 3}
            };

            int[][] result2 = new int[][]
            {
                new int[] {1, 3},
                new int[] {2, 4},
                new int[] {3, 6},
                new int[] {4, 3},
                new int[] {5, 5},
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(Solution.MergeArrays(nums1_1, nums2_1), result1),
                ResultTester.CheckResult<int[][]>(Solution.MergeArrays(nums1_2, nums1_2), Solution.MergeArrays(nums1_2, nums1_2)),
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2570");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}