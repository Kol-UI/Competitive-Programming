Maximum Average Subarray I


You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value.
Any answer with a calculation error less than 10-5 will be accepted. 



Example 1:

Input: nums = [1,12,-5,-6,50,3], k = 4

Output: 12.75000

Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75


Example 2:

Input: nums = [5], k = 1

Output: 5.00000


```cs
// Brute Force Approch
public class MaximumAverageSubarrayI
{
    public double FindMaxAverage(int[] nums, int k)
    {
        long biggestSum = long.MinValue;
        // Iterate through each starting point of subarray of length k
        for (int i = 0; i <= nums.Length - k; i++)
        {
            long currentSum = 0;
            // Calculate the sum of subarray starting at index 'i' of length 'k'
            for (int j = i; j < i + k; j++) 
            {
                currentSum += nums[j];
            }
            if (currentSum > biggestSum) biggestSum = currentSum;
        }
        // return average
        return (double)biggestSum/k;
    }
}

// Sliding Window Approch
public class MaximumAverageSubarrayI_SlidingWindow 
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int currentSum = 0;
        // Calculate sum of the first 'k' elements
        for (int i = 0; i < k; i++)
        {
            currentSum += nums[i];
        }
        
        int biggestSum = currentSum;
        
        // Slide the window over the rest of the elements
        for (int i = k; i < nums.Length; i++)
        {
            // Update the current sum by sliding the window
            currentSum = currentSum - nums[i - k] + nums[i]; // nums[i - k] : index that leave the window
            if (currentSum > biggestSum) biggestSum = currentSum;
        }
        
        return (double)biggestSum / k;
    }
}
```
