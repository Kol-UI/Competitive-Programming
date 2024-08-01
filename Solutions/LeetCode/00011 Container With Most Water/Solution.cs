// Container With Most Water

/*
You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

Find two lines that together with the x-axis form a container, such that the container contains the most water.

Return the maximum amount of water a container can store.

Notice that you may not slant the container.

 

Example 1:


Input: height = [1,8,6,2,5,4,8,3,7]
Output: 49
Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.

Example 2:

Input: height = [1,1]
Output: 1
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ContainerWithMostWater
{
    public class Solution
    {
        // Two Pointers
        public static int MaxArea(int[] height)
        {
            var p1 = 0;
            var p2 = height.Length - 1;

            var max = (p2 - p1) * (height[p1] > height[p2] ? height[p2] : height[p1]);

            if (p2 == 1) return max;
            do
            {
                if (height[p2] > height[p1]) p1++;
                else p2--;
                var temp = (p2 - p1) * (height[p1] > height[p2] ? height[p2] : height[p1]);
                max = max > temp ? max : temp;
            } while (p2 - p1 != 1);

            return max;
        }
    }

    public class Test
    {
        public static bool[] TestContainerWithMostWater()
        {
            int[] height1 = {1,8,6,2,5,4,8,3,7};
            int[] height2 = {1,1};

            int result1 = LeetCode.ContainerWithMostWater.Solution.MaxArea(height1);
            int result2 = LeetCode.ContainerWithMostWater.Solution.MaxArea(height2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 49),
                ResultTester.CheckResult<int>(result2, 1)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Container With Most Water");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestContainerWithMostWater());
        }
    }
}