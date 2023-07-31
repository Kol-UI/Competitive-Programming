// Permutations II

/*
Given a collection of numbers, nums, that might contain duplicates, return all possible unique permutations in any order.

 

Example 1:

Input: nums = [1,1,2]
Output:
[[1,1,2],
 [1,2,1],
 [2,1,1]]

Example 2:

Input: nums = [1,2,3]
Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PermutationsII
{
    public class Solution
    {
        private List<IList<int>>? _result;

        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            _result = new List<IList<int>>();
            Backtrack(nums, 0);
            return _result;
        }

        private void Backtrack(IList<int> nums, int begin)
        {
            if (begin == nums.Count - 1)
            {
                _result!.Add(nums.ToArray());
            }

            var set = new HashSet<int>();

            for (int i = begin; i < nums.Count(); i++)
            {
                if (!set.Add(nums[i])) continue;

                (nums[i], nums[begin]) = (nums[begin], nums[i]);

                Backtrack(nums, begin + 1);

                (nums[i], nums[begin]) = (nums[begin], nums[i]);
            }
        }
    }
}
