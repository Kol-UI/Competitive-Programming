// Minimum Number of Days to Make m Bouquets

/*
You are given an integer array bloomDay, an integer m and an integer k.

You want to make m bouquets. To make a bouquet, you need to use k adjacent flowers from the garden.

The garden consists of n flowers, the ith flower will bloom in the bloomDay[i] and then can be used in exactly one bouquet.

Return the minimum number of days you need to wait to be able to make m bouquets from the garden. If it is impossible to make m bouquets return -1.


Example 1:

Input: bloomDay = [1,10,3,10,2], m = 3, k = 1
Output: 3
Explanation: Let us see what happened in the first three days. x means flower bloomed and _ means flower did not bloom in the garden.
We need 3 bouquets each should contain 1 flower.
After day 1: [x, _, _, _, _]   // we can only make one bouquet.
After day 2: [x, _, _, _, x]   // we can only make two bouquets.
After day 3: [x, _, x, _, x]   // we can make 3 bouquets. The answer is 3.

Example 2:

Input: bloomDay = [1,10,3,10,2], m = 3, k = 2
Output: -1
Explanation: We need 3 bouquets each has 2 flowers, that means we need 6 flowers. We only have 5 flowers so it is impossible to get the needed bouquets and we return -1.

Example 3:

Input: bloomDay = [7,7,7,7,12,7,7], m = 2, k = 3
Output: 12
Explanation: We need 2 bouquets each should have 3 flowers.
Here is the garden after the 7 and 12 days:
After day 7: [x, x, x, x, _, x, x]
We can make one bouquet of the first three flowers that bloomed. We cannot make another bouquet from the last three flowers that bloomed because they are not adjacent.
After day 12: [x, x, x, x, x, x, x]
It is obvious that we can make two bouquets in different ways.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofDaystoMakemBouquets
{
    public class Solution
    {
        public static int MinDays(int[] bloomDay, int m, int k)
        {
            var n = bloomDay.Length;

            if (n < m * k)
            {
                return -1;
            }

            var left = 1;
            var right = 1000000000;
            var result = Int32.MaxValue;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                var flowers = 0;
                var bouquets = 0;

                for (var i = 0; i < n; i++)
                {
                    if (bloomDay[i] > mid)
                    {
                        flowers = 0;
                        continue;
                    } 
                    
                    flowers++;
                    if (flowers == k)
                    {
                        flowers = 0;
                        bouquets++;
                        if (bouquets == m)
                        {
                            result = Math.Min(result, mid);
                            break;
                        }
                    }                
                }

                if (bouquets >= m)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return result == Int32.MaxValue ? -1 : result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] bloomDay1 = {1,10,3,10,2}; int m1 = 3; int k1 = 1;
            int[] bloomDay2 = {1,10,3,10,2}; int m2 = 3; int k2 = 2;
            int[] bloomDay3 = {7,7,7,7,12,7,7}; int m3 = 2; int k3 = 3;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinDays(bloomDay1, m1, k1), 3),
                ResultTester.CheckResult<int>(Solution.MinDays(bloomDay2, m2, k2), -1),
                ResultTester.CheckResult<int>(Solution.MinDays(bloomDay3, m3, k3), 12),
            };
            return results;
        }
    }
}