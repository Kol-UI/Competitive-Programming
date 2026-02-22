
**Monotinic Stack Definitions**

1. **Monotonic Stack**

A specialized stack where elements are always kept in a specific sorted order (ascending or descending). When a new element violates this order, existing elements are popped until the order is restored.

2. **Monotonic Increasing Stack**

A stack where elements are stored from smallest to largest (bottom to top). If a new element is smaller than the top, you pop elements until the new one can be pushed while maintaining the increasing order.

3. **Monotonic Decreasing Stack**

A stack where elements are stored from largest to smallest (bottom to top). If a new element is larger than the top, you pop elements until the new one can be pushed while maintaining the decreasing order.

**Daily Temperatures**

Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead. 


Example 1:

Input: temperatures = [73,74,75,71,69,72,76,73]

Output: [1,1,4,2,1,1,0,0]


Example 2:

Input: temperatures = [30,40,50,60]

Output: [1,1,1,0]


Example 3:

Input: temperatures = [30,60,90]

Output: [1,1,0]


```cs
// Brute Force Approch
public class Solution
{
    public int[] DailyTemperaturesBruteForce(int[] T)
    {
        int n = T.Length;
        int[] result = new int[n];
        
        for (int i = 0; i < n; i++)
        {
            // Check each following day for a warmer temperature
            for (int j = i + 1; j < n; j++)
            {
                if (T[j] > T[i])
                {
                    result[i] = j - i;
                    break;
                }
            }
            // If no warmer day found, result[i] stays 0
        }
        
        return result;
    }
}

// Monotonic Decreasing Stack Approch
public class Solution
{
    public int[] DailyTemperaturesStack(int[] T)
    {
        int n = T.Length;
        int[] result = new int[n];
        Stack<int> stack = new Stack<int>();
        
        for (int i = 0; i < n; i++)
        {
            // Check if the stack is not empty and the current temperature is greater than that at stack's top index
            while (stack.Count > 0 && T[i] > T[stack.Peek()])
            {
                int index = stack.Pop();
                result[index] = i - index; // The difference in days
            }
            // Push the current index onto the stack
            stack.Push(i);
        }
        
        return result;
    }
}
```