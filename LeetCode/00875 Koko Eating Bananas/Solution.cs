using System;
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
}