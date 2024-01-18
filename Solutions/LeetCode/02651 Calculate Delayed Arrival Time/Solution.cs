// Calculate Delayed Arrival Time


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CalculateDelayedArrivalTime
{
    public class Solution
    {
        public static int FindDelayedArrivalTime(int arrivalTime, int delayedTime) => (arrivalTime + delayedTime) % 24;    
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindDelayedArrivalTime(15, 5), 20),
                ResultTester.CheckResult<int>(Solution.FindDelayedArrivalTime(13, 11), 0),
            };
            return results;
        }
    }
}