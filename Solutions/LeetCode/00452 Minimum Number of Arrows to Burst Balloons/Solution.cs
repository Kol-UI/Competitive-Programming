﻿using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofArrowstoBurstBalloons
{
    public class Solution
    {

        //There are some spherical balloons taped onto a flat wall that represents the XY-plane.The balloons are represented as a 2D integer array points where points[i] = [xstart, xend] denotes a balloon whose horizontal diameter stretches between xstart and xend.
        //You do not know the exact y-coordinates of the balloons.
        //Arrows can be shot up directly vertically (in the positive y-direction) from different points along the x-axis.
        //A balloon with xstart and xend is burst by an arrow shot at x if xstart <= x <= xend.
        //There is no limit to the number of arrows that can be shot.
        //A shot arrow keeps traveling up infinitely, bursting any balloons in its path.
        //Given the array points, return the minimum number of arrows that must be shot to burst all balloons.

        //Example 1:

        //Input: points = [[10, 16], [2,8], [1,6], [7,12]]
        //Output: 2
        //Explanation: The balloons can be burst by 2 arrows:
        //- Shoot an arrow at x = 6, bursting the balloons[2, 8] and[1, 6].
        //- Shoot an arrow at x = 11, bursting the balloons[10, 16] and[7, 12].

        //Example 2:

        //Input: points = [[1,2],[3,4],[5,6],[7,8]]
        //Output: 4
        //Explanation: One arrow needs to be shot for each balloon for a total of 4 arrows.

        //Example 3:


        //Input: points = [[1,2],[2,3],[3,4],[4,5]]
        //Output: 2
        //Explanation: The balloons can be burst by 2 arrows:
        //- Shoot an arrow at x = 2, bursting the balloons[1, 2] and[2, 3].
        //- Shoot an arrow at x = 4, bursting the balloons[3, 4] and[4, 5].

        // Merge 
        public static int FindMinArrowShots(int[][] points)
        {
            points = points.OrderBy(x => x[1]).ThenBy(x => x[0]).ToArray();
            int count = 0;
            for (int i = 0; i < points.Length; i++)
            {
                count++;
                int j = i + 1;
                while (j < points.Length && points[i][1] >= points[j][0])
                    j++;
                i = j - 1;
            }
            return count;
        }
    }

    public class Test
    {
        public static bool[] TestMinimumNumberofArrowstoBurstBalloons()
        {
            int[][] points1 = new int[][]
            {
                new int[] { 10, 16 },
                new int[] { 2, 8 },
                new int[] { 1, 6 },
                new int[] { 7, 12 }
            };

            int[][] points2 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 4 },
                new int[] { 5, 6 },
                new int[] { 7, 8 }
            };

            int[][] points3 = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 4, 5 }
            };

            int result1 = Solution.FindMinArrowShots(points1);
            int result2 = Solution.FindMinArrowShots(points2);
            int result3 = Solution.FindMinArrowShots(points3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 2),
                ResultTester.CheckResult<int>(result2, 4),
                ResultTester.CheckResult<int>(result3, 2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Arrows to Burst Balloons");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestMinimumNumberofArrowstoBurstBalloons());
        }
    }
}