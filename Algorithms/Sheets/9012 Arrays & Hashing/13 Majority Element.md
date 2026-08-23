Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times.
You may assume that the majority element always exists in the array.

 

Example 1:

Input: nums = [3,2,3]
Output: 3


Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2


Counting Solution : 
```cs
public int MajorityElement(int[] nums)
{
    int size = nums.Length;
    int majorityValue = size / 2;
    Dictionary<int, int> counts = new();

    for (int i = 0; i < size; i++)
    {
        int current = nums[i];
        if (counts.ContainsKey(current)) counts[current]++;
        else counts[current] = 1;

        if (counts[current] > majorityValue) return current;
    }
    
    return -1;
}
```

Counts every element, then check if element is majority (size/2)