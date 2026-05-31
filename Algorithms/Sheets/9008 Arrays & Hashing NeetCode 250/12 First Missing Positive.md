You are given an unsorted integer array nums.

Return the smallest positive integer that is not present in nums.

You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.


Example 1:

Input: nums = [-2,-1,0]

Output: 1


Example 2:

Input: nums = [1,2,4]

Output: 3


Example 3:

Input: nums = [1,2,4,5,6,3,1]

Output: 7



```cs
public class FirstMissingPositiveBruteForce()
{
    public int FirstMissingPositive(int[] nums)
    {
        int missing = 1;
        while (true)
        {
            bool found = false;

            foreach (int num in nums)
            {
                if (num == missing)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                return missing;
            }

            missing++;
        }
    }
}

public class FirstMissingPositiveSorting
{
    public int FirstMissingPositive(int[] nums)
    {
        Array.Sort(nums);
        int missing = 1;

        foreach (int num in nums)
        {
            if (num > 0 && num == missing)
            {
                missing++;
            }
        }

        return missing;
    }
}

public class FirstMissingPositiveBooleanArray
{
    public int FirstMissingPositive(int[] nums)
    {
        int len = nums.Length;
        bool[] seen = new bool[len];

        foreach (int num in nums)
        {
            if (num > 0 && num <= len)
            {
                seen[num - 1] = true;
            }
        }

        for (int num = 1; num <= len; num++)
        {
            if (!seen[num - 1])
            {
                return num;
            }
        }

        return len + 1;
    }
}
```