using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountOddNumbersinanIntervalRange
{
    // Given two non-negative integers low and high. Return the count of odd numbers between low and high (inclusive).

    // Example 1:
    // Input: low = 3, high = 7
    // Output: 3
    // Explanation: The odd numbers between 3 and 7 are [3,5,7].
    
    // Example 2:
    // Input: low = 8, high = 10
    // Output: 1
    // Explanation: The odd numbers between 8 and 10 are [9].

    public class Solution
    {
        public static int CountOdds(int low, int high)
        {
            int num = high - low + 1;
            if (num % 2 == 0)
            {
                return num / 2;
            }
            else
            {
                if (low % 2 == 0)
                {
                    return (num - 1) / 2;
                }
                else
                {
                    return (num + 1) / 2;
                }
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int lowCase1_1523 = 3;
            int highCase1_1523 = 7;
            int Case1_1523_Result = Solution.CountOdds(lowCase1_1523, highCase1_1523);

            // Case 2
            int lowCase2_1523 = 8;
            int highCase2_1523 = 10;
            int Case2_1523_Result = Solution.CountOdds(lowCase2_1523, highCase2_1523);

            // Case 3
            int lowCase3_1523 = 21;
            int highCase3_1523 = 22;
            int Case3_1523_Result = Solution.CountOdds(lowCase3_1523, highCase3_1523);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_1523_Result, 3),
                ResultTester.CheckResult<int>(Case2_1523_Result, 1),
                ResultTester.CheckResult<int>(Case3_1523_Result, Case3_1523_Result)
            };
            return results;
        }
    }
}

