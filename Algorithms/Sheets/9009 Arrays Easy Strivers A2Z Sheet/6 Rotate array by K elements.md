Given an array of integers, rotating array of elements by k elements either left or right.

Example 1:
Input: N = 7, array[] = {1,2,3,4,5,6,7} , k=2 , right
Output: 6 7 1 2 3 4 5
Explanation: array is rotated to right by 2 position .

Example 2:
Input: N = 6, array[] = {3,7,8,9,10,11} , k=3 , left 
Output: 9 10 11 3 7 8
Explanation: Array is rotated to left by 3 position.

```cs
public int[] RotateArrayByKElements(int[] arr, int k, bool toRight)
{
	int size = arr.Length;
	if (arr is null) return [];
	if (size < 2) return arr;

	if (toRight)
	{
		ReverseArray(arr, 0, size - k - 1); // Reverse first size-k element
		ReverseArray(arr, size - k, size - 1); // Reverse last k element
		ReverseArray(arr, 0, size - 1); // Reverse whole array
	}
	else
	{
		ReverseArray(arr, 0, k - 1); // Reverse first elements
		ReverseArray(arr, k, size - 1); // Reverse last
		ReverseArray(arr, 0, size - 1); // Reverse whole array
	}

	return arr;
}

private static void ReverseArray(int[] arr, int start, int end)
{
	while (start < end)
	{
		(arr[end], arr[start]) = (arr[start], arr[end]);
		start++;
		end--;
	}
}
```