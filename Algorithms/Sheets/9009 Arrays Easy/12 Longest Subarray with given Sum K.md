Longest Subarray with given Sum K

Problem Statement: Given an array and a sum k, we need to print the length of the longest subarray that sums to k.


Examples :


Example 1:

Input Format: N = 3, k = 5, array[] = {2,3,5}

Result: 2

Explanation: The longest subarray with sum 5 is {2, 3}. And its length is 2.



Example 2:

Input Format: N = 5, k = 10, array[] = {2,3,5,1,9}

Result: 3

Explanation: The longest subarray with sum 10 is {2, 3, 5}. And its length is 3.



Example 3:

Input Format: N = 3, k = 1, array[] = {-1, 1, 1}

Result: 3

Explanation: The longest subarray with sum 1 is {-1, 1, 1}. And its length is 3.



Brute Force Approch :

```cs
public int LongestSubarrayBruteForce(int[] arr, int k)
{
	int n = arr.Length;
	int maxLength = 0;

	for (int i = 0; i < n; i++)
	{
		for (int j = i; j < n; j++)
		{
			long currentSum = 0;
			for (int l = i; l <= j; l++)
			{
				currentSum += arr[l];
			}

			if (currentSum == k)
			{
				maxLength = Math.Max(maxLength, j - i + 1);
			}
		}
	}
	return maxLength;
}
```


Hashing Approch :

```cs
public int LongestSubarrayHashing(int[] arr, int k)
{
	int n = arr.Length;
	long currentSum = 0;
	int maxLength = 0;
	Dictionary<long, int> prefixSumValues = new Dictionary<long, int>();

	prefixSumValues[0] = -1;

	for (int i = 0; i < n; i++)
	{
		currentSum += arr[i];

		if (prefixSumValues.ContainsKey(currentSum - k))
		{
			maxLength = Math.Max(maxLength, i - prefixSumValues[currentSum - k]);
		}

		if (!prefixSumValues.ContainsKey(currentSum))
		{
			prefixSumValues[currentSum] = i;
		}
	}
	return maxLength;
}
```

	
```cs
currentSum += arr[i]; // Adds the current element to the running sum.

if (prefixSumValues.ContainsKey(currentSum - k)) // Checks if a past sum exists that, when subtracted from the current sum, equals 'k'.
{
    maxLength = Math.Max(maxLength, i - prefixSumValues[currentSum - k]); // Updates max length if a subarray with sum 'k' is found.
}

if (!prefixSumValues.ContainsKey(currentSum)) // Checks if the current sum is new to our memory.
{
    prefixSumValues[currentSum] = i; // If new, stores this sum with its first occurrence index.
}
```