Given an integer array sorted in non-decreasing order, remove the duplicates in place such that each unique element appears only once.
The relative order of the elements should be kept the same.
If there are k elements after removing the duplicates, then the first k elements of the array should hold the final result.
It does not matter what you leave beyond the first k elements.
Note: Return k after placing the final result in the first k slots of the array.

```cs
public class RemoveDuplicatesFromSortedArraySolution
{
    public int[] RemoveDuplicates(int[] arr)
    {
        HashSet<int> set = new(arr);
        return set.ToArray();
    }
}
```

In Place : 

```cs
public int RemoveDuplicatesInPlace(int[] nums)
{
	if (nums.Length == 0) return 0;

	int uniqueCount = 1;
	for (int i = 1; i < nums.Length; i++)
	{
		if (nums[i] != nums[i - 1])
		{
			nums[uniqueCount] = nums[i];
			uniqueCount++;
		}
	}
	return uniqueCount;
}
````
