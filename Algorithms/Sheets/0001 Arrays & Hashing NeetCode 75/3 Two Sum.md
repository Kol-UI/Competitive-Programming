Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].


Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]


Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 


Approch Brute Force (mine) :


```cs
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        int size = nums.Length;
        if (nums == null || size < 2) return result;
        for(int i = 0; i < size; i++)
        {
            for(int j = i + 1; j < size; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }
        return result;
    }
}
```


Approch Two Pass Hash (editorial) :

```cs
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int size = nums.Length;
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < size; i++) map[nums[i]] = i;

        for (int i = 0; i < size; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement) && map[complement] != i)
                return new int[] { i, map[complement] };
        }

        return new int[] {};
    }
}
```


Approch One Pass Hash (editorial) :
```cs
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
                return new int[] { map[complement], i };
            map[nums[i]] = i;
        }
        return new int[] {};
    }
}
```


Hashing (mine) :

```cs
public int[] TwoSum(int[] nums, int target)
{
	int[] result = new int[2];
	int size = nums.Length;
    if (nums == null || size < 2) return result;
    Dictionary<int, int> dic = new();

    for (int i = 0; i < size; i++)
    {
        if (dic.ContainsKey(target - nums[i]))
        {
            return new int[] { dic[target - nums[i]], i };
        }
        else if (!dic.ContainsKey(nums[i]))
        {
            dic.Add(nums[i], i);
        }
    }

    return result;
}
```