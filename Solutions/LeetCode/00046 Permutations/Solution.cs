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
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.Permutations
{
    public class Solution 
    {
        public static void Combination(int[] nums, int currentIndex, IList<IList<int>> list, IList<int> contains)
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

        public static IList<IList<int>> Permute(int[] nums) 
        {
            IList<IList<int>> permutations = new List<IList<int>>();

            for(int i = 0; i < nums.Length; i++)
            {
                Combination(nums, i, permutations, new List<int>());
            }

            return permutations;
        }
    }

    public class Test
    {
        public static bool[] TestPermutations()
        {
            int[] nums1 = new int[] {1, 2, 3};
            IList<IList<int>> output1 = new List<IList<int>>
            {
                new List<int> {1, 2, 3},
                new List<int> {1, 3, 2},
                new List<int> {2, 1, 3},
                new List<int> {2, 3, 1},
                new List<int> {3, 1, 2},
                new List<int> {3, 2, 1}
            };

            int[] nums2 = new int[] {0, 1};
            IList<IList<int>> output2 = new List<IList<int>>
            {
                new List<int> {0, 1},
                new List<int> {1, 0}
            };

            int[] nums3 = new int[] {1};
            IList<IList<int>> output3 = new List<IList<int>>
            {
                new List<int> {1}
            };
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(Solution.Permute(nums1), output1),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.Permute(nums2), output2),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.Permute(nums3), output3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Permutations");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestPermutations());
        }
    }
}