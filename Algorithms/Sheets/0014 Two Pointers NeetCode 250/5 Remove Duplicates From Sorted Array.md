Remove Duplicates From Sorted Array :

You are given an integer array nums sorted in non-decreasing order.

Your task is to remove duplicates from nums in-place so that each element appears only once.

After removing the duplicates, return the number of unique elements, denoted as k, such that the first k elements of nums contain the unique elements.


Note:

The order of the unique elements should remain the same as in the original array.

It is not necessary to consider elements beyond the first k positions of the array.

To be accepted, the first k elements of nums must contain all the unique elements.

Return k as the final result.


Example 1:

Input: nums = [1,1,2,3,4]

Output: [1,2,3,4]

Explanation: You should return k = 4 as we have four unique elements.


Example 2:

Input: nums = [2,10,10,30,30,30]

Output: [2,10,30]

Explanation: You should return k = 3 as we have three unique elements.



```cs

// Hash Set Approch
public class RemoveDuplicatesFromSortedArrayHashSet()
{
    public int RemoveDuplicates(int[] nums)
    {
        int len = nums.Length;
        HashSet<int> set = new HashSet<int>(nums);
        return set.Count();
    }
}

// Sorted Set Approch
public class RemoveDuplicatesFromSortedArraySortedSet()
{
    public int RemoveDuplicates(int[] nums)
    {
        var uniqueSet = new SortedSet<int>(nums);
        uniqueSet.CopyTo(nums);
        return uniqueSet.Count;
    }
}

// Linq Approch
public class RemoveDuplicatesFromSortedArraySortedSetLinq
{
    public int RemoveDuplicates(int[] nums)
    {
        int[] unique = nums.Distinct().OrderBy(x => x).ToArray();
        Array.Copy(unique, nums, unique.Length);
        return unique.Length;
    }
}

// Brute Force Approch
public class RemoveDuplicatesFromSortedArrayBruteForce
{
    public int RemoveDuplicates(int[] nums)
    {
        int i = 1;

        foreach (int n in nums)
        {
            if (nums[i - 1] != n) nums[i++] = n;
            // if previous is not egal to current, then next egal current
        }

        return i;
    }
}

// Two Pointers Approch
public class RemoveDuplicatesFromSortedArrayTwoPointers
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums is null || nums.Length < 2)
        {
            return 1;
        }

        int left = 1;
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] != nums[left - 1])
            {
                nums[left] = nums[right];
                left++;
            }
        }

        /*
            [1, 1, 2, 3, 4]

            if nums[0] (1) != nums[0] ...
            if nums[1] (1) != nums[0] (1) ...
            if nums[2] (2) != nums[0] (1)
                nums[1] = nums[2]
                left++ (2)
                [1, 2, 2, 3, 4]
            if nums[3] (3) != nums[1] (2) ...
                nums[2] = nums[3]
                left++ (3)
                [1, 2, 3, 3, 4]
            if nums[4] (4) != nums[2] (3) ...
                nums[3] = nums[4]
                left++ (4)
                [1, 2, 3, 4, 4]
        */

        return left; // returning left (exemple : 4)
    }
}

// Two Pointers While Loop Approch
public class RemoveDuplicatesFromSortedArrayTwoPointersWhileLoop
{
    public int RemoveDuplicates(int[] nums)
    {
        int n = nums.Length;
        int left = 0, right = 0;

        while (right < n)
        {
            nums[left] = nums[right];
            while (right < n && nums[right] == nums[left])
            {
                right++;
            }
            left++;
        }

        return left;
    }
}
```