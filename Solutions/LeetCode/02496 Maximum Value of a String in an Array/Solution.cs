﻿using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumValueofaStringinanArray
{
	public class Solution
	{

        //The value of an alphanumeric string can be defined as:
        //The numeric representation of the string in base 10, if it comprises of digits only.
        //The length of the string, otherwise.
        //Given an array strs of alphanumeric strings, return the maximum value of any string in strs.


        //Example 1:
        //Input: strs = ["alic3","bob","3","4","00000"]
        //Output: 5
        //Explanation: 
        //- "alic3" consists of both letters and digits, so its value is its length, i.e. 5.
        //- "bob" consists only of letters, so its value is also its length, i.e. 3.
        //- "3" consists only of digits, so its value is its numeric equivalent, i.e. 3.
        //- "4" also consists only of digits, so its value is 4.
        //- "00000" consists only of digits, so its value is 0.
        //Hence, the maximum value is 5, of "alic3".

        //Example 2:
        //Input: strs = ["1","01","001","0001"]
        //Output: 1
        //Explanation: 
        //Each string in the array has value 1. Hence, we return 1.

        public static int MaximumValue(string[] strs)
        {
            int max = 0;
            for (int i = 0; i < strs.Length; i++)
            {
                int localMax = 0;
                for (int k = 0; k < strs[i].Length; k++)
                {
                    if (strs[i][k] >= '0' && strs[i][k] <= '9')
                    {
                        localMax = localMax * 10 + (strs[i][k] - '0');
                    }
                    else
                    {
                        localMax = strs[i].Length;
                        break;
                    }
                }
                max = Math.Max(max, localMax);
            }
            return max;
        }

        // Linq One Line
        public static int MaximumValueLinq(string[] strs) => strs
            .Max(item => int.TryParse(item, out int value) ? value : item.Length);
    }


    public class Test
    {
        public static bool[] TestCases()
        {
            string[] strs1 = {"alic3","bob","3","4","00000"};
            string[] strs2 = {"1","01","001","0001"};

            int result1_2496 = Solution.MaximumValue(strs1);
            int result2_2496 = Solution.MaximumValue(strs2);
            int result1_2496Linq = Solution.MaximumValueLinq(strs1);
            int result2_2496Linq = Solution.MaximumValueLinq(strs2);

            int output1 = 5;
            int output2 = 1;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_2496, output1),
                ResultTester.CheckResult<int>(result2_2496, output2),
                ResultTester.CheckResult<int>(result1_2496Linq, output1),
                ResultTester.CheckResult<int>(result2_2496Linq, output2)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2496");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}