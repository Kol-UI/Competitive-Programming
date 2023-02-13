using System;

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
}

