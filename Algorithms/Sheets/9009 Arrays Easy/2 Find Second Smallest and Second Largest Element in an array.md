Find Second Smallest and Second Largest Element in an array

Given an array, find the second smallest and second largest element in the array.
Print ‘-1’ in the event that either of them doesn’t exist.
(Without Sorting)

```cs
public int GetSecondSmallest(int[] arr)
{
	int size = arr.Length;
	if (arr is null || size < 2) return -1;

	int smallest = arr[0];
	int secondSmallest = int.MaxValue;

	for (int i = 0; i < size; i++)
	{
		if (arr[i] < smallest)
		{
			secondSmallest = smallest;
			smallest = arr[i];
		}
		else if (arr[i] < secondSmallest && arr[i] != smallest)
		{
			secondSmallest = arr[i];
		}
	}

	return secondSmallest;
}

public int GetSecondLargest(int[] arr)
{
	int size = arr.Length;
	if (arr is null || size < 2) return -1;

	int largest = arr[0];
	int secondLargest = int.MaxValue;

	for (int i = 0; i < size; i++)
	{
		if (arr[i] > largest)
		{
			secondLargest = largest;
			largest = arr[i];
		}
		else if (arr[i] > secondLargest && arr[i] != largest)
		{
			secondLargest = arr[i];
		}
	}

	return secondLargest;
}
```