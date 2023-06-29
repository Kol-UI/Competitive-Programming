// Tallest Billboard

/*
You are installing a billboard and want it to have the largest height. The billboard will have two steel supports, one on each side. Each steel support must be an equal height.

You are given a collection of rods that can be welded together. For example, if you have rods of lengths 1, 2, and 3, you can weld them together to make a support of length 6.

Return the largest possible height of your billboard installation. If you cannot support the billboard, return 0.

 

Example 1:

Input: rods = [1,2,3,6]
Output: 6
Explanation: We have two disjoint subsets {1,2,3} and {6}, which have the same sum = 6.

Example 2:

Input: rods = [1,2,3,4,5,6]
Output: 10
Explanation: We have two disjoint subsets {2,3,5} and {4,6}, which have the same sum = 10.

Example 3:

Input: rods = [1,2]
Output: 0
Explanation: The billboard cannot be supported, so we return 0.
*/


using System;
namespace CompetitiveProgramming.LeetCode.TallestBillboard
{
    public class Solution
    {
        public static int TallestBillboard(int[] rods)
        {
            Dictionary<int, int> curr = new Dictionary<int, int>();
            Dictionary<int, int> prev = new Dictionary<int, int>();
            curr.Add(0, 0);

            foreach (int rod in rods)
            {
                (prev, curr) = (curr, prev);
                curr.Clear();
                foreach (int diff in prev.Keys)
                {
                    LeftRightOrDiscard(curr, diff, prev[diff], rod);
                }
            }

            return curr[0];
        }

        private static void LeftRightOrDiscard(Dictionary<int, int> curr, int diff, int height, int change)
        {
            UpdateHeight(curr, diff, height);
            UpdateHeight(curr, diff + change, height);
            diff -= change;

            if (diff >= 0)
            {
                height += change;
            }
            else
            {
                diff = 0 - diff;
                height += change - diff;
            }

            UpdateHeight(curr, diff, height);
        }

        private static void UpdateHeight(Dictionary<int, int> curr, int diff, int height)
        {
            if (!curr.TryAdd(diff, height))
            {
                curr[diff] = Math.Max(curr[diff], height);
            }
        }

    }
}