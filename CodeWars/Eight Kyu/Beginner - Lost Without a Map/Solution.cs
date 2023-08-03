// Beginner - Lost Without a Map

/*
Given an array of integers, return a new array with each value doubled.

For example:

[1, 2, 3] --> [2, 4, 6]

*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.BeginnerLostWithoutaMap
{
    public class Solution
    {
        public static int[] Maps(int[] x)
        {
            int[] doubledArray = new int[x.Length];

                for (int i = 0; i < x.Length; i++)
                {
                    doubledArray[i] = x[i] * 2;
                }

                return doubledArray;
        }

        public static int[] MapsConvertAll(int[] x)
        {
            return Array.ConvertAll(x, n => n * 2);
        } 
    }

    public class Test
    {
        public static bool[] TestBeginnerLostWithoutaMap()
        {
            int[] case1 = {1, 2, 3};
            int[] case2 = {1, 2, 3};
            int[] case3 = {4, 1, 1, 1, 4};
            int[] case4 = {2, 2, 2, 2, 2, 2};
            int[] expected1 = {2, 4, 6};
            int[] expected2 = {2, 4, 6};
            int[] expected3 = {8, 2, 2, 2, 8};
            int[] expected4 = {4, 4, 4, 4, 4, 4};

            int[] result1 = Solution.Maps(case1);
            int[] result2 = Solution.Maps(case2);
            int[] result3 = Solution.Maps(case3);
            int[] result4 = Solution.Maps(case4);
            int[] result5 = Solution.MapsConvertAll(case1);
            int[] result6 = Solution.MapsConvertAll(case2);
            int[] result7 = Solution.MapsConvertAll(case3);
            int[] result8 = Solution.MapsConvertAll(case4);


            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2),
                ResultTester.CheckResult<int[]>(result3, expected3),
                ResultTester.CheckResult<int[]>(result4, expected4),
                ResultTester.CheckResult<int[]>(result5, expected1),
                ResultTester.CheckResult<int[]>(result6, expected2),
                ResultTester.CheckResult<int[]>(result7, expected3),
                ResultTester.CheckResult<int[]>(result8, expected4)
            };
            return results;
        }
    }
}