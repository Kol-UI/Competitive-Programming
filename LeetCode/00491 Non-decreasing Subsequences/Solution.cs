using System;
namespace CompetitiveProgramming.LeetCode.NondecreasingSubsequences
{
    public class Solution
    {
        //Given an integer array nums, return all the different possible non-decreasing subsequences of the given array with at least two elements.You may return the answer in any order.

        //Example 1:
        //Input: nums = [4, 6, 7, 7]
        //Output: [[4,6], [4,6,7], [4,6,7,7], [4,7], [4,7,7], [6,7], [6,7,7], [7,7]]

        //Example 2:
        //Input: nums = [4,4,3,2,1]
        //Output: [[4,4]]

        public IList<IList<int>> FindSubsequences(int[] nums)
        {
            return FindSubsequences(nums, new List<int>(), 0);
        }

        public IList<IList<int>> FindSubsequences(int[] nums, List<int> current, int index)
        {
            List<IList<int>> ires = new List<IList<int>>();
            HashSet<int> used = new HashSet<int>();
            for (int i = index; i < nums.Length; i++)
            {
                if (i != index && used.Contains(nums[i]))
                    continue;
                if (index == 0 || nums[i] >= current.Last())
                {
                    current.Add(nums[i]);
                    if (current.Count > 1)
                        ires.Add(current.ToList());
                    ires.AddRange(FindSubsequences(nums, current, i + 1));
                    current.RemoveAt(current.Count - 1);
                }
                used.Add(nums[i]);
            }
            return ires;

        }
    }
}

