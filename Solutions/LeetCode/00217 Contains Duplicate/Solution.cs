using System;
using System.Collections.Generic;
using CompetitiveProgramming.CodeForces.NotAdjacentMatrix;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ContainsDuplicate
{
    public class Solution
    {
        //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

        //Example 1:

        //Input: nums = [1,2,3,1]
        //Output: true

        //Example 2:

        //Input: nums = [1,2,3,4]
        //Output: false

        //Example 3:

        //Input: nums = [1,1,1,3,3,4,3,2,4,2]
        //Output: true

        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums.GroupBy(x => x).Any(g => g.Count() > 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Solution2
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new();
            for(int i = 0; i < nums.Length; i++) set.Add(nums[i]);
            if (set.Count == nums.Length) return false;
            else return true;
        }
    }

    public class Test
    {
        public static bool[] TestContainsDuplicate()
        {
            // Case 1
            int[] Case1_217 = {1, 2, 3, 1};
            bool Case1_217_Result = Solution.ContainsDuplicate(Case1_217);

            // Case 2
            int[] Case2_217 = { 1, 2, 3, 4 };
            bool Case2_217_Result = Solution.ContainsDuplicate(Case2_217);

            // Case 2
            int[] Case3_217 = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool Case3_217_Result = Solution.ContainsDuplicate(Case3_217);

            Solution2 sol = new();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Case1_217_Result, true),
                ResultTester.CheckResult<bool>(Case2_217_Result, false),
                ResultTester.CheckResult<bool>(Case3_217_Result, true),
                ResultTester.CheckResult<bool>(sol.ContainsDuplicate(Case1_217), true),
                ResultTester.CheckResult<bool>(sol.ContainsDuplicate(Case2_217), false),
                ResultTester.CheckResult<bool>(sol.ContainsDuplicate(Case3_217), true)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Contains Duplicate");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestContainsDuplicate());
        }
    }
}