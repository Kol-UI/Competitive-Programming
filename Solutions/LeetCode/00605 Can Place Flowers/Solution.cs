using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CanPlaceFlowers
{
    /*
        You have a long flowerbed in which some of the plots are planted, and some are not.
        However, flowers cannot be planted in adjacent plots.

        Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n,
        return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

        Example 1:
        Input: flowerbed = [1,0,0,0,1], n = 1
        Output: true

        Example 2:
        Input: flowerbed = [1,0,0,0,1], n = 2
        Output: false
    */

    public class Solution
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            for(int i = 0; i < flowerbed.Length ; i++)
            {
                if(flowerbed[i] == 1)
                    continue;
                int prev = i > 0?flowerbed[i-1]:0;
                int next = i < flowerbed.Length-1?flowerbed[i+1]:0;
                if(prev == 0 && next == 0)
                {
                    n--;
                    flowerbed[i]=1;
                }
            }
            return n <= 0;
        }
    }

    public class Test
    {
        public static bool[] TestCanPlaceFlowers()
        {
            // Case 1
            int[] arrayCase1_605 = { 1, 0, 0, 0, 1 };
            int intCase1_605 = 1;
            bool case1_605Result = LeetCode.CanPlaceFlowers.Solution.CanPlaceFlowers(arrayCase1_605, intCase1_605);

            // Case 2
            int[] arrayCase2_605 = { 1, 0, 0, 0, 1 };
            int intCase2_605 = 2;
            bool case2_605Result = LeetCode.CanPlaceFlowers.Solution.CanPlaceFlowers(arrayCase2_605, intCase2_605);

            // Case 3
            int[] arrayCase3_605 = { 1, 0, 0, 0, 0, 0, 1 };
            int intCase3_605 = 2;
            bool case3_605Result = LeetCode.CanPlaceFlowers.Solution.CanPlaceFlowers(arrayCase3_605, intCase3_605);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(case1_605Result, true),
                ResultTester.CheckResult<bool>(case2_605Result, false),
                ResultTester.CheckResult<bool>(case3_605Result, case3_605Result)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Can Place Flowers");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCanPlaceFlowers());
        }
    }
}