// Plus One

/*
You are given a large integer represented as an integer array digits, where each digits[i] is the ith digit of the integer. The digits are ordered from most significant to least significant in left-to-right order. The large integer does not contain any leading 0's.

Increment the large integer by one and return the resulting array of digits.

 

Example 1:

Input: digits = [1,2,3]
Output: [1,2,4]
Explanation: The array represents the integer 123.
Incrementing by one gives 123 + 1 = 124.
Thus, the result should be [1,2,4].

Example 2:

Input: digits = [4,3,2,1]
Output: [4,3,2,2]
Explanation: The array represents the integer 4321.
Incrementing by one gives 4321 + 1 = 4322.
Thus, the result should be [4,3,2,2].

Example 3:

Input: digits = [9]
Output: [1,0]
Explanation: The array represents the integer 9.
Incrementing by one gives 9 + 1 = 10.
Thus, the result should be [1,0].
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PlusOne
{
    public class Solution
    {
        /*
            Add one to a number represented by an array of digits.
            If the number is less than 9, it adds 1 to the least significant digit and returns the resulting array.
            If all digits are 9, it creates a new array with an additional digit and sets the most significant digit to 1.
        */

        // This function takes an integer array digits as input and returns a new array containing the digits of the original number plus one.
        public static int[] PlusOne(int[] digits)
        {
            int l = digits.Length - 1;
            // Loops through the digits array from the end to the beginning, checking if the current digit is less than 9.
            for(int i = l; i >= 0; i--)
            {
                if(digits[i] < 9)
                {
                    // Adds 1 to the current digit and returns the digits array.
                    digits[i]++;
                    return digits;
                }
                // If the current digit is equal to 9, the function sets the current digit to 0 and continues looping.
                else digits[i] = 0;
            }

            // If the loop completes without returning, it means that all digits were equal to 9,
            // So a new array result of length l + 2 is created.
            // The first element of result is set to 1, and result is returned.
            int[] result = new int[l + 2];
            result[0] = 1;

            return result; 
        }
    }

    public class Test
    {
        public static bool[] TestPlusOne()
        {
            // Case 1
            int[] digits1_66 = {1,2,3};
            int[] result1_66 = LeetCode.PlusOne.Solution.PlusOne(digits1_66);

            // Case 2
            int[] digits2_66 = {4,3,2,1};
            int[] result2_66 = LeetCode.PlusOne.Solution.PlusOne(digits2_66);

            // Case 3
            int[] digits3_66 = {9};
            int[] result3_66 = LeetCode.PlusOne.Solution.PlusOne(digits3_66);

            int[] expected1 = {1,2,4};
            int[] expected2 = {4,3,2,2};
            int[] expected3 = {1,0};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1_66, expected1),
                ResultTester.CheckResult<int[]>(result2_66, expected2),
                ResultTester.CheckResult<int[]>(result3_66, expected3)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Plus One");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestPlusOne());
        }
    }
}