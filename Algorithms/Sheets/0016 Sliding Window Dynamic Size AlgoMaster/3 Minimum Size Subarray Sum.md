
Minimum Size Subarray Sum


Given an array of positive integers nums and a positive integer target, return the minimal length of a subarray whose sum is greater than or equal to target.
If there is no such subarray, return 0 instead.





Example 1:

Input: target = 7, nums = [2,3,1,2,4,3]

Output: 2

Explanation: The subarray [4,3] has the minimal length under the problem constraint.


Example 2:

Input: target = 4, nums = [1,4,4]

Output: 1


Example 3:

Input: target = 11, nums = [1,1,1,1,1,1,1,1]

Output: 0



```cs
// Brute Force Approach
// Test all possible subarrays
// Step 1: Set the starting point and Expand the end point
// Step 2: Accumulate the sum
// Step 3: If target reached, record length and stop expansion
public class MinimumSizeSubarraySum_BruteForce
{
     public int MinSubArrayLen(int s, int[] nums)
     {
        int minLength = int.MaxValue;
        // Iterate starting point of subarray
        for (int start = 0; start < nums.Length; start++)
        {
            int sum = 0;
            // Iterate ending point of subarray
            for (int end = start; end < nums.Length; end++)
            {
                sum += nums[end];
                // Check if current subarray sum is at least s
                if (sum >= s)
                {
                    // Update minLength if current length is smaller
                    minLength = Math.Min(minLength, end - start + 1);
                    break; // Move to the next start point
                }
            }
        }
        return (minLength == int.MaxValue) ? 0 : minLength;
    }
}

// Dynamic Sliding Window Approach
// Step 1: Expand window by moving 'end'
// Step 2: Add current element to window sum
// Step 3: While sum is valid, try to shrink window from 'start'
// Step 4: Update minimum length
// Step 5: Remove 'start' element and move pointer
public class MinimumSizeSubarraySum_SlidingWindow
{
    public int MinSubArrayLen(int s, int[] nums)
    {
        int minLength = int.MaxValue;
        int start = 0, sum = 0;
        // Iterate through the array with the end pointer
        for (int end = 0; end < nums.Length; end++)
        {
            sum += nums[end];
            // Shrink the window from the start as long as the sum is sufficiently large
            while (sum >= s)
            {
                minLength = Math.Min(minLength, end - start + 1);
                sum -= nums[start++];
            }
        }
        return (minLength == int.MaxValue) ? 0 : minLength;
    }
}

```
