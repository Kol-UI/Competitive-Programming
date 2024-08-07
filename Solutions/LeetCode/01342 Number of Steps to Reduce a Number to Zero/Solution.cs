﻿using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofStepstoReduceaNumbertoZero
{
	public class Solution
	{
        //Given an integer num, return the number of steps to reduce it to zero.

        //In one step, if the current number is even, you have to divide it by 2, otherwise, you have to subtract 1 from it.

        //Example 1:

        //Input: num = 14
        //Output: 6
        //Explanation: 
        //Step 1) 14 is even; divide by 2 and obtain 7. 
        //Step 2) 7 is odd; subtract 1 and obtain 6.
        //Step 3) 6 is even; divide by 2 and obtain 3. 
        //Step 4) 3 is odd; subtract 1 and obtain 2. 
        //Step 5) 2 is even; divide by 2 and obtain 1. 
        //Step 6) 1 is odd; subtract 1 and obtain 0.
        public static int NumberOfSteps(int num)
        {
            int numberOfSteps = 0;
            while (num != 0)
            {
                numberOfSteps += 1;
                if (num % 2 == 0)
                {
                    num = num / 2;
                }
                else
                {
                    num = num - 1;
                }
            }
            return numberOfSteps;
        }
    }

    public class Test
    {
        public static bool[] TestNumberofStepstoReduceaNumbertoZero()
        {
            // Case 1
            int Case1_NumberOfSteps = Solution.NumberOfSteps(14);

            // Case 2
            int Case2_NumberOfSteps = Solution.NumberOfSteps(8);

            // Case 3
            int Case3_NumberOfSteps = Solution.NumberOfSteps(123);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_NumberOfSteps, 6),
                ResultTester.CheckResult<int>(Case2_NumberOfSteps, Case2_NumberOfSteps),
                ResultTester.CheckResult<int>(Case3_NumberOfSteps, Case3_NumberOfSteps)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Steps to Reduce Number to Zero");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestNumberofStepstoReduceaNumbertoZero());
        }
    }
}