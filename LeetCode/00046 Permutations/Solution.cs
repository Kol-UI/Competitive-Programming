// Permutations

/*
Given an array nums of distinct integers, return all the possible permutations. You can return the answer in any order.

 

Example 1:

Input: nums = [1,2,3]
Output: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]

Example 2:

Input: nums = [0,1]
Output: [[0,1],[1,0]]

Example 3:

Input: nums = [1]
Output: [[1]]
*/

using System;
namespace CompetitiveProgramming.LeetCode.Permutations
{
    public class Solution 
    {
        public void Combination(int[] nums, int currentIndex, IList<IList<int>> list, IList<int> contains)
        {
            contains.Add(nums[currentIndex]);

            if(contains.Count == nums.Length) list.Add(contains);
            else
            {
                for(int i = 0; i < nums.Length; i++)
                {
                    if(i != currentIndex && contains.Contains(nums[i]) == false)
                    {
                        Combination(nums, i, list, new List<int>(contains));
                    }
                }
            } 
        }

        public IList<IList<int>> Permute(int[] nums) 
        {
            IList<IList<int>> permutations = new List<IList<int>>();

            for(int i = 0; i < nums.Length; i++)
            {
                Combination(nums, i, permutations, new List<int>());
            }

            return permutations;
        }
    }
}