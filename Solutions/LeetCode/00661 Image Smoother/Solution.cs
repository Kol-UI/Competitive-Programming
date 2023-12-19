// Image Smoother


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.ImageSmoother
{
    public class Solution
    {
        public static int[][] ImageSmoother(int[][] img)
        {
            int rows = img.Length;
            int cols = img[0].Length;

            int[][] result = new int[rows][];

            for (int i = 0; i < rows; ++i)
            {
                result[i] = new int[cols];

                for (int j = 0; j < cols; ++j)
                {
                    int totalSum = 0;
                    int count = 0;

                    for (int x = Math.Max(0, i - 1); x < Math.Min(rows, i + 2); ++x)
                    {
                        for (int y = Math.Max(0, j - 1); y < Math.Min(cols, j + 2); ++y)
                        {
                            totalSum += img[x][y];
                            count += 1;
                        }
                    }

                    result[i][j] = totalSum / count;
                }
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] img1 = new int[][] { new int[] { 1, 1, 1 }, new int[] { 1, 0, 1 }, new int[] { 1, 1, 1 } };
            int[][] result1 = new int[][] { new int[] { 0,0,0 }, new int[] { 0, 0, 0 }, new int[] { 0, 0, 0 } };

            int[][] img2 = new int[][] { new int[] { 100, 200, 100 }, new int[] { 200, 50, 200 }, new int[] { 100, 200, 100 } };
            int[][] result2 = new int[][] { new int[] { 137,141,137 }, new int[] { 141,138,141 }, new int[] { 137,141,137 } };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(Solution.ImageSmoother(img1), result1),
                ResultTester.CheckResult<int[][]>(Solution.ImageSmoother(img2), result2),
            };
            return results;
        }
    }
}