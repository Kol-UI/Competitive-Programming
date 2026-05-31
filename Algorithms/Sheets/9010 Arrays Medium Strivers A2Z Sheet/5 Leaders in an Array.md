Problem Statement: Given an array, print all the elements which are leaders.

A Leader is an element that is greater than all of the elements on its right side in the array.


Examples :


Example 1:

Input: arr = [4, 7, 1, 0]

Output: 7 1 0

Explanation:

Rightmost element is always a leader.

7 and 1 are greater than the elements in their right side.


Example 2:

Input: arr = [10, 22, 12, 3, 0, 6]

Output: 22 12 6

Explanation:

6 is a leader.

In addition to that, 12 is greater than all the elements in its right side (3, 0, 6), also 22 is greater than 12, 3, 0, 6.



Brute Force Approach


```cs
public List<int> GetLeadersBruteForce(int[] arr)
{
	int size = arr.Length;
	List<int> result = new List<int>();

	for (int i = 0; i < size; i++)
	{
		bool leader = true;
		for (int j = i + 1; j < size; j++)
		{
			if (arr[j] > arr[i])
			{
				leader = false;
				break;
			}
		}
		if (leader)
		{
			result.Add(arr[i]);
		}
	}

	return result;
}
```



Bool leader is used because we suppose current value is a leader.

And then we check every int at his right.



From Right to Left Approach


```cs
public List<int> GetLeadersRightToLeft(int[] arr)
{
	List<int> result = new List<int>();
	int size = arr.Length;

	// last is always a leader
	int max = arr[size - 1];
	result.Add(arr[size - 1]);

	for (int i = size - 2; i >= 0; i--)
	{
		if (arr[i] > max)
		{
			// add value and replace max since he is greater
			result.Add(arr[i]);
			max = arr[i];
		}
	}

	result.Reverse();
	return result;
}
```