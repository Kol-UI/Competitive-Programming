You are given an integer array nums of odd length n.

Return true if the middle element of nums appears exactly once in the array. Otherwise return false.


Input: nums = [1,2,3]

Output: true

Input: nums = [1,2,2]

Output: false


```cs
public class Solution
{
    public bool IsMiddleElementUnique(int[] nums)
    {
        if (nums == null || nums.Length == 0) return false;

        int midValue = nums[nums.Length / 2];
        return nums.Count(x => x == midValue) == 1;
    }
}
```
