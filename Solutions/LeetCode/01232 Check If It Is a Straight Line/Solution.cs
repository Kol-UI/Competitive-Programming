// Check If It Is a Straight Line

/*
You are given an array coordinates, coordinates[i] = [x, y], where [x, y] represents the coordinate of a point. Check if these points make a straight line in the XY plane.



Example 1:

Input: coordinates = [[1,2],[2,3],[3,4],[4,5],[5,6],[6,7]]
Output: true

Example 2:

Input: coordinates = [[1,1],[2,2],[3,4],[4,5],[5,6],[7,7]]
Output: false
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CheckIfItIsaStraightLine
{
    public class Solution
    {
        public static bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.GetLength(0) <= 2) return true;
            for (int i = 2; i < coordinates.GetLength(0); i++)
            {
                if ((coordinates[i][0]-coordinates[i-1][0])*
                        (coordinates[i-1][1]-coordinates[i-2][1]) !=
                        (coordinates[i-1][0]-coordinates[i-2][0])*
                        (coordinates[i][1]-coordinates[i-1][1])) {
                    return false;
                }
            }
            return true;
        }
    }

    public class Test
    {
        public static bool[] TestCheckIfItIsaStraightLine()
        {
            int[][] coordinates1_1232 = new int[][]
            {
                new int[] { 1,2 },
                new int[] { 2,3 },
                new int[] { 3,4 },
                new int[] { 4,5 },
                new int[] { 5,6 },
                new int[] { 6,7 }
            };
            int[][] coordinates2_1232 = new int[][]
            {
                new int[] { 1,1 },
                new int[] { 2,2 },
                new int[] { 3,4 },
                new int[] { 4,5 },
                new int[] { 5,6 },
                new int[] { 7,7 }
            };

            bool result1 = Solution.CheckStraightLine(coordinates1_1232);
            bool result2 = Solution.CheckStraightLine(coordinates2_1232);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(result1, true),
                ResultTester.CheckResult<bool>(result2, false)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check If It Is a Straight Line");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCheckIfItIsaStraightLine());
        }
    }
}