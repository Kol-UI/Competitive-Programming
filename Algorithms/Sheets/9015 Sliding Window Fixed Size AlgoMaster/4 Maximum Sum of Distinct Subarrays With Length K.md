Maximum Sum of Distinct Subarrays With Length K


You are given an integer array nums and an integer k. Find the maximum subarray sum of all the subarrays of nums that meet the following conditions:

The length of the subarray is k, and
All the elements of the subarray are distinct.
Return the maximum subarray sum of all the subarrays that meet the conditions. If no subarray meets the conditions, return 0.

A subarray is a contiguous non-empty sequence of elements within an array.

Example 1:
Input: nums = [1,5,4,2,9,9,9], k = 3

Output: 15

Explanation: The subarrays of nums with length 3 are:

- [1,5,4] which meets the requirements and has a sum of 10.

- [5,4,2] which meets the requirements and has a sum of 11.

- [4,2,9] which meets the requirements and has a sum of 15.

- [2,9,9] which does not meet the requirements because the element 9 is repeated.

- [9,9,9] which does not meet the requirements because the element 9 is repeated.

We return 15 because it is the maximum subarray sum of all the subarrays that meet the conditions

Example 2:
Input: nums = [4,4,4], k = 3

Output: 0

Explanation: The subarrays of nums with length 3 are:

- [4,4,4] which does not meet the requirements because the element 4 is repeated.

We return 0 because no subarrays meet the conditions.



```cs

// Sliding Window - Brute Force Approch
public class MaximumSumofDistinctSubarraysWithLengthK_SlidingWindowBruteForce
{
    public int MaximumSubarraySum(int[] nums, int k)
    {
        int len = nums.Length;
        int maxSum = 0;

        for (int i = 0; i <= len - k; i++)
        {
            bool[] visited = new bool[10001];
            int sum = 0;
            bool isDistinct = true;
            
            for (int j = i; j < i + k; j++)
            {
                if (visited[nums[j]])
                {
                    isDistinct = false;
                    break;
                }
                visited[nums[j]] = true;
                sum += nums[j];
            }
            
            if (isDistinct)
            {
                maxSum = Math.Max(maxSum, sum);
            }
        }

        return maxSum;
    }
}

// Sliding Window - Hash Approch
public class MaximumSumofDistinctSubarraysWithLengthK_SlidingWindowHash
{
    public int MaximumSubarraySum(int[] nums, int k)
    {
        int len = nums.Length;
        HashSet<int> set = [];
        int left = 0, right = 0, sum = 0, maxSum = 0;

        while (right < len)
        {
            // If adding the element keeps the window distinct
            while (set.Contains(nums[right]))
            {
                // Remove element from the left
                set.Remove(nums[left]);
                sum -= nums[left];
                left++;
            }

            // Add new element to the window
            set.Add(nums[right]);
            sum += nums[right];
            right++;

            // Check if we reached the desired window size
            if (right - left == k)
            {
                maxSum = Math.Max(maxSum, sum);
                // Move left to make room for the next element
                set.Remove(nums[left]);
                sum -= nums[left];
                left++;
            }
        }

        return maxSum;
    }
}
```
