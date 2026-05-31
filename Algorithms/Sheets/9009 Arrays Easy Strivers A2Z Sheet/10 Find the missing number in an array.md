Poblem Statement: 


Given an integer N and an array of size N-1 containing N-1 numbers between 1 to N. Find the number(between 1 to N), that is not present in the given array.


Examples :


Example 1:

Input Format: N = 5, array[] = {1,2,4,5}

Result: 3

Explanation: In the given array, number 3 is missing. So, 3 is the answer.


Example 2:

Input Format: N = 3, array[] = {1,3}

Result: 2

Explanation: In the given array, number 2 is missing. So, 2 is the answer.


Hashing Approch :


```cs
public int FindMissingNumber(int n, int[] arr)
{
	HashSet<int> seenNumbers = new();

	foreach (int num in arr)
	{
		seenNumbers.Add(num);
	}

	for (int i = 1; i <= n; i++)
	{
		if (!seenNumbers.Contains(i))
		{
			return i;
		}
	}

	return -1;
}
```