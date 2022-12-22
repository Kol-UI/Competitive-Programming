using System;
namespace CompetitiveProgramming.LeetCode.DailyTemperatures
{
    public class Solution
    {
        //Given an array of integers temperatures represents the daily temperatures,
        //return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature.
        //If there is no future day for which this is possible, keep answer[i] == 0 instead.
        //Example 1:
        //Input: temperatures = [73, 74, 75, 71, 69, 72, 76, 73]
        //Output: [1,1,4,2,1,1,0,0]
        //Example 2:
        //Input: temperatures = [30, 40, 50, 60]
        //Output: [1,1,1,0]
        //Example 3:
        //Input: temperatures = [30, 60, 90]
        //Output: [1,1,0]

        // Best
        public static int[] DailyTemperatures(int[] temperatures)
        {
            int[] result = new int[temperatures.Length];
            Stack<int> higherTempStack = new();

            for (int i = temperatures.Length - 1; i >= 0; i--)
            {
                int currentTemp = temperatures[i];
                while (higherTempStack.Count > 0 && temperatures[higherTempStack.Peek()] <= currentTemp)
                {
                    higherTempStack.Pop();
                }

                result[i] = higherTempStack.Count == 0 || currentTemp > temperatures[higherTempStack.Peek()] ? 0 : higherTempStack.Peek() - i;
                higherTempStack.Push(i);
            }
            return result;
        }

        // More Runtime & Memory Used
        public static int[] DailyTemperatures2(int[] temperatures)
        {
            for (int i = 0; i < temperatures.Length; ++i)
            {
                int days = 0;
                for (int j = i + 1; j < temperatures.Length; ++j)
                {
                    if (temperatures[i] < temperatures[j])
                    {
                        days = j - i;
                        break;
                    }
                }
                temperatures[i] = days;
            }
            return temperatures;
        }
    }
}

