using System;
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestDailyTemperatures()
        {
            int[] temperatures1 = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            int[] temperatures2 = new int[] { 30, 40, 50, 60 };
            int[] temperatures3 = new int[] { 30, 60, 90 };

            int[] output1 = new int[] { 1, 1, 4, 2, 1, 1, 0, 0 };
            int[] output2 = new int[] { 1, 1, 1, 0 };
            int[] output3 = new int[] { 1, 1, 0 };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.DailyTemperatures(temperatures1), output1),
                ResultTester.CheckResult<int[]>(Solution.DailyTemperatures(temperatures2), output2),
                ResultTester.CheckResult<int[]>(Solution.DailyTemperatures(temperatures3), output3),
                ResultTester.CheckResult<int[]>(Solution.DailyTemperatures2(temperatures1), output1),
                ResultTester.CheckResult<int[]>(Solution.DailyTemperatures2(temperatures2), output2),
                ResultTester.CheckResult<int[]>(Solution.DailyTemperatures2(temperatures3), output3),
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Daily Temperatures");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestDailyTemperatures());
        }
    }
}