// Summary Ranges

/*
You are given a sorted unique integer array nums.

A range [a,b] is the set of all integers from a to b (inclusive).

Return the smallest sorted list of ranges that cover all the numbers in the array exactly. That is, each element of nums is covered by exactly one of the ranges, and there is no integer x such that x is in one of the ranges but not in nums.

Each range [a,b] in the list should be output as:

"a->b" if a != b
"a" if a == b
 

Example 1:

Input: nums = [0,1,2,4,5,7]
Output: ["0->2","4->5","7"]
Explanation: The ranges are:
[0,2] --> "0->2"
[4,5] --> "4->5"
[7,7] --> "7"

Example 2:

Input: nums = [0,2,3,4,6,8,9]
Output: ["0","2->4","6","8->9"]
Explanation: The ranges are:
[0,0] --> "0"
[2,4] --> "2->4"
[6,6] --> "6"
[8,9] --> "8->9"
*/

using System;
namespace CompetitiveProgramming.LeetCode.SummaryRanges
{
    public class Solution
    {
        public static IList<string> SummaryRanges(int[] nums)
        {
            IList<string> result = new List<string>();
            
            if (nums == null || nums.Length == 0) 
                return result;
            
            int n = nums.Length;
            int start = nums[0];
            
            for (int i = 0; i < n; i++) 
            {
                if (i < n - 1 && nums[i + 1] == nums[i] + 1) 
                    continue;
                
                if (start == nums[i]) 
                    result.Add(start.ToString());
                else 
                    result.Add(start + "->" + nums[i]);
                
                if (i < n - 1) 
                    start = nums[i + 1];
            }
            
            return result;

        }
    }
}