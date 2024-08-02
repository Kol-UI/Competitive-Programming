// Minimum Flips to Make a OR b Equal to c

/*
Given 3 positives numbers a, b and c. Return the minimum flips required in some bits of a and b to make ( a OR b == c ). (bitwise OR operation).
Flip operation consists of change any single bit 1 to 0 or change the bit 0 to 1 in their binary representation.

 

Example 1:

Input: a = 2, b = 6, c = 5
Output: 3
Explanation: After flips a = 1 , b = 4 , c = 5 such that (a OR b == c)

Example 2:

Input: a = 4, b = 2, c = 7
Output: 1

Example 3:

Input: a = 1, b = 2, c = 3
Output: 0
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumFlipstoMakeaORbEqualtoc
{
    public class Solution
    {
        public static int MinFlips(int a, int b, int c)
        {
            int aorb = a|b;
            int flips = 0;

            for(int i = 0; i < 32; i++)
            {
                if((aorb >> i & 1) != (c >> i & 1))
                {
                    if((c >> i & 1) == 0 && (a >> i & 1) == 1 && (b >> i & 1) == 1)
                        flips = flips + 2;
                    else
                    flips = flips + 1;
                }
            }
            return flips;
        }
    }

    public class Test
    {
        public static bool[] TestMinimumFlipstoMakeaORbEqualtoc()
        {
            int result1 = Solution.MinFlips(2,6,5);
            int result2 = Solution.MinFlips(4,2,7);
            int result3 = Solution.MinFlips(1,2,3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 3),
                ResultTester.CheckResult<int>(result2, 1),
                ResultTester.CheckResult<int>(result3, 0)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Flips to Make a OR b Equal toc");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestMinimumFlipstoMakeaORbEqualtoc());
        }
    }
}