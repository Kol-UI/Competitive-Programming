Container With Most Water :

You are given an integer array heights where heights[i] represents the height of the ith bar.

You may choose any two bars to form a container.

Return the maximum amount of water a container can store.


Exemple 1 : 

Input: height = [1,7,2,5,4,7,3,6]

Output: 36


Example 2 :

Input: height = [2,2,2]

Output: 4


```cs
// Two Pointers
public class ContainerWithMostWater
{
	// Find the largest area between two bars
	public int MaxArea(int[] heights)
	{
		int len = heights.Length;
		int left = 0;
		int right = len - 1;
		int maxArea = 0;
		while(left < right)
		{
			// Calculate the area for the current pair of lines
			int currentHeight = Math.Min(heights[left], heights[right]);
			int currentWidth = right - left;
			int area = currentHeight * currentWidth;
			maxArea = Math.Max(area, maxArea);

			if (heights[left] <= heights[right])
			{
				left++;
			}
			else
			{
				right--;
			}
		}
		return maxArea;
	}
}
```