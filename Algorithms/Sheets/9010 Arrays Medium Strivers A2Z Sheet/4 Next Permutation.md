Problem Statement:

Given an array Arr[] of integers, rearrange the numbers of the given array into the lexicographically next greater permutation of numbers.

If such an arrangement is not possible, it must rearrange to the lowest possible order (i.e., sorted in ascending order).


Examples :


Example 1 :

Input format: Arr[] = {1,3,2}

Output: Arr[] = {2,1,3}

Explanation: All permutations of {1,2,3} are {{1,2,3} , {1,3,2}, {2,13} , {2,3,1} , {3,1,2} , {3,2,1}}. So, the next permutation just after {1,3,2} is {2,1,3}.


Example 2:

Input format: Arr[] = {3,2,1}

Output: Arr[] = {1,2,3}

Explanation: As we see all permutations of {1,2,3}, we find {3,2,1} at the last position. So, we have to return the topmost permutation.



```cs
public int[] GetNextPermutation(int[] arr)
{
	int size = arr.Length;
	int breakpoint = -1;

	// Step 1: Find the break point:
	// Find the largest index such that arr[k] < arr[k+1]
	for (int i = size - 2; i >= 0; i--)
	{
		if (arr[i] < arr[i + 1])
		{
			breakpoint = i;
			break;
		}
	}

	// If break point does not exist:
	// The next permutation is the smallest possible one, which is the array sorted in ascending order
	if (breakpoint == -1)
	{
		Array.Reverse(arr);
		return arr;
	}

	// Step 2: Find the next greater element
	// Find the largest index such that arr[l] > arr[k]
	// and swap it with arr[breakpoint]
	for (int i = size - 1; i > breakpoint; i--)
	{
		if (arr[i] > arr[breakpoint])
		{
			(arr[i], arr[breakpoint]) = (arr[breakpoint], arr[i]);
			break;
		}
	}

	// Step 3: Reverse the right half:
	// Reverse the subarray from ind + 1 to the end.
	// This ensures the right half is sorted in ascending order, making it the lexicographically smallest.
	Array.Reverse(arr, breakpoint + 1, size - (breakpoint + 1));

	return arr;
}
```



Step 1 :

The goal is to find the largest index i (from right to left) such that the element at arr[i] is smaller than the element immediately to its right, arr[i + 1].

This first step is crucial for identifying where in the array we need to make the minimal change to find the next lexicographical permutation.


Step 2:

Find the smallest element in the suffix arr[breakpoint+1...n-1] that is greater than arr[breakpoint], then swap it with arr[breakpoint].


Step 3:

Reverse the entire suffix starting from arr[breakpoint+1] to make it lexicographically the smallest.