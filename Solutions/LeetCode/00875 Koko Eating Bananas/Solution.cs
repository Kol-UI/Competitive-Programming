using System;
using CompetitiveProgramming.Helpers.Generaters;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KokoEatingBananas
{
    // Koko loves to eat bananas. There are n piles of bananas, the ith pile has piles[i] bananas. The guards have gone and will come back in h hours.
    // Koko can decide her bananas-per-hour eating speed of k. Each hour, she chooses some pile of bananas and eats k bananas from that pile. If the pile has less than k bananas, she eats all of them instead and will not eat any more bananas during this hour.
    // Koko likes to eat slowly but still wants to finish eating all the bananas before the guards return.
    // Return the minimum integer k such that she can eat all the bananas within h hours.

    // Example 1:
    // Input: piles = [3,6,7,11], h = 8
    // Output: 4

    // Example 2:
    // Input: piles = [30,11,23,4,20], h = 5
    // Output: 30

    // Example 3:
    // Input: piles = [30,11,23,4,20], h = 6
    // Output: 23
    public class Solution
    {
        public static long GetHours(int[] piles, int k)
        {
            long result = 0;
            foreach (var p in piles) result += (p-1) / k + 1;
            return result;
        }

        public static int MinEatingSpeed(int[] piles, int h)
        {
            int l = 1, r = piles.Max();
            while (l < r) {
                var m = (l + r) / 2;
                var mh = GetHours(piles, m);
                if (mh > h) l = m + 1;
                else r = m;
            }
            return l;
        }
    }

    public class Test
    {
        public static bool[] TestKokoEatingBananas()
        {
            System.Random random = new();

            // Case 1
            int[] piles1_875 = { 3, 6, 7, 11 };
            int h1_875 = 8;
            int result1_875 = Solution.MinEatingSpeed(piles1_875, h1_875);

            // Case 2
            int[] piles2_875 = { 30, 11, 23, 4, 20 };
            int h2_875 = 5;
            int result2_875 = Solution.MinEatingSpeed(piles2_875, h2_875);

            // Case 3
            int[] piles3_875 = { 30, 11, 23, 4, 20 };
            int h3_875 = 6;
            int result3_875 = Solution.MinEatingSpeed(piles3_875, h3_875);

            // Case 4
            int[] piles4_875 = RandomGeneraters.GenerateRandomNumber(25, 10);
            int h4_875 = random.Next(1, 10);
            int result4_875 = Solution.MinEatingSpeed(piles4_875, h4_875);

            // Case 5
            int[] piles5_875 = RandomGeneraters.GenerateRandomNumber(25, 10);
            int h5_875 = random.Next(1, 10);
            int result5_875 = Solution.MinEatingSpeed(piles5_875, h5_875);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1_875, 4),
                ResultTester.CheckResult<int>(result2_875, 30),
                ResultTester.CheckResult<int>(result3_875, 23),
                ResultTester.CheckResult<int>(result4_875, result4_875),
                ResultTester.CheckResult<int>(result5_875, result5_875)
            };

            return results;
        }
    }
}