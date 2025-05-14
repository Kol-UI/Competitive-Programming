Given an array of size n, write a program to check if the given array is sorted in (ascending / Increasing / Non-decreasing) order or not.
If the array is sorted then return True, else return False.
Two consecutive equal values are considered to be sorted.

Example 1:
Input: array[] = {1,2,3,4,5}
Output: True.
Explanation: The given array is sorted i.e Every element in the array is smaller than or equals to its next values, So the answer is True.

Example 2:
Input: array[] = {5,4,6,7,8}
Output: False.
Explanation: The given array is Not sorted i.e Every element in the array is not smaller than or equal to its next values, So the answer is False.
Here element 5 is not smaller than or equal to its future elements.

```cs
// Brute Force Traversal (Mine)
public bool CheckBruteForce(int[] array)
{
	int size = array.Length;
	if (array is null || size < 2) return true;

	int current = array[0];
	for (int i = 0; i < size; i++)
	{
		int next = array[i];
		if (next < current) return false;
		else current = next;
	}

	return true;
}
```

```cs
// Brute Force Nested
public bool CheckBruteForceNested(int[] array)
{
	int size = array.Length;
	if (array is null || size < 2) return true;

	for (int i = 0; i < size; i++)
	{
		for (int j = i + 1; j < size; j++)
		{
			if (array[j] < array[i]) return false;
		}
	}

	return true;
}
```

```cs
// Single Traversal
public bool CheckOptimalSingleTraversal(int[] array)
{
	int size = array.Length;
	if (array is null || size < 2) return true;

	for (int i = 1; i < size; i++)
	{
		if (array[i] < array[i - 1]) return false;
	}

	return true;
}
```