// Subsets II

/*
Given an integer array nums that may contain duplicates, return all possible 
subsets
 (the power set).

The solution set must not contain duplicate subsets. Return the solution in any order.

 

Example 1:

Input: nums = [1,2,2]
Output: [[],[1],[1,2],[1,2,2],[2],[2,2]]

Example 2:

Input: nums = [0]
Output: [[],[0]]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SubsetsII
{
    public class Solution
    {
        public static IList<IList<int>>? SubsetsWithDup(int[] nums)
        {
            if(nums == null || nums.Length == 0) return null;
            
            IList<IList<int>> result = new List<IList<int>>();
            
            Array.Sort(nums);
            
            Backtrack(result,new List<int>(),0,nums);
            
            return result;
        }

        private static void Backtrack(IList<IList<int>> sets, List<int> curr, int index, int[] nums)
        {
            sets.Add(new List<int>(curr));
            
            for(int i = index ; i < nums.Length ; i++)
            {
                if(i > index && nums[i] == nums[i-1]) continue;
                
                curr.Add(nums[i]);
                Backtrack(sets,curr,i+1,nums);
                curr.RemoveAt(curr.Count-1);
            }
        }
    }

    public class Solution2
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> subsets = new List<IList<int>>();
            GenerateSubsetsIgnoreDuplicates(nums, 0, new List<int>(), subsets);
            return subsets;
        }

        private void GenerateSubsetsIgnoreDuplicates(int[] nums, int index, List<int> currentSubset, IList<IList<int>> subsets)
        {
            subsets.Add(new List<int>(currentSubset));

            for (int i = index; i < nums.Length; i++)
            {
                if (i > index && nums[i] == nums[i - 1]) continue;

                currentSubset.Add(nums[i]);
                GenerateSubsetsIgnoreDuplicates(nums, i + 1, currentSubset, subsets);
                currentSubset.RemoveAt(currentSubset.Count - 1);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subsets II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}