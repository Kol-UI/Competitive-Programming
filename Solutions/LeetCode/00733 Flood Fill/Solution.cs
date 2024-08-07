// Flood Fill

/*
An image is represented by an m x n integer grid image where image[i][j] represents the pixel value of the image.

You are also given three integers sr, sc, and color. You should perform a flood fill on the image starting from the pixel image[sr][sc].

To perform a flood fill, consider the starting pixel, plus any pixels connected 4-directionally to the starting pixel of the same color as the starting pixel, plus any pixels connected 4-directionally to those pixels (also with the same color), and so on. Replace the color of all of the aforementioned pixels with color.

Return the modified image after performing the flood fill.


Example 1:


Input: image = [[1,1,1],[1,1,0],[1,0,1]], sr = 1, sc = 1, color = 2
Output: [[2,2,2],[2,2,0],[2,0,1]]
Explanation: From the center of the image with position (sr, sc) = (1, 1) (i.e., the red pixel), all pixels connected by a path of the same color as the starting pixel (i.e., the blue pixels) are colored with the new color.
Note the bottom corner is not colored 2, because it is not 4-directionally connected to the starting pixel.

Example 2:

Input: image = [[0,0,0],[0,0,0]], sr = 0, sc = 0, color = 0
Output: [[0,0,0],[0,0,0]]
Explanation: The starting pixel is already colored 0, so no changes are made to the image.
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FloodFill
{
    public class Solution
    {
        // DFS
        public static int[][] FloodFill(int[][] image, int sr, int sc, int color) 
        {
            if (image[sr][sc] != color)
            {
                Fill(image, sr, sc, image[sr][sc], color);
            }
            return image;
        }
        
        private static void Fill(int[][] image, int sr, int sc, int replacingColor, int newColor)
        {
            image[sr][sc] = newColor;

            if (sr > 0 && image[sr - 1][sc] == replacingColor)
            {
                Fill(image, sr - 1, sc, replacingColor, newColor);
            }
            if (sr < image.Length - 1 && image[sr + 1][sc] == replacingColor)
            {
                Fill(image, sr + 1, sc, replacingColor, newColor);
            }
            if (sc > 0 && image[sr][sc - 1] == replacingColor)
            {
                Fill(image, sr, sc - 1, replacingColor, newColor);
            }
            if (sc < image[sr].Length - 1 && image[sr][sc + 1] == replacingColor)
            {
                Fill(image, sr, sc + 1, replacingColor, newColor);
            }
        }
    }

    public class Test
    {
        public static bool[] TestFloodFill()
        {
            int[][] image1 = new int[][]
            {
                new int[] { 1, 1, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 0, 1 }
            };
            int sr1 = 1;
            int sc1 = 1;
            int color1 = 2;

            int[][] image2 = new int[][]
            {
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 }
            };
            int sr2 = 0;
            int sc2 = 0;
            int color2 = 0;

            int[][] result1 = Solution.FloodFill(image1, sr1, sc1, color1);
            int[][] result2 = Solution.FloodFill(image2, sr2, sc2, color2);

            int[][] array1 = new int[][]
            {
                new int[] {2, 2, 2},
                new int[] {2, 2, 0},
                new int[] {2, 0, 1}
            };

            int[][] array2 = new int[][]
            {
                new int[] {0, 0, 0},
                new int[] {0, 0, 0}
            };


            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[][]>(result1, array1),
                ResultTester.CheckResult<int[][]>(result2, array2)
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Flood Fill");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestFloodFill());
        }
    }
}