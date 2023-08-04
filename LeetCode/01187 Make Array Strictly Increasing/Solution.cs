// Make Array Strictly Increasing

/*
Given two integer arrays arr1 and arr2, return the minimum number of operations (possibly zero) needed to make arr1 strictly increasing.

In one operation, you can choose two indices 0 <= i < arr1.length and 0 <= j < arr2.length and do the assignment arr1[i] = arr2[j].

If there is no way to make arr1 strictly increasing, return -1.

 

Example 1:

Input: arr1 = [1,5,3,6,7], arr2 = [1,3,2,4]
Output: 1
Explanation: Replace 5 with 2, then arr1 = [1, 2, 3, 6, 7].

Example 2:

Input: arr1 = [1,5,3,6,7], arr2 = [4,3,1]
Output: 2
Explanation: Replace 5 with 3 and then replace 3 with 4. arr1 = [1, 3, 4, 6, 7].

Example 3:

Input: arr1 = [1,5,3,6,7], arr2 = [1,6,3,3]
Output: -1
Explanation: You can't make arr1 strictly increasing.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MakeArrayStrictlyIncreasing
{
    public class Solution
    {
        static Dictionary<(int,int), int> ?dp; // nullable
        
        public static int MakeArrayIncreasing(int[] arr1, int[] arr2)
        {
            int n1 = arr1.Length;
            int n2 = arr2.Length;
            dp = new();
            Array.Sort(arr2);

            var minReplacements = Helper(arr1, arr2, 0, 0, -1);
            return minReplacements >= 2001 ? -1 : minReplacements;
        }
            
        private static int Helper(int[] arr1, int[] arr2, int idx1, int idx2, int prev)
        {
            if(idx1 >= arr1.Length)
            {
                return 0;
            }

            var key = (idx1, prev);

            if(dp!.ContainsKey(key))
            {
                return dp[key];
            }

            int i1 = idx1, i2 = idx2;
            dp.Add(key, 2001);
            
            if(arr1[i1] > prev)
            {
                dp[key] = Math.Min(dp[key], Helper(arr1, arr2, idx1+1, idx2, arr1[idx1]));
            }

            while(idx2 < arr2.Length && arr2[idx2] <= prev)
            {
                idx2++;
            }

            if(idx2 < arr2.Length)
            {
                int replacements = Helper(arr1, arr2, idx1+1, idx2+1, arr2[idx2]);
                dp[key] = Math.Min(dp[key], 1 + replacements);
            }
            
            return dp[key];
        }
    }

    public class Test
    {
        public static bool[] TestMakeArrayStrictlyIncreasing()
        {
            int[] arr1 = {1,5,3,6,7};
            int[] arr2_Case1 = {1,3,2,4};
            int[] arr2_Case2 = {4,3,1};
            int[] arr2_Case3 = {1,6,3,3};

            int result1_1187 = Solution.MakeArrayIncreasing(arr1, arr2_Case1);
            int result2_1187 = Solution.MakeArrayIncreasing(arr1, arr2_Case2);
            int result3_1187 = Solution.MakeArrayIncreasing(arr1, arr2_Case3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_1187, 1),
                ResultTester.CheckResult<int>(result2_1187, 2),
                ResultTester.CheckResult<int>(result3_1187, -1)
            };

            return results;
        }
    }
}