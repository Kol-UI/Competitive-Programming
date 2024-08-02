// Find the Distance Value Between Two Arrays

/*
Given two integer arrays arr1 and arr2, and the integer d, return the distance value between the two arrays.

The distance value is defined as the number of elements arr1[i] such that there is not any element arr2[j] where |arr1[i]-arr2[j]| <= d.

 

Example 1:

Input: arr1 = [4,5,8], arr2 = [10,9,1,8], d = 2
Output: 2
Explanation: 
For arr1[0]=4 we have: 
|4-10|=6 > d=2 
|4-9|=5 > d=2 
|4-1|=3 > d=2 
|4-8|=4 > d=2 
For arr1[1]=5 we have: 
|5-10|=5 > d=2 
|5-9|=4 > d=2 
|5-1|=4 > d=2 
|5-8|=3 > d=2
For arr1[2]=8 we have:
|8-10|=2 <= d=2
|8-9|=1 <= d=2
|8-1|=7 > d=2
|8-8|=0 <= d=2

Example 2:

Input: arr1 = [1,4,2,3], arr2 = [-4,-3,6,10,20,30], d = 3
Output: 2

Example 3:

Input: arr1 = [2,1,100,3], arr2 = [-5,-2,10,-3,7], d = 6
Output: 1
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheDistanceValueBetweenTwoArrays
{
    public class Solution
    {
        public static int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            int count = 0;
            Array.Sort(arr2);

            for(int i = 0; i < arr1.Length; i++)
            {
                bool b = true;
                int left = 0;
                int right = arr2.Length - 1;

                while(left <= right)
                {
                    int j = (left + right) / 2;
                    
                    if(Math.Abs(arr1[i] - arr2[j]) <= d)
                    {
                        b = false;
                        break; 
                    }

                    else if (arr1[i] > arr2[j]) left = j + 1;

                    else right = j - 1;
                }

                if(b) count++;
            }

            return count;
        }
    }

    public class Test
    {
        public static bool[] TestFindtheDistanceValueBetweenTwoArrays()
        {
            int[] arr1case1 = {4,5,8};
            int[] arr2case1 = {10,9,1,8};
            int dcase1 = 2;

            int[] arr1case2 = {1,4,2,3};
            int[] arr2case2 = {-4,-3,6,10,20,30};
            int dcase2 = 3;

            int[] arr1case3 = {2,1,100,3};
            int[] arr2case3 = {-5,-2,10,-3,7};
            int dcase3 = 6;

            int result1 = Solution.FindTheDistanceValue(arr1case1, arr2case1, dcase1);
            int result2 = Solution.FindTheDistanceValue(arr1case2, arr2case2, dcase2);
            int result3 = Solution.FindTheDistanceValue(arr1case3, arr2case3, dcase3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 2),
                ResultTester.CheckResult<int>(result2, 2),
                ResultTester.CheckResult<int>(result3, 1)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1385");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestFindtheDistanceValueBetweenTwoArrays());
        }
    }
}