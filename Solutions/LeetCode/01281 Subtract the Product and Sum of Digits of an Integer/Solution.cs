// Subtract the Product and Sum of Digits of an Integer

/*
Given an integer number n, return the difference between the product of its digits and the sum of its digits.
 

Example 1:

Input: n = 234
Output: 15 
Explanation: 
Product of digits = 2 * 3 * 4 = 24 
Sum of digits = 2 + 3 + 4 = 9 
Result = 24 - 9 = 15

Example 2:

Input: n = 4421
Output: 21
Explanation: 
Product of digits = 4 * 4 * 2 * 1 = 32 
Sum of digits = 4 + 4 + 2 + 1 = 11 
Result = 32 - 11 = 21
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SubtracttheProductandSumofDigitsofanInteger
{
    public class Solution
    {
        public static int SubtractProductAndSum(int n)
        {
            int product = 1;
            int sum = 0;

            while(n > 0)
            {
                int remainder = n % 10;

                sum += remainder;
                product *= remainder;

                n = n /10;
            }


            return product - sum;
        }
    }

    public class Test
    {
        public static bool[] TestSubtracttheProductandSumofDigitsofanInteger()
        {
            int case1 = 234;
            int case2 = 4421;

            int result1 = Solution.SubtractProductAndSum(case1);
            int result2 = Solution.SubtractProductAndSum(case2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 15),
                ResultTester.CheckResult<int>(result2, 21)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1281");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestSubtracttheProductandSumofDigitsofanInteger());
        }
    }
}