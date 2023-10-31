// Find The Original Array of Prefix Xor

/*
You are given an integer array pref of size n. Find and return the array arr of size n that satisfies:

pref[i] = arr[0] ^ arr[1] ^ ... ^ arr[i].
Note that ^ denotes the bitwise-xor operation.

It can be proven that the answer is unique.

 

Example 1:

Input: pref = [5,2,0,3,1]
Output: [5,7,2,3,2]
Explanation: From the array [5,7,2,3,2] we have the following:
- pref[0] = 5.
- pref[1] = 5 ^ 7 = 2.
- pref[2] = 5 ^ 7 ^ 2 = 0.
- pref[3] = 5 ^ 7 ^ 2 ^ 3 = 3.
- pref[4] = 5 ^ 7 ^ 2 ^ 3 ^ 2 = 1.

Example 2:

Input: pref = [13]
Output: [13]
Explanation: We have pref[0] = arr[0] = 13.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindTheOriginalArrayofPrefixXor
{
    public class Solution
    {
        public static int[] FindArray(int[] pref)
        {
            int[] result = new int[pref.Length];
            result[0] = pref[0];
            for(int i = 1; i < pref.Length; i++)
            {
                result[i] = pref[i] ^ pref[i-1];
            }
            return result;
        }
    }
    public class Test
    {
        public static bool[] TestCases()
        {
            int[] pref1 = {5,2,0,3,1};
            int[] output1 = {5,7,2,3,2};
            int[] pref2 = {13};
            int[] output2 = {13};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.FindArray(pref1), output1),
                ResultTester.CheckResult<int[]>(Solution.FindArray(pref2), output2),
            };
            return results;
        }
    }
}