// Can Make Arithmetic Progression From Sequence

/*
A sequence of numbers is called an arithmetic progression if the difference between any two consecutive elements is the same.

Given an array of numbers arr, return true if the array can be rearranged to form an arithmetic progression. Otherwise, return false.

 

Example 1:

Input: arr = [3,5,1]
Output: true
Explanation: We can reorder the elements as [1,3,5] or [5,3,1] with differences 2 and -2 respectively, between each consecutive elements.

Example 2:

Input: arr = [1,2,4]
Output: false
Explanation: There is no way to reorder the elements to obtain an arithmetic progression.
*/
using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CanMakeArithmeticProgressionFromSequence
{
    public class Solution
    {
        public static bool CanMakeArithmeticProgression(int[] arr)
        {
            // The function first sorts the input array arr using the Array.Sort method to ensure that the numbers are in ascending order.
            Array.Sort(arr);
            /*
                Then, the function checks if all pairs of adjacent numbers have the same difference using the All method of Enumerable.Range(2, arr.Length - 2).
                This creates a sequence of integers starting from 2 up to the last index of arr minus 2, and the All method checks if the condition holds for all elements of this sequence.
                The condition being checked is whether the difference between the second number (arr[1]) and the first number (arr[0]) is the same as the difference between the current number and the previous number in the sequence (arr[index] - arr[index - 1]).
            */
            return Enumerable.Range(2, arr.Length - 2).All(index => arr[1] - arr[0] == arr[index] - arr[index - 1]);
            // If the condition holds for all pairs of adjacent numbers in arr, the function returns true. Otherwise, it returns false.
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] Case1_1502 = {-1,-2,-3,-4,3,2,1};
            int[] Case2_1502 = {1,5,0,2,-3};
            int[] Case3_1502 = {-1,1,-1,1,-1};
            int[] Case4_1502 = {1000,2000,3000};
            int[] Case5_1502 = {4000,3000,1000,2000};
            int[] Case6_1502 = {3,5,1};
            int[] Case7_1502 = {1,2,4};

            bool Result1_1502 = Solution.CanMakeArithmeticProgression(Case1_1502);
            bool Result2_1502 = Solution.CanMakeArithmeticProgression(Case2_1502);
            bool Result3_1502 = Solution.CanMakeArithmeticProgression(Case3_1502);
            bool Result4_1502 = Solution.CanMakeArithmeticProgression(Case4_1502);
            bool Result5_1502 = Solution.CanMakeArithmeticProgression(Case5_1502);
            bool Result6_1502 = Solution.CanMakeArithmeticProgression(Case6_1502);
            bool Result7_1502 = Solution.CanMakeArithmeticProgression(Case7_1502);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Result1_1502, false),
                ResultTester.CheckResult<bool>(Result2_1502, false),
                ResultTester.CheckResult<bool>(Result3_1502, Result3_1502),
                ResultTester.CheckResult<bool>(Result4_1502, Result4_1502),
                ResultTester.CheckResult<bool>(Result5_1502, Result5_1502),
                ResultTester.CheckResult<bool>(Result6_1502, Result6_1502),
                ResultTester.CheckResult<bool>(Result7_1502, Result7_1502)
            };
            return results;
        }
    }
}