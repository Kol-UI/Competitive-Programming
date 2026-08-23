// Longest Consecutive Sequence

Given an array of integers nums, return the length of the longest consecutive sequence of elements that can be formed.

A consecutive sequence is a sequence of elements in which each element is exactly 1 greater than the previous element.

The elements do not have to be consecutive in the original array.

You must write an algorithm that runs in O(n) time.


Example 1:

Input: nums = [2,20,4,10,3,4,5]

Output: 4

Explanation: The longest consecutive sequence is [2, 3, 4, 5].


Example 2:

Input: nums = [0,3,2,5,4,6,1,1]

Output: 7


```cs
public class LongestConsecutiveSequenceSortBruteForce()
{
    public int LongestConsecutive(int[] nums)
    {
        int len = nums.Length;
        if (nums is null || len == 0) return 0;

        int result = 0;
        Array.Sort(nums);

        for (int i = 0; i < len; i++)
        {
            int value = nums[i];
            int currentResult = 1;
            for (int j = 0; j < len; j++)
            {
                if (nums[j] == value + 1)
                {
                    currentResult++;
                    value = nums[j];
                }
            }
            if (currentResult > 1 && currentResult > result) result = currentResult;
        }

        return result;
    }
}

public class LongestConsecutiveSequenceImprovedBruteForce
{
    public int LongestConsecutive(int[] nums)
    {
        int result = 0;
        HashSet<int> set = new HashSet<int>(nums);

        foreach (int num in nums)
        {
            int streak = 0, current = num;
            while (set.Contains(current))
            {
                streak++;
                current++;
            }
            result = Math.Max(result, streak);
        }
        return result;
    }
}

public class LongestConsecutiveSequenceSorting
{
    public int LongestConsecutive(int[] nums)
    {
        int len = nums.Length;
        if (len == 0) return 0;
        Array.Sort(nums);

        int result = 0, current = nums[0], streak = 0, i = 0;

        while (i < len)
        {
            if (current != nums[i])
            {
                current = nums[i];
                streak = 0;
            }
            while (i < len && nums[i] == current) i++;
            streak++;
            current++;
            result = Math.Max(result, streak);
        }
        return result;
    }
}


public class LongestConsecutiveSequenceHashSet
{
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in numSet)
        {
            if (!numSet.Contains(num - 1))
            {
                int length = 1;
                while (numSet.Contains(num + length)) length++;
                longest = Math.Max(longest, length);
            }
        }
        return longest;
    }
}

public class LongestConsecutiveSequenceMap
{
    public int LongestConsecutive(int[] nums)
    {
        Dictionary<int, int> mp = new Dictionary<int, int>();
        int result = 0;

        foreach (int num in nums)
        {
            if (!mp.ContainsKey(num))
            {
                mp[num] = (mp.ContainsKey(num - 1) ? mp[num - 1] : 0) +
                          (mp.ContainsKey(num + 1) ? mp[num + 1] : 0) + 1;

                mp[num - (mp.ContainsKey(num - 1) ? mp[num - 1] : 0)] = mp[num];
                mp[num + (mp.ContainsKey(num + 1) ? mp[num + 1] : 0)] = mp[num];

                result = Math.Max(result, mp[num]);
            }
        }
        return result;
    }
}
```