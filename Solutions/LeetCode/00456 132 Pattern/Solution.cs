// 132 Pattern

/*
Given an array of n integers nums, a 132 pattern is a subsequence of three integers nums[i], nums[j] and nums[k] such that i < j < k and nums[i] < nums[k] < nums[j].

Return true if there is a 132 pattern in nums, otherwise, return false.

 

Example 1:

Input: nums = [1,2,3,4]
Output: false
Explanation: There is no 132 pattern in the sequence.

Example 2:

Input: nums = [3,1,4,2]
Output: true
Explanation: There is a 132 pattern in the sequence: [1, 4, 2].

Example 3:

Input: nums = [-1,3,2,0]
Output: true
Explanation: There are three 132 patterns in the sequence: [-1, 3, 2], [-1, 3, 0] and [-1, 2, 0].
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.OneThreeTwoPattern
{
    public class Solution
    {
        public static bool Find132pattern(int[] nums)
        {
            int min = nums[0];
            Stack<(int, int)> st = new Stack<(int, int)>();

            for(int i = 1; i < nums.Length; i++)
            {
                while (st.Any() && st.Peek().Item1 <= nums[i])
                    st.Pop();
                
                if (st.Any() && st.Peek().Item2 < nums[i])
                    return true;
                
                st.Push((nums[i], min));
                min = Math.Min(min, nums[i]);
            }
            
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] case1 = {1,2,3,4};
            int[] case2 = {3,1,4,2};
            int[] case3 = {-1,3,2,0};
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.Find132pattern(case1), false),
                ResultTester.CheckResult<bool>(Solution.Find132pattern(case2), true),
                ResultTester.CheckResult<bool>(Solution.Find132pattern(case3), true),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("132 Pattern");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}