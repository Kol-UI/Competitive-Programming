Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).
Specifically, ans is the concatenation of two nums arrays.
Return the array ans.

Example 1:

Input: nums = [1,2,1]
Output: [1,2,1,1,2,1]
Explanation: The array ans is formed as follows:
- ans = [nums[0],nums[1],nums[2],nums[0],nums[1],nums[2]]
- ans = [1,2,1,1,2,1]

Example 2:

Input: nums = [1,3,2,1]
Output: [1,3,2,1,1,3,2,1]
Explanation: The array ans is formed as follows:
- ans = [nums[0],nums[1],nums[2],nums[3],nums[0],nums[1],nums[2],nums[3]]
- ans = [1,3,2,1,1,3,2,1]

Hint 1 : Build an array of size 2 * n and assign num[i] to ans[i] and ans[i + n]


```cs
public class Solution
{
    public static int[] GetConcatenation(int[] nums)
    {
        return nums.Concat(nums).ToArray();
    }
}
```


```cs
public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        List<int> ans = new();
        for(int i = 0; i < 2; i++) ans.AddRange(nums);
        return ans.ToArray();
    }
}
```