// Determine if a Cell Is Reachable at a Given Time

/*
You are given four integers sx, sy, fx, fy, and a non-negative integer t.

In an infinite 2D grid, you start at the cell (sx, sy). Each second, you must move to any of its adjacent cells.

Return true if you can reach cell (fx, fy) after exactly t seconds, or false otherwise.

A cell's adjacent cells are the 8 cells around it that share at least one corner with it. You can visit the same cell several times.

 

Example 1:


Input: sx = 2, sy = 4, fx = 7, fy = 7, t = 6
Output: true
Explanation: Starting at cell (2, 4), we can reach cell (7, 7) in exactly 6 seconds by going through the cells depicted in the picture above. 

Example 2:


Input: sx = 3, sy = 1, fx = 7, fy = 3, t = 3
Output: false
Explanation: Starting at cell (3, 1), it takes at least 4 seconds to reach cell (7, 3) by going through the cells depicted in the picture above. Hence, we cannot reach cell (7, 3) at the third second.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DetermineifaCellIsReachableataGivenTime
{
    public class Solution
    {
        public static bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
        {
            if (sx == fx  && sy == fy)
            {
                return t == 0 || t > 1;
            }

            int d1 = Math.Abs(sy - fy);
            int d2 = Math.Abs(sx - fx);

            int minStep = Math.Min(d1, d2) + Math.Abs(d1 - d2);

            return minStep <= t;
        }
    }
    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsReachableAtTime(2, 4, 7, 7, 6), true),
                ResultTester.CheckResult<bool>(Solution.IsReachableAtTime(3, 1, 7, 3, 3), false),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Determine if a Cell Is Reachable at a Given Time");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}