// Range Sum Query - Immutable

/*
Given an integer array nums, handle multiple queries of the following type:

Calculate the sum of the elements of nums between indices left and right inclusive where left <= right.
Implement the NumArray class:

NumArray(int[] nums) Initializes the object with the integer array nums.
int sumRange(int left, int right) Returns the sum of the elements of nums between indices left and right inclusive (i.e. nums[left] + nums[left + 1] + ... + nums[right]).
 

Example 1:

Input
["NumArray", "sumRange", "sumRange", "sumRange"]
[[[-2, 0, 3, -5, 2, -1]], [0, 2], [2, 5], [0, 5]]
Output
[null, 1, -1, -3]

Explanation
NumArray numArray = new NumArray([-2, 0, 3, -5, 2, -1]);
numArray.sumRange(0, 2); // return (-2) + 0 + 3 = 1
numArray.sumRange(2, 5); // return 3 + (-5) + 2 + (-1) = -1
numArray.sumRange(0, 5); // return (-2) + 0 + 3 + (-5) + 2 + (-1) = -3
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RangeSumQueryImmutable
{
    public class NumArray
    {
        public int[] _nums;

        public NumArray(int[] nums)
        {
            var n = nums.Length;
            _nums = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                _nums[i+1] = _nums[i] + nums[i];
            }
        }
        
        public int SumRange(int left, int right)
        {
            return _nums[right+1] - _nums[left];
        }
    }

    /**
    * Your NumArray object will be instantiated and called as such:
    * NumArray obj = new NumArray(nums);
    * int param_1 = obj.SumRange(left,right);
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Range Sum Query - Immutable");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}