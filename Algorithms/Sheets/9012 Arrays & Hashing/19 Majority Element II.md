You are given an integer array nums of size n, find all elements that appear more than ⌊ n/3 ⌋ times.
You can return the result in any order.


Example 1:

Input: nums = [5,2,3,2,2,2,2,5,5,5]

Output: [2,5]


Example 2:

Input: nums = [4,4,4,4,4]

Output: [4]


Example 3:

Input: nums = [1,2,3]

Output: []

```cs
public class MajorityElementIISolutionFrequencyCount()
{
    public List<int> MajorityElement(int[] nums)
    {
        int n = nums.Length;
        int magicNumber = n / 3;
        Dictionary<int, int> counts = new();
        List<int> results = new();
        Array.Sort(nums);

        foreach (int i in nums)
        {
            if (!counts.ContainsKey(i))
            {
                counts.Add(i, 1);
            }
            else
            {
                counts[i]++;
            }
        }

        foreach (int i in counts.Keys)
        {
            if (counts[i] > magicNumber)
            {
                results.Add(i);
            }
        }

        return results;
    }
}

public class MajorityElementIISolutionSorting()
{
    public List<int> MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        List<int> results = new();
        int n = nums.Length;

        int i = 0;
        while (i < n)
        {
            int j = i + 1;
            while (j < n && nums[j] == nums[i])
            {
                j++;
            }
            if (j - i > n / 3)
            {
                results.Add(nums[i]);
            }
            i = j;
        }
        return results;
    }
}
```