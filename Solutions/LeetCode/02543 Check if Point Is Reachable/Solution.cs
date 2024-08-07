﻿using System;
using System.Numerics;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CheckifPointIsReachable
{
    public class Solution
	{
        //There exists an infinitely large grid.You are currently at point (1, 1), and you need to reach the point(targetX, targetY) using a finite number of steps.

        //In one step, you can move from point (x, y) to any one of the following points:

        //(x, y - x)
        //(x - y, y)
        //(2 * x, y)
        //(x, 2 * y)
        //Given two integers targetX and targetY representing the X-coordinate and Y-coordinate of your final position, return true if you can reach the point from(1, 1) using some number of steps, and false otherwise.


        //Example 1:

        //Input: targetX = 6, targetY = 9
        //Output: false
        //Explanation: It is impossible to reach(6,9) from(1,1) using any sequence of moves, so false is returned.

        //Example 2:

        //Input: targetX = 4, targetY = 7
        //Output: true
        //Explanation: You can follow the path(1,1) -> (1,2) -> (1,4) -> (1,8) -> (1,7) -> (2,7) -> (4,7).

        public static bool IsReachable(int targetX, int targetY)
        {
            //int num = 0;
            BigInteger num = BigInteger.GreatestCommonDivisor(targetX, targetY);
            //num = GCD(targetX, targetY);
            BigInteger n;
            while (num % 2 == 0)
            {
                n = num;
            }
            if (num == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int case1_targetX = 6;
            int case1_targetY = 9;
            bool Case1_2543_Result = Solution.IsReachable(case1_targetX, case1_targetY);

            // Case 2
            int case2_targetX = 4;
            int case2_targetY = 7;
            bool Case2_2543_Result = Solution.IsReachable(case2_targetX, case2_targetY);

            bool output1 = false;
            bool output2 = true;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Case1_2543_Result, output1),
                ResultTester.CheckResult<bool>(Case2_2543_Result, output2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check if Point Is Reachable");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}