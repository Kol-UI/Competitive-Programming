Problem Statement: Given an array that contains only 1 and 0 return the count of maximum consecutive ones in the array.

Examples:

Example 1:

Input: prices = {1, 1, 0, 1, 1, 1}

Output: 3

Explanation: There are two consecutive 1’s and three consecutive 1’s in the array out of which maximum is 3.

Input: prices = {1, 0, 1, 1, 0, 1} 

Output: 2

Explanation: There are two consecutive 1's in the array.

```cs
public int FindMaxConsecutiveOnes(int[] nums)
{
	int maxCount = 0;
	int currentCount = 0;

	foreach (int num in nums)
	{
		if (num == 1)
		{
			currentCount++;
		}
		else
		{
			maxCount = Math.Max(maxCount, currentCount);
			currentCount = 0;
		}
	}

	maxCount = Math.Max(maxCount, currentCount);
	return maxCount;
}
```