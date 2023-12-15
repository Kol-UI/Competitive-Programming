// Count Tested Devices After Test Operations



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CountTestedDevicesAfterTestOperations
{
    public class Solution
    {
        public static int CountTestedDevices(int[] batteryPercentages)
        {
            var result = 0;
            var value = 0;

            for (int i = 0; i < batteryPercentages.Length; i++)
            {
                if (batteryPercentages[i] - value > 0)
                {
                    result++;
                    value++;
                }
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] batteryPercentages1 = new int[] { 1, 1, 2, 1, 3 };
            int[] batteryPercentages2 = new int[] { 0, 1, 2 };
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountTestedDevices(batteryPercentages1), 3),
                ResultTester.CheckResult<int>(Solution.CountTestedDevices(batteryPercentages2), 2),
            };
            return results;
        }
    }
}