Contains Duplicate II

You are given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k, otherwise return false.


Example 1:

Input: nums = [1,2,3,1], k = 3

Output: true


Example 2:

Input: nums = [2,1,2], k = 1

Output: false


```cs

// Sliding Window - Brute Force Approch
public class ContainsDuplicateII_BruteForce
{
    public bool ContainsNearbyDuplicate(int[] nums, int k) 
    {
        for (int right = 0; right < nums.Length; right++) 
        {
            for (int left = right + 1; left < nums.Length; left++) 
            {
                if (nums[right] == nums[left] && Math.Abs(right - left) <= k) 
                {
                    return true;
                }
                if (Math.Abs(right - left) > k) 
                {
                    break;
                }
            }
        }
        return false;
    }
}

// Sliding Window - HashMap Approch
public class ContainsDuplicateII_HashMap
{
    public bool ContainsNearbyDuplicate(int[] nums, int k) 
    {
        Dictionary<int, int> map = [];

        for (int right = 0; right < nums.Length; right++) 
        {
            if (map.TryGetValue(nums[right], out int left)) 
            {
                if (Math.Abs(right - left) <= k) 
                {
                    return true;
                }
            }
            
            // Updade index of that value for next comparisons
            map[nums[right]] = right;
        }

        return false;
    }
}

// Sliding Window - HashSet Approch
public class ContainsDuplicateII_HashSet
{
    public bool ContainsNearbyDuplicate(int[] nums, int k) 
    {
        HashSet<int> set = [];
        int left = 0;

        for (int right = 0; right < nums.Length; right++) 
        {
            if (right - left > k) 
            {
                set.Remove(nums[left]);
                left++;
            }
            if (set.Contains(nums[right]))
            {
                return true;
            }
            set.Add(nums[right]);
        }

        return false;
    }
}
```
