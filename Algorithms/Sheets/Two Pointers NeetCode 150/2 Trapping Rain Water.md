Trapping Rain Water :

You are given an array of non-negative integers height which represent an elevation map.

Each value height[i] represents the height of a bar, which has a width of 1.

Return the maximum area of water that can be trapped between the bars.

Example 1:

Input: height = [0,2,0,3,1,0,1,3,2,1]

Output: 9


```cs
public class TrappingRainWater
{
	public int Trap(int[] height)
	{
		if (height == null || height.Length == 0)
			return 0;

		int left = 0;
		int right = height.Length - 1;
		int leftMax = height[left];
		int rightMax = height[right];

		int result = 0;
		while (left < right)
		{
			// We only move the pointer that points to the shorter maximum wall
			// The water level at the current bar is always determined by the shorter wall
			if (leftMax < rightMax)
			{
				left++;
				leftMax = Math.Max(leftMax, height[left]);
				result += leftMax - height[left];
			}
			else
			{
				right--;
				rightMax = Math.Max(rightMax, height[right]);
				result += rightMax - height[right];
			}
		}
		return result;
	}
}
```