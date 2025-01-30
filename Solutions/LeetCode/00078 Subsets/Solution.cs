// Subsets

/*
Given an integer array nums of unique elements, return all possible 
subsets
 (the power set).

The solution set must not contain duplicate subsets. Return the solution in any order.

 

Example 1:

Input: nums = [1,2,3]
Output: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]


Example 2:

Input: nums = [0]
Output: [[],[0]]
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.Subsets
{
    public class Solution
    {
        public static IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> subsets = new List<IList<int>>
            {
                new List<int>()
            };

            for (int i = 0; i < nums.Length; i++)
            {
                int count = subsets.Count;
                for(int j = 0; j < count; j++)
                {
                    var temp = subsets[j].ToList();
                    temp.Add(nums[i]);
                    subsets.Add(temp);

                }
            }
            return subsets;
        }
    }

    public class Solution2
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> subsets = new List<IList<int>>();
            GenerateSubsets(nums, 0, new List<int>(), subsets);
            return subsets;
        }

        private void GenerateSubsets(int[] nums, int index, List<int> currentSubset, IList<IList<int>> subsets)
        {
            subsets.Add(new List<int>(currentSubset));

            for (int i = index; i < nums.Length; i++)
            {
                currentSubset.Add(nums[i]);
                GenerateSubsets(nums, i + 1, currentSubset, subsets);
                currentSubset.RemoveAt(currentSubset.Count - 1);
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] arr1 = {1, 2, 3};
            int[] arr2 = {0};

            IList<IList<int>> expected1 = new List<IList<int>>
            {
                new List<int>(),
                new List<int> { 1 },
                new List<int> { 2 },
                new List<int> { 1, 2 },
                new List<int> { 3 },
                new List<int> { 1, 3 },
                new List<int> { 2, 3 },
                new List<int> { 1, 2, 3 }
            };

            IList<IList<int>> expected2 = new List<IList<int>>
            {
                new List<int>(),
                new List<int> { 0 }
            };

            Solution2 solution2 = new();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(Solution.Subsets(arr1), expected1),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.Subsets(arr2), expected2),
                ResultTester.CheckResult<IList<IList<int>>>(solution2.Subsets(arr2), expected2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Subsets");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}