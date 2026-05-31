You are given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.

A subarray is a contiguous non-empty sequence of elements within an array.


Example 1:

Input: nums = [2,-1,1,2], k = 2

Output: 4

Explanation: [2], [2,-1,1], [-1,1,2], [2] are the subarrays whose sum is equals to k.


Example 2:

Input: nums = [4,4,4,4,4,4], k = 4

Output: 6



```cs
public class SubarraySumEqualsKBruteForce()
{
    public int SubarraySum(int[] nums, int k)
    {
        int len = nums.Length;
        int result = 0;
        for (int i = 0; i < len; i++)
        {
            int currentSum = 0;
            for (int j = i; j < len; j++)
            {
                currentSum += nums[j];
                if (currentSum == k)
                {
                    result++;
                }
            }
        }
        return result;
    }
}

public class SubarraySumEqualsKHash()
{
    public int SubarraySum(int[] nums, int k)
    {
        int result = 0;
        int current = 0;
        Dictionary<int, int> prefixSums = new();
        prefixSums[0] = 1;

        foreach (int num in nums)
        {
            current += num;
            int diff = current - k;

            if (prefixSums.ContainsKey(diff))
            {
                result += prefixSums[diff];
            }

            if (!prefixSums.ContainsKey(current))
            {
                prefixSums[current] = 0;
            }

            prefixSums[current]++;
        }

        return result;
    }
}
```