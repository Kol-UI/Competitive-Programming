// Element Appearing More Than 25% In Sorted Array


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ElementAppearingMoreThanInSortedArray
{
    public class Solution
    {
        public static int FindSpecialInteger(int[] arr)
        {
            int windowSize = arr.Length / 4;

            for (int i = 0; i < arr.Length - windowSize; i++)
            {
                if (arr[i] == arr[i + windowSize])
                {
                    return arr[i];
                }
            }

            return arr[arr.Length - 1];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] arr1 = {1,2,2,6,6,6,6,7,10};
            int[] arr2 = {1,1};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindSpecialInteger(arr1), 6),
                ResultTester.CheckResult<int>(Solution.FindSpecialInteger(arr2), 1)
            };
            return results;
        }
    }
}