
Find the Largest element in an Array
Given an array, we have to find the largest element in the array.

Brute Force (Sorting)
We can sort the array in ascending order, hence the largest element will be at the last index of the array. 
1) Sort the array in ascending order.
2) Return the (size of the array -1)th index.

```cs
public int GetLargestElementInArray(int[] arr)
{
	Array.Sort(arr);
	return arr[arr.Length - 1];
}
```


Counting (Max Variable)
```cs
public int GetLargestElementInArrayVariable(int[] arr)
{
	int max = 0;
	for(int i = 0; i < arr.Length; i++)
	{
		if (arr[i] > max) max = arr[i];
	}
	return max;
}
```


Max Method
```cs
public int GetLargestElementInArrayMax(int[] arr) => arr.Max();
```