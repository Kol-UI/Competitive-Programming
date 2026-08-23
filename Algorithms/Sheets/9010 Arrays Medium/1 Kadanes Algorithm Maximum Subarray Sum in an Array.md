Kadane's Algorithm : Maximum Subarray Sum in an Array

Problem Statement: Given an integer array arr, find the contiguous subarray (containing at least one number) which has the largest sum and returns its sum and prints the subarray.


Examples :


Example 1:

Input: arr = [-2,1,-3,4,-1,2,1,-5,4] 

Output: 6 

Explanation: [4,-1,2,1] has the largest sum = 6. 


Examples 2: 

Input: arr = [1] 

Output: 1 

Explanation: Array has only one element and which is giving positive sum of 1. 


```cs
public int MaxiumSubarraySuminanArray(int[] nums)
{
	int maxSum = nums[0];
	int curSum = 0;

	foreach (int n in nums)
	{
		curSum = Math.Max(curSum, 0);
		curSum += n;
		maxSum = Math.Max(maxSum, curSum);
	}
	return maxSum;
}
```



Kadane's Algorithm :

Kadane's algorithm is a greedy/dynamic programming algorithm that can be used on an array.

It is used to calculate the maximum sum subarray ending at a particular position and typically runs in O(n) time.


```cs
public int MaxiumSubarraySuminanArray(int[] nums)
{
	int maxSum = nums[0];
	int curSum = 0;

	foreach (int n in nums)
	{
		// This is a key decision point in Kadane's Algorithm.
		// If 'curSum' (the sum of the current subarray) has become negative,
		// it means continuing this subarray will only decrease future sums.
		// In this case, it's better to "discard" the previous negative sum
		// and start a new subarray from the current element 'n'.
		// By setting 'curSum' to 0, we effectively "restart" the subarray.
		curSum = Math.Max(curSum, 0);
		curSum += n;
		// Update 'maxSum' (the global maximum subarray sum found so far).
		// We compare 'maxSum' with 'curSum' (the best sum ending at the current position).
		// This ensures 'maxSum' always holds the highest sum encountered.
		maxSum = Math.Max(maxSum, curSum);
	}

	return maxSum;
}
```